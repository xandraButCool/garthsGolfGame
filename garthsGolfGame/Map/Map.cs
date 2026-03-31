using System.Data;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.Marshalling;

class Map
{
    public const int GridWidth = 15;
    public const int GridHeight = 10;
    public const int TotalGridSize = GridWidth * GridHeight;
    public static Tile[,] infoGrid = new Tile[GridWidth,GridHeight];

    // it will actualy place one more than the number here. I dont entirely know why, but its not worth fixing.
    const int TilesPerWaterFeature = 11;

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
        if (Levels.numOfWaterFeatures > 0)
        {
            PlaceWaterFeatures();
        }
        // Trees.PlaceTrees();
        // Fairway.GenerateFairway();
        PlaceSandtraps();
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

    /// <summary>
    /// places a number of 
    /// </summary>
    public static void PlaceWaterFeatures()
    {
        if (Levels.numOfWaterFeatures == 0)
            return;

        int placedWaterTiles = 0;
        while (placedWaterTiles < Levels.numOfWaterFeatures)
        {
            int placementX = Program.rand.Next(0,GridHeight-1);
            int placementY = Program.rand.Next(1,GridHeight-1);

            if (infoGrid[placementX, placementY].Overwriteable)
            {
                infoGrid[placementX,placementY] = new TileWater();
                placedWaterTiles++; 
            }
        }
        
        int failedFindLoops = 0;

        while (placedWaterTiles <= Levels.numOfWaterFeatures * TilesPerWaterFeature)
        {
            int buildNextTo = Program.rand.Next(1,placedWaterTiles);
            int waterTilesSeen = 0;
            for (int y = 0; y < GridHeight; y++)
            {
                for (int x = 0; x < GridWidth; x++)
                {
                    if (infoGrid[x,y] is not TileWater)
                        continue;
                    
                    waterTilesSeen ++;
                    if (waterTilesSeen == buildNextTo)
                    {
                        if (failedFindLoops > (GridHeight * GridWidth))
                        {
                            return;
                        }
                        var (newX,newY) = RandomOverwritableAgacentLocation(x,y);
                        if ((newX == 256)&&(newY == 256))
                        {
                            failedFindLoops++;
                            continue;
                        }
                        infoGrid[newX,newY] = new TileWater();
                        failedFindLoops = 0;
                        placedWaterTiles ++;
                    }
                }
            } 
        }
    }
    
    public static void PlaceSandtraps()
    {
        Console.WriteLine($"Placed {Levels.numOfSandTraps} sand traps.");
        // STUB: add sand trap generation
    }

    /// <summary>
    /// Returns a random location from all overwritable tiles that are adjacent to the tile (including diagonals)
    /// </summary>
    /// <param name="initialX"> X location of the tile to be adjacent to. </param>
    /// <param name="initialY"> Y location of the tile to be adjacent to. </param>
    /// <returns> X,Y value of a random tile that is both overwritable and adjacent to the tile input. (int,int) format</returns>
    static (int,int) RandomOverwritableAgacentLocation(int initialX, int initialY)
    {
        int newX, newY;

        List<(int,int)> possibleLocations = new List<(int, int)> {};
        
        for (int y = -1; y <= 1; y++)
        {
            for (int x = -1; x <= 1; x++)
            {
                newX = initialX + x;
                newY = initialY + y;
                if ((newX > GridWidth-1)||(newX < 0)||(newY > GridHeight-1)||(newY < 0))
                {

                } else if (infoGrid[newX,newY].Overwriteable == true)
                {
                    possibleLocations.Add((newX,newY));               
                } 
            }
        }

        if (possibleLocations.Count <= 0)
        {
            return (256,256);
        } else {
            int selectedLocation = Program.rand.Next(0,possibleLocations.Count);
            var (returnX,returnY) = possibleLocations[selectedLocation];
            return(returnX,returnY);
        }
    }
}