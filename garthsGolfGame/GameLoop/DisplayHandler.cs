using System.ComponentModel.Design.Serialization;

class DisplayHandler
{
    public const int DisplayWidth = 40;
    public const int DisplayHeight = 15;

    public static void DrawFrame()
    {
        Console.BackgroundColor = ConsoleColor.Black;
        for (int y = 0; y < DisplayHeight; y++)
        {
            for (int x = 0; x < DisplayWidth; x++)
            {
                if (x < Map.GridWidth & y < Map.GridHeight)
                {
                  DrawTile(Map.infoGrid[x,y].Color, Map.infoGrid[x,y].DisplayChar);  
                }
                else if (x-1 == Map.GridWidth)
                {
                    if (y-1 == Map.GridHeight)
                    {
                        DrawTile("yellow",'+');
                    }
                    else
                    {
                        DrawTile("yellow",'|');
                    }
                }
                else if (y-1 == Map.GridHeight)
                {
                    DrawTile("yellow",'-');
                }
                else
                {
                    DrawTile("yellow",'#');
                }
            }
            Console.WriteLine();
        }
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
            case "darkMagenta":
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                break;
            case "lightGreen":
                Console.ForegroundColor = ConsoleColor.Green;
                break;
            default:
                Console.ForegroundColor = ConsoleColor.White;
                break;
        }
        Console.Write(tileCharacter);
    } 
}