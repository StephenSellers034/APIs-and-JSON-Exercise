using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace APIsAndJSON
{
    
    public class OpenWeatherMapAPI
    {
        HttpClient client1 = new HttpClient();

        public string weather()
        {
            var weatherUrl = "https://api.openweathermap.org/data/2.5/weather?q=richmond&appid=65c2c77a8c365caf466fee785641f7af&units=imperial";

            var weatherReturn = client1.GetStringAsync(weatherUrl).Result;

            var weatherObject = JObject.Parse(weatherReturn);

            return weatherObject["main"]["temp"].ToString();


        }
    }
}
