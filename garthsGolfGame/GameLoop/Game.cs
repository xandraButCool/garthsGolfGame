class Game
{
    public static void SetToGameStart()
    {
        Levels.levelNumber = 1;
        Map.BuildNewLevel();
        Map.WriteMap();
    }
}