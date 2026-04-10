using System.Diagnostics.Contracts;

public class Levels
{
    /// <summary>
    /// Tracks what hole you are on. For the first 9 and/or 18 holes also tracks what will show up on the course.
    /// </summary>
    public static int levelNumber = 0;
    public const int TotalLevels = 6; // update as you sdd levels
    public static char[,] levelTileBar = {{'_','L','E','V','E','L',':','_','0','_','_','_','_','_','_'},{'_','_','_','_','_','_','_','_','_','_','_','_','_','_','_'}};


    /// <summary>
    /// Wont be used unless I add an endless mode. Determains the number of obstacles on the course
    /// </summary>
    public static int levelDifficulty = 0;
    
    public static int numOfWaterFeatures = 0;
    public static int numOfSandTraps = 1;
    public static int holelocation = 2;
    public static int teeLocation = 2;


    /// <summary>
    /// Increases the level number and sets the number and types of obstacles.
    /// </summary>
    public static void LevelIncrease()
    {
        levelNumber++;
        switch (levelNumber) // STUB: fill with level cases once level generation is working as intended.
        {
            case 1:
                levelTileBar[0,8] = '1';
                numOfSandTraps = 1;
                break;
            case 2:
                levelTileBar[0,8] = '2';
                numOfSandTraps = 2;
                holelocation = 3;
                break;
            case 3:
                levelTileBar[0,8] = '3';
                numOfSandTraps = 1;
                numOfWaterFeatures = 1;
                break;
            case 4:
                levelTileBar[0,8] = '4';
                numOfWaterFeatures = 0;
                numOfSandTraps = 4;
                holelocation = 1;
                teeLocation = 3;
                break;
            case 5:
            levelTileBar[0,8] = '5';
                numOfWaterFeatures = 3;
                numOfSandTraps = 1;
                teeLocation = 1;
                holelocation = 3;
                break;
            default:
                break;
        }
    }
}