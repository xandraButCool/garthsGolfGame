using System.Drawing;

public class TileRough : Tile
{
    public override char DisplayChar => '*';
    public override string Color => "green";
    public override bool Overwriteable => true;
}