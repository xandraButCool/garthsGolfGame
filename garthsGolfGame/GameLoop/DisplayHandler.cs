using System.ComponentModel.Design.Serialization;
using System.Formats.Asn1;

class DisplayHandler
{
    public const int DisplayWidth = 40;
    public const int DisplayHeight = 15;
    const int BoarderWidth = 1;

    public static void DrawFrame()
    {
        Console.BackgroundColor = ConsoleColor.Black;
        for (int y = 0; y < DisplayHeight; y++)
        {
            for (int x = 0; x < DisplayWidth; x++)
            {
                if (x > BoarderWidth -1 & x < Map.GridWidth +1 & y < Map.GridHeight +1 & y > BoarderWidth -1)
                {
                  DisplayMapInfo(x,y);  
                }
                else if (x == Map.GridWidth +1 || x == 0)
                {
                    if (y == Map.GridHeight +1 || y == 0)
                    {
                        DrawTile("darkRed",'+');
                    }
                    else
                    {
                        DrawTile("darkRed",'|');
                    }
                }
                else if (y == Map.GridHeight +1 || y == 0)
                {
                    DrawTile("darkRed",'-');
                }
                else
                {
                    DrawTile("darkMagenta",'#');
                }
            }
            Console.WriteLine();
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
        }
        Console.Write(tileCharacter);
    } 
}