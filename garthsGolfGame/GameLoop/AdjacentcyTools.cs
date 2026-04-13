public class AdjacentcyTools // holds a set of values for most recently checked tile.
{
    public static bool validLocation = false;
    public static bool mapOverwriteable = false;
    public static char mapTileChar = '_';
    public static bool hasEntity = false;
    public static char enitityTileChar = '_';

    public static bool UpdateValues(int startingX, int startingY, int direction)
    {
        int checkX, checkY;

        if (direction == 2 || direction == 1 || direction == 3)
        {
            checkX = startingX++;
        }  else if (direction == 6 || direction == 7 || direction == 5)
        {
            checkX = startingX--;
        } else
        {
            checkX = startingX;
        }

        if (direction == 0 || direction == 1 || direction == 8)
        {
            checkY = startingY++;
        }  else if (direction == 3 || direction == 4 || direction == 5)
        {
            checkY = startingY--;
        } else
        {
            checkY = startingY;
        }

        if ((checkX > Map.GridWidth-1)||(checkX < 0)||(checkY > Map.GridHeight-1)||(checkY < 0))
        {
            validLocation = false;
            return false;
        } else
        {
            mapOverwriteable = Map.infoGrid[checkX,checkY].Overwriteable;
            mapTileChar = Map.infoGrid[checkX,checkY].DisplayChar;

            validLocation = true;
            return true;
        }
    }
}