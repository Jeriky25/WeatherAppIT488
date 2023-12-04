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

namespace WeatherApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GetWeatherData(string location)
        {
            var client = new RestClient($"https://wttr.in/{WebUtility.UrlEncode(location)}?format=%C+%t+%w+%h");

            var request = new RestRequest();
            request.AddParameter("method", "GET");

            var response = client.Execute(request);

            if (response.IsSuccessful)
            {
                string[] weatherParameters = Regex.Split(response.Content, " ");

                Console.WriteLine("Weather: " + weatherParameters[0]);
                Console.WriteLine("Tempurature: " + weatherParameters[1]);
                Console.WriteLine("Wind: " + weatherParameters[2]);
            }
            else
            {
                MessageBox.Show("Error: " + response.StatusCode);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetWeatherData("Carol Stream");
        }
    }
}
