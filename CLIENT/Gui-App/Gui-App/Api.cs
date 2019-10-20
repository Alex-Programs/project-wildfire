using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace Gui_App
{
    public class Api
    {
        public static IDictionary<string, Wildfire> ApiData;

        public static async Task Fetch()
        {
            //Fetch data from ben's api, code taken from project Crazy Norwegian
            HttpWebRequest EmberRequest = (HttpWebRequest)WebRequest.Create("http://ember.benargo.co.uk/");
            EmberRequest.Method = "GET";
            EmberRequest.Accept = "application/json";
            try
            {
                Debug.WriteLine("Requesting data from http://ember.benargo.co.uk...");
                WebResponse Response = await EmberRequest.GetResponseAsync();
                using (StreamReader ResponseReader = new StreamReader(Response.GetResponseStream()))
                {
                    Debug.WriteLine("Awaiting response from API...");
                    string ResponseContent = await ResponseReader.ReadToEndAsync();
                    Debug.WriteLine(ResponseContent);
                    ApiData = JsonConvert.DeserializeObject<Dictionary<string, Wildfire>>(ResponseContent);
                    Debug.WriteLine(ApiData);
                }
            }
            catch (WebException ex)
            {
                Debug.WriteLine($"WebException {ex}");
            }
            catch (JsonReaderException ex)
            {
                Debug.WriteLine($"JsonReaderException {ex}");
            }
        }

        public void Parse()
        {
            //parse data into *
        }


        //public Dictionary Export()
        //{
        //    //export data as a dict
        //}
    }
}