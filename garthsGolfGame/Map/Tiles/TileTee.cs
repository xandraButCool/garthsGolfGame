using System.Drawing;

public class TileTee : Tile
{
    public override char DisplayChar => 'T';
    public override string Color => "yellow";
    public override bool Overwriteable => false;
}