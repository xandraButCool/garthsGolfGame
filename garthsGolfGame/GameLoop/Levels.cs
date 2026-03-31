using System.Diagnostics.Contracts;

public class Levels
{
    /// <summary>
    /// Tracks what hole you are on. For the first 9 and/or 18 holes also tracks what will show up on the course.
    /// </summary>
    public static int levelNumber = 0;

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
                numOfSandTraps = 1;
                break;
            case 2:
                numOfSandTraps = 2;
                holelocation = 3;
                break;
            case 3:
                numOfSandTraps = 1;
                numOfWaterFeatures = 1;
                break;
            case 4:
                numOfWaterFeatures = 1;
                break;
            default:
                break;
        }
    }
}