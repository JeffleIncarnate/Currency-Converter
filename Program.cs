using System;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Currency_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Currencies = new List<string>();
            Currencies.AddRange(new string[] {"", "",
            "", "", ""
            });



            // var url = "https://api.apilayer.com/currency_data/convert?to=GBP&from=USD&amount=100";

            // var httpRequest = (HttpWebRequest)WebRequest.Create(url);

            // httpRequest.Headers["apikey"] = "uQvrOvY98Px1fsgLmvDtkCSEOtYtWpLK";
            // httpRequest.Headers["Authorization"] = "apikey: uQvrOvY98Px1fsgLmvDtkCSEOtYtWpLK";


            // var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
            // using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            // {
            //     var result = streamReader.ReadToEnd();
            //     JObject resultJson = JObject.Parse(result);
            // }
        }
    }
}