namespace D7.FileSystem;

public abstract class FileSystemItem
{
    public int Size { get { return CalculateSize(); } }
    public string Name { get; protected set; } = string.Empty;

    protected abstract int CalculateSize();
}
