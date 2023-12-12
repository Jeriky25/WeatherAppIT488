using System;
using System.Net;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;
using System.Xml.Linq;

namespace WeatherApp
{
    public partial class Form1 : Form
    {
        string city;
        string maxTemp;
        string minTemp;
        string windSpeed;
        string humidity;
        
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnShowWeather_Click(object sender, EventArgs e)
        {
            city = txtCity.Text;
            string url = string.Format("http://api.weatherapi.com/v1/forecast.xml?key=46d22bedb4824b5485a172113201209&q={0}&days=1", city);
            XDocument document = XDocument.Load(url);

            maxTemp = (string)document.Descendants("maxtemp_f").FirstOrDefault();
            minTemp = (string)document.Descendants("mintemp_f").FirstOrDefault();
            windSpeed = (string)document.Descendants("maxwind_mph").FirstOrDefault();
            humidity = (string)document.Descendants("avghumidity").FirstOrDefault();

            txtMaxTemp.Text = maxTemp;
            txtMinTemp.Text = minTemp;
            txtWindSpeed.Text = windSpeed;
            txtHumidity.Text = humidity;
        }
    }
}
