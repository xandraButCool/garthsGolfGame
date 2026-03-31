using System.Drawing;

public class TileTree : Tile
{
    public override char DisplayChar => '!';
    public override string Color => "green";
    public override bool Overwriteable => false;
}