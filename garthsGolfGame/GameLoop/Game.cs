using System.Collections;

class Game
{
    public static bool levelCompletted = false;
    public static int facing = 1;
    public static int playerX, playerY, ballX, ballY;
    
    public static void SetToGameStart()
    {
        Levels.levelNumber = 1;
        Map.BuildNewLevel();
        EntityMap.ResetEntityMap(); 
        Levels.levelTileBar[0,8] = '1';       
    }

    public static void RunLevels()
    {
        do
        { 
            do
            {
                DisplayHandler.DrawFrame();
                InputCommands.GetInput();
                resolveTurn();
            } while (levelCompletted == false);

            // hole finished screen before continuing
            Levels.LevelIncrease();
            Map.BuildNewLevel();
            levelCompletted = false;
            
        } while (Levels.levelNumber < Levels.TotalLevels);

        // win screen
    }

    public static void resolveTurn()
    {
        
    }
    public static void moveBall(int power, int direction)
    {
        
    }

    static void checkHoleForBall()
    {
        
    }

}