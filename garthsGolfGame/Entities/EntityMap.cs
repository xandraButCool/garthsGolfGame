class EntityMap
{

    public static Entity[,] entityGrid = new Entity[Map.GridWidth,Map.GridHeight];

    /// <summary>
    /// Sets all the entity tiles to chosen value.
    /// </summary>
    /// <param name="setTo"> The value to set the grid too. Defults to 1.</param>
      public static void ResetEntityMap()
    {
        for (int x = 0; x < Map.TotalGridSize; x++)
        {
            entityGrid[x % Map.GridWidth, x / Map.GridWidth] = new EntityBlank();
        } 
    }

    public static void PopulateEnitityMap()
    {
        //places player
        entityGrid[Map.teeX - 1, Map.GridHeight - 1] = new EntityPlayer();
    }

    // <summary>
    /// Displays the raw map values to the console.
    /// </summary>
    public static void WriteEntityMap()
    {
        for (int y = 0; y < Map.GridHeight; y++)
        {
            for (int x = 0; x < Map.GridWidth; x++)
            {
                Console.Write(entityGrid[x,y]);
            }
            Console.WriteLine();
        }
    }
}