namespace D7.FileSystem;

public class Directory : FileSystemItem
{
    public Directory? Parent { get; } = null;

    public List<FileSystemItem> Child { get; } = new List<FileSystemItem>();

    protected override int CalculateSize()
    {
        return Child.Sum(c => c.Size);
    }

    public Directory(string name, Directory parent) : base()
    {
        this.Name = name;
        this.Parent = parent;
    }
}
