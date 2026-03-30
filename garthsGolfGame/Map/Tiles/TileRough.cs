using System.Drawing;

public class TileRough : Tile
{
    public override char DisplayChar => '*';
    public override string Color => "dark green";
    public override bool Overwriteable => true;
}