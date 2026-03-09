using System.Data;
using System.Runtime.InteropServices.Marshalling;

class Map
{
    const int GridWidth = 15;
    const int GridHeight = 10;
    const int TotalGridSize = GridWidth * GridHeight;
    static Tile[,] infoGrid = new Tile[GridWidth,GridHeight];

    /// <summary>
    /// Sets all the map tiles to chosen value.
    /// </summary>
    /// <param name="setTo"> The value to set the grid too. Defults to 1.</param>
      public static void ResetMap(int setTo = 1)
    {
        for (int x = 0; x < TotalGridSize; x++)
        {
            infoGrid[x % GridWidth, (x / GridWidth)] = new TileBlank();
        } 
    }

    /// <summary>
    /// Displays the raw map values to the console.
    /// </summary>
    public static void WriteMap()
    {
        for (int y = 0; y < GridHeight; y++)
        {
            for (int x = 0; x < GridWidth; x++)
            {
                Console.Write(infoGrid[x,y]);
            }
            Console.WriteLine();
        }
    }

    /// <summary>
    /// Resets the map and the builds a new hole for the course.
    /// </summary>
    public static void BuildNewLevel()
    {
        ResetMap();
        PlaceTeeAndHole();
        PlaceLargeObsticals();
        CreateFairway();
        PlaceSmallObstacles(); // remove so that the opponent grid can be a seperate grid layer
    }

    /// <summary>
    /// Places a the hole and tee on the grid.
    /// </summary>
    /// <param name="holeAlignment"> choses where in the map the hole will be. NOT IMPLEMENTED.</param>
    /// <param name="teeAlignment"> Choses where on the botom of the map the tee will be. NOT IMPLEMENTED.</param>
    static void PlaceTeeAndHole(int holeAlignment = 3, int teeAlignment = 0)
    {
        int holeLocation = Program.rand.Next(0,8);
        infoGrid[(GridWidth - 3) + (holeLocation % 3), holeLocation / 3] = new TileFlag();
        infoGrid[Program.rand.Next(1, GridWidth-2), GridHeight - 1] = new TileTee();
    }

    static void PlaceLargeObsticals(int numberOfObsticals = 0)
    {
        // places water hazards and dence forests
    }

    static void CreateFairway()
    {
        // creates a path from the tee to the green
    }

    static void PlaceSmallObstacles(int numberOfGecks = 0, int numberOfSandTraps = 0)
    {
        // places golf geckos and sand traps
    }
}