class Game
{
    public static void SetToGameStart()
    {
        Levels.levelNumber = 1;
        Map.BuildNewLevel();
        Map.WriteMap();
        Console.WriteLine("");
        EntityMap.ResetEntityMap();
        EntityMap.WriteEntityMap();
    }

    public static void NextLevel()
    {
        Levels.LevelIncrease();
        Map.BuildNewLevel();
        Map.WriteMap();
        Console.WriteLine("");
        EntityMap.ResetEntityMap();
        EntityMap.WriteEntityMap();
    }
}