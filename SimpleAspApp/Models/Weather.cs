using System;

namespace SimpleAspApp.Models
{
    public class Weather
    {
        public Weather()
        {
            this.Location = "San Francisco";
            this.Date = DateTime.Now;
            this.ForeCast = "Fog";
            this.Temperature = 65;
        }

        public string Location { get; set; }
        public DateTime Date { get; set; }
        public string ForeCast { get; set; }
        public int Temperature { get; set; }
    }
}
