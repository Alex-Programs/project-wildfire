using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;

namespace Gui_App
{
    public class Api
    {
        protected IDictionary<string, string> ApiData;

        public async void Main()
        {
            //Fetch data from ben's api, code taken from project Crazy Norwegian
            HttpWebRequest EmberRequest = (HttpWebRequest)WebRequest.Create("http://ember.benargo.co.uk/");
            EmberRequest.Method = "GET";
            EmberRequest.Accept = "application/json";
            try
            {
                WebResponse Response = await EmberRequest.GetResponseAsync();
                using (StreamReader ResponseReader = new StreamReader(Response.GetResponseStream()))
                {
                    string ResponseContent = await ResponseReader.ReadToEndAsync();
                    ApiData = JsonConvert.DeserializeObject<Dictionary<string, string>>(ResponseContent);
                    Console.WriteLine(ApiData);
                }
            }
            catch (WebException ex)
            {
                Console.WriteLine($"Web exception {ex}");
            }
        }

        public void Parse()
        {
            //parse data into *
        }

        public void GeoFilter()
        {
            //make sure it's in Indonesia
        }

        //public Dictionary Export()
        //{
        //    //export data as a dict
        //}
    }
}