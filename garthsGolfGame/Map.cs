class Map
{
    static int[,] infoGrid = {{1,1,3},{2,2,3}};

    public static void WriteMap()
    {
        for (int x = 0; x < infoGrid.GetLength(0); x++)
        {
            for (int y = 0; y < infoGrid.GetLength(1); y++)
            {
                Console.Write(infoGrid[x,y]);
            }
            Console.WriteLine();
        }
    }
}