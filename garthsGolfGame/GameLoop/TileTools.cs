public class TileTools // holds a set of values for most recently checked tile.
{
    public static bool validLocation = false;
    public static bool mapOverwriteable = false;
    public static int tileX, tileY;
    public static char mapTileChar = '_';
    public static bool hasEntity = false;
    public static bool isBall = false;
    public static char enitityTileChar = '_';

    public static bool SetTileAdjecentDir(int startingX, int startingY, int direction)
    {
        if (direction == 4 || direction == 7 || direction == 1)
        {
            tileX = startingX - 1;
        } else if (direction == 9 || direction == 3 || direction == 6)
        {
            tileX = startingX + 1;
        } else
        {
            tileX = startingX;
        }

        if (direction == 7 || direction == 8 || direction == 9)
        {
            tileY = startingY - 1;
        } else if (direction == 1 || direction == 2 || direction == 3)
        {
            tileY = startingY + 1;
        } else
        {
            tileY = startingY;
        }

        if ((tileX > Map.GridWidth-1)||(tileX < 0)||(tileY > Map.GridHeight-1)||(tileY < 0))
        {
            validLocation = false;
            return false;
        } else
        {
            mapOverwriteable = Map.infoGrid[tileX,tileY].Overwriteable;
            mapTileChar = Map.infoGrid[tileX,tileY].DisplayChar;

            validLocation = true;
            return true;
        }
    }
}