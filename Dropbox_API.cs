namespace WebAPI_Tests;

public class DropboxApi
{
    private string _token = "sl.BWh8ue1aw37CNvvDG4v8Y0_iNpZ-ls208GBgOndirVJocaJ9D1GsXnLGfuFs1XAn9BW1wIncEN-bNPPjDFBbjieU5-zDf-S6wS6c9xCzUj5vVOlBDcGfZQ4HwzSV7QYV_Dl1WfGL-pZr";
    private HttpClient _client;

    public DropboxApi()
    {
        _client = new HttpClient();
    }

    public JObject UploadFileMethod(string file, string dbPath)
    {
        HttpRequestMessage req = new HttpRequestMessage
        {
            Method = HttpMethod.Post,
            RequestUri = new Uri("https://content.dropboxapi.com/2/files/upload"),
            Headers = {{"Authorization", $"Bearer {_token}" }, { "Dropbox-API-Arg", $"{{\"path\":\"{dbPath}\"}}"}},
            Content = new StreamContent(new FileStream(file, FileMode.Open)),
        };

        req.Content.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");
        HttpResponseMessage resp = _client.SendAsync(req).Result;
        
        //Checking for any errors code while uploading the file

        if (resp.IsSuccessStatusCode)
        {
            return JObject.Parse(resp.Content.ReadAsStringAsync().Result);
        }

        else
        {
            throw new Exception("ERROR! Cannot upload the file, please, try again.");
        }
    }

    public JObject GetFileMetadataMethod(string dbPath)
    {
        HttpRequestMessage req = new HttpRequestMessage
        {
            Method = HttpMethod.Post,
            RequestUri = new Uri("https://api.dropboxapi.com/2/files/get_metadata"),
            Headers = {{"Authorization", $"Bearer {_token}"}},
            Content = new StringContent($"{{\"path\": \"{dbPath}\"}}", Encoding.UTF8, "application/json")
        };

        req.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
        HttpResponseMessage resp = _client.SendAsync(req).Result;
        
        //Checking for any errors code while getting metadata
        
        if (resp.IsSuccessStatusCode)
        {
            return JObject.Parse(resp.Content.ReadAsStringAsync().Result);
        }

        else
        {
            throw new Exception("ERROR! Cannot get metadata of the file, please, try again.");
        }
    }

    public JObject DeleteFileMethod(string dbPath)
    {
        HttpRequestMessage req = new HttpRequestMessage
        {
            Method = HttpMethod.Post,
            RequestUri = new Uri("https://api.dropboxapi.com/2/files/delete"),
            Headers = {{"Authorization", $"Bearer {_token}"}},
            Content = new StringContent($"{{\"path\": \"{dbPath}\"}}", Encoding.UTF8, "application/json")
        };

        req.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
        HttpResponseMessage resp = _client.SendAsync(req).Result;
        
        //Checking for any errors code while deleting the file

        if (resp.IsSuccessStatusCode)
        {
            return JObject.Parse(resp.Content.ReadAsStringAsync().Result);
        }

        else
        {
            throw new Exception("ERROR! Cannot delete the file, please, try again.");
        }
    }
}  
