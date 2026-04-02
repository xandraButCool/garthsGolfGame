using System.Drawing;

public class TileFairway : Tile
{
    public override char DisplayChar => '#';
    public override string Color => "lightGreen";
    public override bool Overwriteable => false;
}