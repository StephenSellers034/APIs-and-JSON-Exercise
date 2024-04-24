using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using static System.Net.WebRequestMethods;

namespace APIsAndJSON
{
    public class  RonVSKanyeAPI
    {
        HttpClient client = new HttpClient();
        public string RonSwanson()
        {
            HttpClient client = new HttpClient();
            string ronUrl = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

            var ronResponse = client.GetStringAsync(ronUrl).Result;

            JArray ronObject = JArray.Parse(ronResponse);
            
            return ronObject[0].ToString();

        }
        public string KayneWest()
        {
            string kayneUrl = "https://api.kanye.rest/";

            string kayneResponse = client.GetStringAsync(kayneUrl).Result;

            JObject kayneObject = JObject.Parse(kayneResponse);
            
            return kayneObject["quote"].ToString();
        }
    }
}
