class Shortcut : SystemSingleItem
{
    bool _isHidden;

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

    protected virtual void IsHidden(bool _isHidden)
    {
        if (_isHidden)
            Console.WriteLine("Shortcut is hidden");
        else
            Console.WriteLine("Shortcut isn't hidden");
    }
}