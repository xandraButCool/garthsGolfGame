using System.Drawing;

public class TileSand : Tile
{
    public override char DisplayChar => '*';
    public override string Color => "yellow";
    public override bool Overwriteable => true;
}