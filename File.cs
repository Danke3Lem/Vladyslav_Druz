class File : SystemSingleItem
{
    float FileSize;

    protected override void Copy()
    {
        Console.WriteLine("Item is Copied.");
    }

    protected override void Move()
    {
        Console.WriteLine("Item is Moved.");
    }

    protected override void Remove()
    {
        Console.WriteLine("Item is Removed.");
    }

    protected override void Edit()
    {
        Console.WriteLine("Item is Edited.");
    }

    protected virtual float GetFileSize(float fileSize)
    {
        return fileSize;
    }

    public File(float fileSize)
    {
        FileSize = fileSize;
    }
}