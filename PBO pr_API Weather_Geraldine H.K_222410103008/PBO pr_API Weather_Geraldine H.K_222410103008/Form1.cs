using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http;

namespace PBO_pr_API_Weather_Geraldine_H.K_222410103008
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string APIKey = "7042f53e1ce30ef34f3818bc9145fc93";

        private void label2_Click(object sender, EventArgs e)
        {
            getWeather();
        }

        private async void getWeather()
        {
            using (HttpClient httpClient = new HttpClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", txtBoxKota.Text, APIKey);
                var json = await httpClient.GetStringAsync(url);
                Weather.root Info = JsonConvert.DeserializeObject<Weather.root>(json);

                pic_Cuaca.ImageLocation = "https://openweathermap.org/img/w/" + Info.weather[0].icon + ".png";
                labelkondisi.Text = Info.weather[0].main;
                labeldetail.Text = Info.weather[0].description;
                labelsunrise.Text = convertDateTime(Info.sys.sunset).ToString();
                labelsunset.Text = convertDateTime(Info.sys.sunrise).ToString();
                labelwindspeed.Text = Info.wind.speed.ToString();
                labelpressure.Text = Info.main.pressure.ToString();

            }
        }
        DateTime convertDateTime(long millisec)
        {
            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            day = day.AddSeconds(millisec).ToLocalTime();
            return day;
        }
    }
}