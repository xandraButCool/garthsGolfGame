public class Levels
{
    /// <summary>
    /// Tracks what hole you are on. For the first 9 and/or 18 holes also tracks what will show up on the course.
    /// </summary>
    public static int levelNumber = 1;

    /// <summary>
    /// Wont be used unless I add an endless mode. Determains the number of obstacles on the course
    /// </summary>
    public static int levelDifficulty = 0;
    
    /// <summary>
    /// Increases the level number and sets the number and types of obstacles.
    /// </summary>
    public static void LevelIncrease()
    {
        levelNumber++;
        switch (levelNumber)
        {
            default:
                break;
        }
    }
}