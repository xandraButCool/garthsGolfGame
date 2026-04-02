using System.ComponentModel.Design.Serialization;
using System.Formats.Asn1;
using System.Security.Cryptography.X509Certificates;

class DisplayHandler
{
    public const int DisplayWidth = 40;
    public const int DisplayHeight = 15;
    const int BoarderWidth = 1;
    
    public static void DrawFrame()
    {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.Black;
        for (int y = 0; y < DisplayHeight; y++)
        {
            for (int x = 0; x < DisplayWidth; x++)
            {
               DisplayTileLogic(x,y); 
            }
            Console.WriteLine();
        }
    }

    static void DisplayTileLogic(int x, int y)
    {
        if (x > BoarderWidth -1 & x < Map.GridWidth +1 & y < Map.GridHeight +1 & y > BoarderWidth -1) // map display
        {
            DisplayMapInfo(x,y);  
        } else if (x == Map.GridWidth +1 || x == 0 || x == DisplayWidth - 1) // boarder collumns
        {
            if (y == Map.GridHeight +1 || y == 0 || y == DisplayHeight - 1)
            {
                DrawTile("yellow",'+');
            } else
            {
                DrawTile("yellow",'|');
            }
        } else if (y == Map.GridHeight +1 || y == 0 || y == DisplayHeight - 1) // boarder rows
        {
            DrawTile("yellow",'-');
        } else if (y == Map.GridHeight +2 || y == Map.GridHeight +3) // bellow map info boxes
        {
            if (x > 0 & x < 16)
            {
                DrawTile("darkCyan",Levels.levelTileBar[y-Map.GridHeight-2,x-1]);
            } else if (x > Map.GridWidth + 1)
            {
                DrawTile("darkMagenta",'#'); 
            }
        } else
        {
            DrawTile("darkMagenta",'#');
        }
    }

    static void DisplayMapInfo(int overallX, int overallY)
    {
        int adjustedX = overallX - BoarderWidth;
        int adjustedY = overallY - BoarderWidth;
        if (EntityMap.entityGrid[adjustedX,adjustedY].Rendered == false)
            DrawTile(Map.infoGrid[adjustedX,adjustedY].Color, Map.infoGrid[adjustedX,adjustedY].DisplayChar);
        else
            DrawTile(EntityMap.entityGrid[adjustedX,adjustedY].Color, EntityMap.entityGrid[adjustedX,adjustedY].DisplayChar);
    }

    static void DrawTile(string color = "white", char tileCharacter = ' ')
    {
        switch (color){
            case "white":
                Console.ForegroundColor = ConsoleColor.White;
                break;
            case "red":
                Console.ForegroundColor = ConsoleColor.Red;
                break;
            case "yellow":
                Console.ForegroundColor = ConsoleColor.Yellow;
                break;
            case "darkYellow":
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                break;
            case "green":
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                break;
            case "blue":
                Console.ForegroundColor = ConsoleColor.Blue;
                break;
            case "magenta":
                Console.ForegroundColor = ConsoleColor.Magenta;
                break;
            case "cyan":
                Console.ForegroundColor = ConsoleColor.Cyan;
                break;
            case "darkMagenta":
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                break;
            case "lightGreen":
                Console.ForegroundColor = ConsoleColor.Green;
                break;
            case "darkRed":
                Console.ForegroundColor = ConsoleColor.DarkRed;
                break;
            case "darkCyan":
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                break;
        }
        Console.Write(tileCharacter);
    } 
}