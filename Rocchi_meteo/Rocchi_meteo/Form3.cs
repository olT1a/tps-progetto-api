using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rocchi_meteo
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        string[] time;
        int i = 0;
        private void Form3_Load(object sender, EventArgs e)
        {
            time = Form1.f1.weather_Info.hourly.time[i].ToString().Split('T');
            lbl_citta.Text = Form1.f1.txt_citta.Text.ToUpper();
            lbl_data_value.Text = time[0];
            lbl_current_weather_value.Text = Form1.f1.weather_Info.current_weather.temperature.ToString();
            lbl_tmax_value.Text = Form1.f1.weather_Info.daily.temperature_2m_max[i].ToString();
            lbl_tmin_value.Text = Form1.f1.weather_Info.daily.temperature_2m_min[i].ToString();
            lbl_windspeed_value.Text = Form1.f1.weather_Info.current_weather.windspeed.ToString() + "Km/h";
            switch (Form1.f1.weather_Info.current_weather.weathercode)
            {
                case 0:
                    {
                        BackgroundImage = Image.FromFile(@".\\clear_sky.jpg");

                    } break;
                case 1: case 2: case 3:
                    {
                        BackgroundImage = Image.FromFile(@".\\mainly_clear.jpg");
                        break;
                    }
                case 45: case 48:
                    {
                        BackgroundImage = Image.FromFile(@".\\fog.jpg");
                        break;
                    }
                case 51: case 53: case 55:
                    {
                        BackgroundImage = Image.FromFile(@".\\drizzle.jpg");
                        break;
                    }
                case 56: case 57:
                    {
                        BackgroundImage = Image.FromFile(@".\\freezing_drizzle.jpg");
                        break;
                    }
                case 61: case 63: case 65:
                    {
                        BackgroundImage = Image.FromFile(@".\\slight_rain.jpg");
                        break;
                    }
                case 66: case 67:
                    {
                        BackgroundImage = Image.FromFile(@".\\light_raing.jpg");
                        break;
                    }
                case 71: case 73: case 75:
                    {
                        BackgroundImage = Image.FromFile(@".\\snow_fall.jpg");
                        break;
                    }
                case 77:
                    {
                        BackgroundImage = Image.FromFile(@".\\snow_grains.jpg");
                        break;
                    }
                case 80: case 81: case 82:
                    {
                        BackgroundImage = Image.FromFile(@".\\heavy_rain.jpg");
                        break;
                    }
                case 85: case 86:
                    {
                        BackgroundImage = Image.FromFile(@".\\heavy_snow.jpg");
                        break;
                    }
                case 95:
                    {
                        BackgroundImage = Image.FromFile(@".\\thunderstorm.jpg");
                        break;
                    }
                case 96: case 99:
                    {
                        BackgroundImage = Image.FromFile(@".\\hail.jpg");
                        break;
                    }

                    
            }
        }

        private void btn_forecast_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1.f1.Show();
        }
    }
}
