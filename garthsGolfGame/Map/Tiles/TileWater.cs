using System.Drawing;

public class TileWater : Tile
{
    public override char DisplayChar => 'w';
    public override string Color => "blue";
    public override bool Overwriteable => false;
}