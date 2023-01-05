namespace WebAPI_Tests;

public class DropboxApi
{
    private string _token = "sl.BWV0onZgVaZqZDcvAxu2V2v8Mmxz2RlUh42t0fJQgVLwPIeah3g5LP6O32umrpVUszJb6_YNL3tzd0WbdEJfWSzjeIDb5pOx1kZelJd93K_nbl2ww-iBtoZvPMHKrr6Ip4tvGGFMnMbR";
    private HttpClient _client;

    public DropboxApi()
    {
        _client = new HttpClient();
    }

    public void UploadFileMethod(string file, string db_path)
    {
        HttpRequestMessage req = new HttpRequestMessage
        {
            Method = HttpMethod.Post,
            RequestUri = new Uri("https://content.dropboxapi.com/2/files/upload"),
            Headers = {{"Authorization", $"Bearer {_token}" }, { "Dropbox-API-Arg", $"{{\"path\":\"{db_path}\"}}"}},
            Content = new StreamContent(new FileStream(file, FileMode.Open)),
        };

        req.Content.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");
        HttpResponseMessage resp = _client.SendAsync(req).Result;
    }

    public JObject GetFileMetadataMethod(string db_path)
    {
        HttpRequestMessage req = new HttpRequestMessage
        {
            Method = HttpMethod.Post,
            RequestUri = new Uri("https://api.dropboxapi.com/2/files/get_metadata"),
            Headers = {{"Authorization", $"Bearer {_token}"}},
            Content = new StringContent($"{{\"path\": \"{db_path}\"}}", Encoding.UTF8, "application/json")
        };

        req.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
        HttpResponseMessage resp = _client.SendAsync(req).Result;
        return JObject.Parse(resp.Content.ReadAsStringAsync().Result);
    }

    public void DeleteFileMethod(string db_path)
    {
        HttpRequestMessage req = new HttpRequestMessage
        {
            Method = HttpMethod.Post,
            RequestUri = new Uri("https://api.dropboxapi.com/2/files/delete"),
            Headers = {{"Authorization", $"Bearer {_token}"}},
            Content = new StringContent($"{{\"path\": \"{db_path}\"}}", Encoding.UTF8, "application/json")
        };

        req.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
        HttpResponseMessage resp = _client.SendAsync(req).Result;
    }
}  
