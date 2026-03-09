public abstract class Club
{
    public abstract char DisplayChar { get; }
    public abstract string Color { get; }
    public abstract int MaxRange { get; }

    public override string ToString()
    {
        return DisplayChar.ToString();
    }
}