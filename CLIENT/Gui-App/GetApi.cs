using System;
using System.Net;
using System.Net.Http;

public class Api
{
	public async void Fetch()
	{
        //Fetch data from ben's api, code taken from project Crazy Norwegian
        HttpWebRequest apiRequest = (HttpWebRequest)WebRequest.Create(tokenEndpoint);
        apiRequest.Method = "POST";
        apiRequest.ContentType = "multipart/form-data; boundary=" + formDataBoundary;
        apiRequest.Accept = "application/json";
        try
        {
            WebResponse tokenResponse = await apiRequest.GetResponseAsync();
            using (StreamReader reader = new StreamReader(tokenResponse.GetResponseStream()))
                string responseText = await reader.ReadToEndAsync();
            Dictionary<string, string> tokenEndpointDecoded = JsonConvert.DeserializeObject<Dictionary<string, string>>(responseText);
            clientAuthToken = tokenEndpointDecoded["access_token"];
        }
        catch (WebException ex)
        {
            Console.WriteLine($"Web exception {ex}");
        }

        Console.WriteLine(responseText);
    }
    
    public void Parse()
    {
        //parse data into *
    }

    public void GeoFilter()
    {
        //make sure it's in Indonesia
    }

    public Dictionary Export()
    {
        //export data as a dict
    }

    public GetAndProcess()
    {
        Fetch();
        //run the above functions in the right order and stuff
    }
    public static void main()
    {
        //every two hours get and process, different functions so you can force update
        GetAndProcess();
        
    }
}
