namespace WebAPI_Tests;

public class TaskTests
{
    [Test, Order(1)]
    public void UploadFileTest()
    {
        DropboxApi client = new DropboxApi();
        client.UploadFileMethod("../../../kotik.jpg", "/WebAPI_Tests/kotik.jpg");
    }

    [Test, Order(2)]
    public void GetFileMetadataTest()
    {
        DropboxApi client = new DropboxApi();
        JObject metadataInfo = client.GetFileMetadataMethod("/WebAPI_Tests/kotik.jpg");
        JToken tokenName;

        Assert.IsTrue(metadataInfo.TryGetValue("name", out tokenName));
    }

    [Test, Order(3)]
    public void DeleteFileTest()
    {
        DropboxApi client = new DropboxApi();
        client.DeleteFileMethod("/WebAPI_Tests/kotik.jpg");
    }
}
