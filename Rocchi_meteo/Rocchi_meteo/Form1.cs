using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection.Emit;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rocchi_meteo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static HttpClient client = new HttpClient();
        Rootobject_coordinates coordinates = new Rootobject_coordinates();
        int i = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void btn_cerca_Click(object sender, EventArgs e)
        {
            await get_coordinates();
            await get_weather_info();
        }
        public async Task<Rootobject_coordinates> get_coordinates()
        {

            string url = $"https://geocoding-api.open-meteo.com/v1/search?name={txt_citta.Text}&language=it";

            HttpResponseMessage response = await client.GetAsync(url);
            MessageBox.Show(response.ToString());
            if (response.IsSuccessStatusCode)
            {

                coordinates = await JsonSerializer.DeserializeAsync<Rootobject_coordinates>(await response.Content.ReadAsStreamAsync());
                MessageBox.Show(Math.Round(coordinates.results[i].latitude,2).ToString() + " " + Math.Round(coordinates.results[i].longitude,2).ToString());
            }
       
            return coordinates;

        }
        public async Task<Rootobject_weather_info> get_weather_info()
        {
            Rootobject_weather_info weather_Info = new Rootobject_weather_info();
            string url = $"https://api.open-meteo.com/v1/forecast?latitude={ Math.Round(coordinates.results[i].latitude,2).ToString().Replace(',', '.') }&longitude={ Math.Round(coordinates.results[i].longitude,2).ToString().Replace(',', '.') }&hourly=temperature_2m&current_weather=true ";
            
            HttpResponseMessage response = await client.GetAsync(url);
            MessageBox.Show(response.ToString());
            if (response.IsSuccessStatusCode)
            {

                weather_Info = await JsonSerializer.DeserializeAsync<Rootobject_weather_info>(await response.Content.ReadAsStreamAsync());

                lbl_c_temperature.Text = weather_Info.current_weather.temperature.ToString();
                lbl_time.Text = weather_Info.current_weather.time.ToString();
                lbl_windspeed.Text = weather_Info.current_weather.windspeed.ToString();

            }
            return weather_Info;
        }
    }

    public class Rootobject_coordinates
    {
        public Result[] results { get; set; }
    }

    public class Result
    {
        public int id { get; set; }
        public string name { get; set; }
        public float latitude { get; set; }
        public float longitude { get; set; }
        public float elevation { get; set; }
        public string feature_code { get; set; }
        public string country_code { get; set; }
        public int admin1_id { get; set; }
        public int admin2_id { get; set; }
        public int admin3_id { get; set; }
        public int admin4_id { get; set; }
        public string timezone { get; set; }
        public int population { get; set; }
        public string[] postcodes { get; set; }
        public int country_id { get; set; }
        public string country { get; set; }
        public string admin1 { get; set; }
        public string admin2 { get; set; }
        public string admin3 { get; set; }
        public string admin4 { get; set; }
    }


    public class Rootobject_weather_info
    {
        public float latitude { get; set; }
        public float longitude { get; set; }
        public float elevation { get; set; }
        public float generationtime_ms { get; set; }
        public int utc_offset_seconds { get; set; }
        public string timezone { get; set; }
        public string timezone_abbreviation { get; set; }
        public Hourly hourly { get; set; }
        public Hourly_Units hourly_units { get; set; }
        public Current_Weather current_weather { get; set; }
    }

    public class Hourly
    {
        public string[] time { get; set; }
        public float[] temperature_2m { get; set; }
    }

    public class Hourly_Units
    {
        public string temperature_2m { get; set; }
    }

    public class Current_Weather
    {
        public string time { get; set; }
        public float temperature { get; set; }
        public int weathercode { get; set; }
        public float windspeed { get; set; }
        public float winddirection { get; set; }
    }


}
