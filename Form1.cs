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
using System.IO;

namespace WeatherApp
{
    public partial class Form1 : Form
    {
        string city;
        string maxTemp;
        string minTemp;
        string windSpeed;
        string humidity;
        string cloud;
        
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

            string iconUrl = (string)document.Descendants("icon").FirstOrDefault();

            WebClient client = new WebClient();

            byte[] image = client.DownloadData("http:" + iconUrl);

            MemoryStream stream = new MemoryStream(image);

            Bitmap newBitmap = new Bitmap(stream);
            maxTemp = (string)document.Descendants("maxtemp_f").FirstOrDefault();
            minTemp = (string)document.Descendants("mintemp_f").FirstOrDefault();
            windSpeed = (string)document.Descendants("maxwind_mph").FirstOrDefault();
            humidity = (string)document.Descendants("avghumidity").FirstOrDefault();
            cloud = (string)document.Descendants("text").FirstOrDefault();

            Bitmap icon = newBitmap;

            txtMaxTemp.Text = maxTemp;
            txtMinTemp.Text = minTemp;
            txtWindSpeed.Text = windSpeed;
            txtHumidity.Text = humidity;
            status.Text = cloud;
            pictureBox1.Image = icon;
        }

        private void btnWeek_Click(object sender, EventArgs e)
        {
          DataTable dt = new DataTable();
          dt.Columns.Add("Date", typeof(string));
          dt.Columns.Add("Max Temp. °F", typeof(string));
          dt.Columns.Add("Min Temp. °F", typeof(string));
          dt.Columns.Add("Wind Speed mph", typeof(string));
          dt.Columns.Add("Humidity", typeof(string));
          dt.Columns.Add("Cloud", typeof(string));
          dt.Columns.Add("Icon", typeof(Image));

          city = txtCity.Text;

          string url = string.Format("http://api.weatherapi.com/v1/forecast.xml?key=46d22bedb4824b5485a172113201209&q={0}&days=7", city);

          XDocument document = XDocument.Load(url);

          foreach (var npc in document.Descendants("forecastday"))
          {
              string iconUrl = (string)npc.Descendants("icon").FirstOrDefault();

              WebClient client = new WebClient();

              byte[] image = client.DownloadData("http:" + iconUrl);

              MemoryStream stream = new MemoryStream(image);

              Bitmap newBitmap = new Bitmap(stream);

              dt.Rows.Add(new object[] 
              { 
                  (string)document.Descendants("date").FirstOrDefault(),
                  (string)npc.Descendants("maxtemp_f").FirstOrDefault(),
                  (string)npc.Descendants("mintemp_f").FirstOrDefault(),
                  (string)npc.Descendants("maxwind_mph").FirstOrDefault(),
                  (string)npc.Descendants("avghumidity").FirstOrDefault(),
                  (string)npc.Descendants("text").FirstOrDefault(),
                  newBitmap
              });
          }
          dataGridView1.DataSource = dt;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
