using Newtonsoft.Json;

namespace WebAPI_Tests;

public class TaskTests
{
    [Test, Order(1)]
    public void UploadFileTest()
    {
        DropboxApi client = new DropboxApi();
        JObject metadataInfo = client.UploadFileMethod("../../../kotik.jpg", "/WebAPI_Tests/kotik.jpg");

        string name = (string)metadataInfo.GetValue("name");
        ulong size = (ulong)metadataInfo.GetValue("size");
        JToken tokenError;

        Assert.AreEqual("kotik.jpg", name);
        Assert.AreEqual(353069, size);
        Assert.IsFalse(metadataInfo.TryGetValue("error", out tokenError));
    }

    [Test, Order(2)]
    public void GetFileMetadataTest()
    {
        DropboxApi client = new DropboxApi();
        JObject metadataInfo = client.GetFileMetadataMethod("/WebAPI_Tests/kotik.jpg");
        
        string name = (string)metadataInfo.GetValue("name");
        ulong size = (ulong)metadataInfo.GetValue("size");
        JToken tokenError;

        Assert.AreEqual("kotik.jpg", name);
        Assert.AreEqual(353069, size);
        Assert.IsFalse(metadataInfo.TryGetValue("error", out tokenError));
    }

    [Test, Order(3)]
    public void DeleteFileTest()
    {
        DropboxApi client = new DropboxApi();
        JObject metadataInfo = client.DeleteFileMethod("/WebAPI_Tests/kotik.jpg");
        
        string name = (string)metadataInfo.GetValue("name");
        ulong size = (ulong)metadataInfo.GetValue("size");
        JToken tokenError;

        Assert.AreEqual("kotik.jpg", name);
        Assert.AreEqual(353069, size);
        Assert.IsFalse(metadataInfo.TryGetValue("error", out tokenError));
    }
}
