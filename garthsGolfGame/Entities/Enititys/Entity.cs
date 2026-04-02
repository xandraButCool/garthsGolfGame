public abstract class Entity
{
    public abstract char DisplayChar { get; }
    public abstract string Color { get; }
    public abstract bool Rendered { get; }

    public override string ToString()
    {
        return DisplayChar.ToString();
    }
}