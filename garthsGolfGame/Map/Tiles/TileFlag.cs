using System.Drawing;

public class TileFlag : Tile
{
    public override char DisplayChar => '4';
    public override string Color => "red";
    public override bool Overwriteable => false;
}