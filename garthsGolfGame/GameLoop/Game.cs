using System.Collections;

class Game
{
    public static bool levelCompletted = false;
    public static int facing = 6;
    public static int ballFacing = 8;
    public static int playerX, playerY, ballX, ballY;
    
    public static void SetToGameStart()
    {
        Levels.levelNumber = 1;
        Map.BuildNewLevel();
        EntityMap.ResetEntityMap(); 
        EntityMap.PopulateEnitityMap();
        Levels.levelTileBar[8] = '1';       
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
        checkHoleForBall();
        if (Map.infoGrid[ballX,ballY] is TileWater)
        {
           ballX = Map.teeX; ballY = Map.GridHeight - 1;
        }
        return;
  
    }

    static void checkHoleForBall()
    {
        if (Map.holeX == ballX && Map.holeY == ballY)
        {
            levelCompletted = true;
        }
    }

}