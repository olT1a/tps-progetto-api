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
        public static Form1 f1;
        public Form1()
        {
            InitializeComponent();
            f1 = this;
        }
        static HttpClient client = new HttpClient();
        public Rootobject_coordinates coordinates = new Rootobject_coordinates();
        public Rootobject_weather_info weather_Info = new Rootobject_weather_info();
        int i = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            empty_labels();
            btn_current.Enabled = false;
        }

        private async void btn_cerca_Click(object sender, EventArgs e)
        {
            empty_labels();
            if (txt_citta.Text != "")
            {
                await get_coordinates();
                await get_weather_info();
                btn_current.Enabled = true;
            }
        }
        public async Task<Rootobject_coordinates> get_coordinates()
        {

            string url = $"https://geocoding-api.open-meteo.com/v1/search?name={txt_citta.Text}&language=it";

            HttpResponseMessage response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                coordinates = await JsonSerializer.DeserializeAsync<Rootobject_coordinates>(await response.Content.ReadAsStreamAsync());
                //MessageBox.Show(Math.Round(coordinates.results[i].latitude, 2).ToString() + " " + Math.Round(coordinates.results[i].longitude, 2).ToString());
            }

            return coordinates;

        }
        public async Task<Rootobject_weather_info> get_weather_info()
        {

            string url = $"https://api.open-meteo.com/v1/forecast?latitude={Math.Round(coordinates.results[i].latitude, 2).ToString().Replace(',', '.')}&longitude={Math.Round(coordinates.results[i].longitude, 2).ToString().Replace(',', '.')}&hourly=temperature_2m&daily=temperature_2m_max,temperature_2m_min&current_weather=true&timezone=Europe%2FBerlin";

            HttpResponseMessage response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                weather_Info = await JsonSerializer.DeserializeAsync<Rootobject_weather_info>(await response.Content.ReadAsStreamAsync());
                set_hours(weather_Info);
                set_temperature(weather_Info);
                //int i = 0;
                //MessageBox.Show(weather_Info.daily.temperature_2m_max[i].ToString());
                //lbl_c_temperature.Text = weather_Info.current_weather.temperature.ToString();
                //lbl_time.Text = weather_Info.current_weather.time.ToString();
                //lbl_windspeed.Text = weather_Info.current_weather.windspeed.ToString();

            }
            return weather_Info;
        }
        public void set_temperature(Rootobject_weather_info a)
        {
            for (int i = 0; i < a.hourly.temperature_2m.Length; i++)
            {
                if (i < 24)
                {
                    lbl_temp_1.Text += a.hourly.temperature_2m[i].ToString() + "\n";
                }
                if (i > 23 && i < 48)
                {
                    lbl_temp_2.Text += a.hourly.temperature_2m[i].ToString() + "\n";
                }
                if (i > 47 && i < 72)
                {
                    lbl_temp_3.Text += a.hourly.temperature_2m[i].ToString() + "\n";
                }
                if (i > 71 && i < 96)
                {   
                    lbl_temp_4.Text += a.hourly.temperature_2m[i].ToString() + "\n";
                }
                if (i > 95 && i < 120)
                {
                    lbl_temp_5.Text += a.hourly.temperature_2m[i].ToString() + "\n";
                }
                if (i > 119 && i < 144)
                {
                    lbl_temp_6.Text += a.hourly.temperature_2m[i].ToString() + "\n";
                }
                if (i > 143 && i < 168)
                {
                    lbl_temp_7.Text += a.hourly.temperature_2m[i].ToString() + "\n";
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
                    lbl_data_1.Text = time[0];
                    lbl_ora_1.Text += time[1] + "\n";
                }
                if (i > 23 && i < 48)
                {
                    lbl_data_2.Text = time[0];
                    lbl_ora_2.Text += time[1] + "\n";
                }
                if (i > 47 && i < 72)
                {
                    lbl_data_3.Text = time[0];
                    lbl_ora_3.Text += time[1] + "\n";
                }
                if (i > 71 && i < 96)
                {
                    lbl_data_4.Text = time[0];
                    lbl_ora_4.Text += time[1] + "\n";
                }
                if (i > 95 && i < 120)
                {
                    lbl_data_5.Text = time[0];
                    lbl_ora_5.Text += time[1] + "\n";
                }
                if (i > 119 && i < 144)
                {
                    lbl_data_6.Text = time[0];
                    lbl_ora_6.Text += time[1] + "\n";
                }
                if (i > 143 && i < 168)
                {
                    lbl_data_7.Text = time[0];
                    lbl_ora_7.Text += time[1] + "\n";
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
            lbl_ora_1.Text = "";
            lbl_ora_2.Text = "";
            lbl_ora_3.Text = "";
            lbl_ora_4.Text = "";
            lbl_ora_5.Text = "";
            lbl_ora_6.Text = "";
            lbl_ora_7.Text = "";
            /*lbl_c_temperature.Text = "";
            lbl_time.Text = "";
            lbl_windspeed.Text = "";*/
        }

        private void btn_current_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
        }

    }
}
