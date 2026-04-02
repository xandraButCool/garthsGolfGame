using System.Drawing;

public class TileSand : Tile
{
    public override char DisplayChar => 's';
    public override string Color => "darkYellow";
    public override bool Overwriteable => true;
}