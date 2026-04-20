using System.Globalization;

class InputCommands
{
    static char[,] helpInfo = new char[22,2];
    
    public static void GetInput()
    {
        string? playerInput = Console.ReadLine();
        string playerCommand = "input null.";
        int commandValue = 0;
        
        if (playerInput == null)
        {
            return;
        } else
        {
            if (int.TryParse(playerInput.Split(',')[1], out commandValue))
                playerCommand = playerInput.Split(',')[0];
            else
                playerCommand = "input format wrong";
        }
        switch (playerCommand)
        {
            case "move":
                Console.WriteLine($"you move {commandValue} units.");
                Move(commandValue);
                break;
            case "swing":
                Console.WriteLine($"you swing {commandValue} units.");
                Swing(commandValue);
                break;
            case "club":
                Console.WriteLine($"you switch to club {commandValue}.");
                ChangeClub(commandValue);
                break;
            case "beatLevel":
                BeatLevel(commandValue);
                break;
            case "turn":
                Console.WriteLine($"you are now facing {commandValue}");
                PlayerFaceing(commandValue);
                break;
            case "input null.":
                DisplayHandler.DrawFrame();
                Console.WriteLine("No command entered.");
                break;
            case "input format wrong":
            default:
                DisplayHandler.DrawFrame();
                Console.WriteLine("Not a valid command.");
                break;
        }

    }
    
    static void BeatLevel(int key)
    {
        if (key == 99)
        {
            Game.levelCompletted = true;
        }
        else
        {
            DisplayHandler.DrawFrame();
            Console.WriteLine("you dont know the key, na na na na bo bo.");
        }
    }
    static void Move(int moveDistance)
    {
        EntityMap.entityGrid[Game.playerX,Game.playerY] = new EntityBlank();
        TileTools.SetTileAdjecentDir(Game.playerX,Game.playerY,5);
        int tempX = TileTools.tileX;
        int tempY = TileTools.tileY; 
        
        for (int n = moveDistance; n > 0; n--)
        {
            TileTools.SetTileAdjecentDir(tempX,tempY,Game.facing);
            if (!TileTools.validLocation)
            {
                TileTools.SetTileAdjecentDir(tempX,tempY,5);
                EntityMap.entityGrid[tempX,tempY] = new EntityPlayer();
                return;
            } else
            {
                tempX = TileTools.tileX;
                tempY = TileTools.tileY; 
            }
        }

        Game.playerX = TileTools.tileX;
        Game.playerY = TileTools.tileY;
        EntityMap.entityGrid[Game.playerX,Game.playerY] = new EntityPlayer();
    }

    static void PlayerFaceing(int facingDirection)
    {
        Game.facing = facingDirection;
    }

    static void Swing(int swingPower)
    {
        TileTools.SetTileAdjecentDir(Game.ballX,Game.ballY,Game.facing);
        if (TileTools.tileX == Game.ballX && TileTools.tileY == Game.ballY)
        {
            EntityMap.entityGrid[Game.ballX,Game.ballY] = new EntityBlank();
            TileTools.SetTileAdjecentDir(Game.ballX,Game.ballY,5);
            int tempX = TileTools.tileX;
            int tempY = TileTools.tileY;
            
            for (int n=swingPower; n>1; n--)
            {
                TileTools.SetTileAdjecentDir(tempX,tempY,Game.facing);
                if (!TileTools.validLocation)
                {
                    TileTools.SetTileAdjecentDir(tempX,tempY,5);
                    EntityMap.entityGrid[tempX,tempY] = new EntityPlayer();
                    return;
                } else
                {
                    tempX = TileTools.tileX;
                    tempY = TileTools.tileY; 
                }
            }

            Game.ballX = TileTools.tileX;
            Game.ballY = TileTools.tileY;
            EntityMap.entityGrid[Game.ballX,Game.ballY] = new EntityBall();
        }
    }

    static void ChangeClub(int clubNumber)
    {
        
    }
}