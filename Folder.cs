class Folder : SystemItem
{
    bool _isEmpty;

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

    protected virtual void IsEmpty(bool _isEmpty)
    {
        if (_isEmpty)
            Console.WriteLine("Folder is empty");
        else
            Console.WriteLine("Folder isn't empty");
    }

    public Folder(bool isEmpty)
    {
        _isEmpty = isEmpty;
    }
}