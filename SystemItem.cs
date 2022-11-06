abstract class SystemItem
{
    string _name;
    string _description;

    public string Name { get { return _name; } }
    public string Description { get { return _description; } }

    protected abstract void Copy();
    protected abstract void Move();
    protected abstract void Remove();
}
