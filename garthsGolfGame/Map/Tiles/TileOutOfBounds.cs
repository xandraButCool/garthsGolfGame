using System.Drawing;

public class TileOutOfBounds : Tile
{
    public override char DisplayChar => '#';
    public override string Color => "green";
    public override bool Overwriteable => true;
}