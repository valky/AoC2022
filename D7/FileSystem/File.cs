namespace D7.FileSystem;

public class File : FileSystemItem
{
    public string ParentName { get; }

    private int size;
    protected override int CalculateSize()
    {
        return size;
    }

    public File(string name, int size, string parentName) : base()
    {
        this.Name = name;
        this.size = size;

        this.ParentName = parentName;
    }
}
