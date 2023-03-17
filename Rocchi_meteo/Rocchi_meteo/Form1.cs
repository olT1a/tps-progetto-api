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
            empty_labels();
        }

        private async void btn_cerca_Click(object sender, EventArgs e)
        {
            empty_labels();
            if (txt_citta.Text != "")
            {
                await get_coordinates();
                await get_weather_info();
            }


        }
        public async Task<Rootobject_coordinates> get_coordinates()
        {

            string url = $"https://geocoding-api.open-meteo.com/v1/search?name={txt_citta.Text}&language=it";

            HttpResponseMessage response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                coordinates = await JsonSerializer.DeserializeAsync<Rootobject_coordinates>(await response.Content.ReadAsStreamAsync());
                MessageBox.Show(Math.Round(coordinates.results[i].latitude, 2).ToString() + " " + Math.Round(coordinates.results[i].longitude, 2).ToString());
            }

            return coordinates;

        }
        public async Task<Rootobject_weather_info> get_weather_info()
        {
            Rootobject_weather_info weather_Info = new Rootobject_weather_info();
            string url = $"https://api.open-meteo.com/v1/forecast?latitude={Math.Round(coordinates.results[i].latitude, 2).ToString().Replace(',', '.')}&longitude={Math.Round(coordinates.results[i].longitude, 2).ToString().Replace(',', '.')}&hourly=temperature_2m&current_weather=true&timezone=Europe%2FBerlin ";

            HttpResponseMessage response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                weather_Info = await JsonSerializer.DeserializeAsync<Rootobject_weather_info>(await response.Content.ReadAsStreamAsync());
                set_temperature(weather_Info);
                set_hours(weather_Info);
                

                lbl_c_temperature.Text = weather_Info.current_weather.temperature.ToString();
                lbl_time.Text = weather_Info.current_weather.time.ToString();
                lbl_windspeed.Text = weather_Info.current_weather.windspeed.ToString();

            }
            return weather_Info;
        }
        public void set_temperature(Rootobject_weather_info a)
        {
            for (int i = 0; i < a.hourly.temperature_2m.Length; i++)
            {
                if (i < 24)
                {
                    lbl_temp_1.Text += "    " + a.hourly.temperature_2m[i].ToString();
                }
                if (i > 23 && i < 48)
                {
                    lbl_temp_2.Text += "    " + a.hourly.temperature_2m[i].ToString();
                }
                if (i > 47 && i < 72)
                {
                    lbl_temp_3.Text += "    " + a.hourly.temperature_2m[i].ToString();
                }
                if (i > 71 && i < 96)
                {
                    lbl_temp_4.Text += "    " + a.hourly.temperature_2m[i].ToString();
                }
                if (i > 95 && i < 120)
                {
                    lbl_temp_5.Text += "    " + a.hourly.temperature_2m[i].ToString();
                }
                if (i > 119 && i < 144)
                {
                    lbl_temp_6.Text += "    " + a.hourly.temperature_2m[i].ToString();
                }
                if (i > 143 && i < 168)
                {
                    lbl_temp_7.Text += "    " + a.hourly.temperature_2m[i].ToString();
                }
            }
        }
        public void set_hours(Rootobject_weather_info a)
        {
            string[] time;
            for (int i = 0; i < a.hourly.time.Length; i++)
            {
                time = a.hourly.time[i].ToString().Split('T');

                if (i < 24)
                {
                    lbl_ora_1.Text += "    " + time[1];
                }
                if (i > 23 && i < 48)
                {
                    lbl_ora_2.Text += "    " + time[1];
                }
                if (i > 47 && i < 72)
                {
                    lbl_ora_3.Text += "    " + time[1];
                }
                if (i > 71 && i < 96)
                {
                    lbl_ora_4.Text += "    " + time[1];
                }
                if (i > 95 && i < 120)
                {
                    lbl_ora_5.Text += "    " + time[1];
                }
                if (i > 119 && i < 144)
                {
                    lbl_ora_6.Text += "    " + time[1];
                }
                if (i > 143 && i < 168)
                {
                    lbl_ora_7.Text += "    " + time[1];
                }
            }
        }
        public void empty_labels()
        {
            lbl_temp_1.Text = "";
            lbl_temp_2.Text = "";
            lbl_temp_3.Text = "";
            lbl_temp_4.Text = "";
            lbl_temp_5.Text = "";
            lbl_temp_6.Text = "";
            lbl_temp_7.Text = "";
            lbl_data_1.Text = "";
            lbl_data_2.Text = "";
            lbl_data_3.Text = "";
            lbl_data_4.Text = "";
            lbl_data_5.Text = "";
            lbl_data_6.Text = "";
            lbl_data_7.Text = "";
            lbl_c_temperature.Text = "";
            lbl_time.Text = "";
            lbl_windspeed.Text = "";
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
