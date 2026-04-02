using System.Collections;

class Game
{
    public static bool levelCompletted = false;
    public static void SetToGameStart()
    {
        Levels.levelNumber = 1;
        Map.BuildNewLevel();
        EntityMap.ResetEntityMap();
        DisplayHandler.DrawFrame();
    }

    public static void RunLevels()
    {
        do
        { 
            do
            {
                DisplayHandler.DrawFrame();
                InputCommands.GetInput();
                TurnResolver.resolveTurn();
            } while (levelCompletted == false);

            // hole finished screen before continuing
            Levels.LevelIncrease();
            Map.BuildNewLevel();
            levelCompletted = false;
            
        } while (Levels.levelNumber < Levels.TotalLevels);

        // win screen
    }


}