public abstract class Tile
{
    public abstract char DisplayChar { get; }
    public abstract string Color { get; }

    public override string ToString()
    {
        return DisplayChar.ToString();
    }
}