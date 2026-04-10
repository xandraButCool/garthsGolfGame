The game uses commands in the command line as the input. all commands have to be `nameOfCommand,value` with the value being an integer. anything else will just crash the project right now.

list of commands:
move
    moves same number of tiles as the value input in the direction that the playe is facing
swing
    swings with power equal to the input value. usualy moves the ball a simmilar distance to the input value.
club
    changes what club is equiped to the slot coresponding to the input value
turn
    changes the player to be facing in the direction coresponding to the number input. 0 = north, 1 = north east, 2 = east, 3 = south east, 4 = south, ... , 7 = north west.
beatLevel
    beats the level if you know the correct number to put into the value