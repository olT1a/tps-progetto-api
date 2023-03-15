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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void btn_cerca_Click(object sender, EventArgs e)
        {
            await get();
        }
        public async Task<Rootobject> get()
        {
            Rootobject r = new Rootobject();
            int i = 0;
            string url = $"https://geocoding-api.open-meteo.com/v1/search?name={txt_citta.Text}&language=it";
            HttpResponseMessage response = await client.GetAsync(url);
            MessageBox.Show(response.ToString());
            if (response.IsSuccessStatusCode)
            {

                r = await JsonSerializer.DeserializeAsync<Rootobject>(await response.Content.ReadAsStreamAsync());
                MessageBox.Show(r.results[i].latitude + " " + r.results[i].longitude);
            }
            return r;

        }
    }

    public class Rootobject
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

}
