using System.Collections;

class Game
{
    public static void SetToGameStart()
    {
        Levels.levelNumber = 1;
        Map.BuildNewLevel();
        EntityMap.ResetEntityMap();
        DisplayHandler.DrawFrame();
    }

    public static void NextLevel()
    {
        Levels.LevelIncrease();
        Map.BuildNewLevel();
        DisplayHandler.DrawFrame();
    }

}