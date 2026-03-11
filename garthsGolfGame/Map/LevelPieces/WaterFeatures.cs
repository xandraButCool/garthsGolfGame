// holds the info for generating and the types of water feature

class WaterFeatures
{
    

    public static void PlaceWaterFeatures()
    {
        int placedWaterTiles = 0;
        for (int wf = 0; wf < Levels.numOfWaterFeatures; wf++)
        {
            Map.infoGrid[Program.rand.Next(0,Map.GridHeight-1),Program.rand.Next(1,Map.GridHeight-1)] = new TileWater();
            placedWaterTiles++;
        }
        /*
        while (placedWaterTiles >= Levels.numOfWaterFeatures * 8)
        {
            
        }
        */
        // STUB: add water feature generation

        Console.WriteLine($"Placed {Levels.numOfWaterFeatures} water features.");
        // Console.WriteLine($"Made {placedWaterTiles} water tiles.");
    }
}