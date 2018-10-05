using System;
namespace Application
{
    // Work completed by O Fitzgerald-Leonard, s3670970
    public class Board
    {
        /*Default Values
        int unitSize = 10;
        int boardHeight = 15;
        int boardWidth = 15;
        int counter;
        int unitSpeed = 10;*/

        private void CreateBoard(int boardWidth, int boardHeight)
        {
            for (int counter = 0; counter < boardHeight; counter++)
            {
                CreateRowArray(counter, boardWidth, boardHeight);
            }


        }
        private void CreateRowArray(int rowNumArray, int boardWidth, int boardHeight) //Doesn't work
        {
            int[] rowNumArray[] = new int[boardWidth];
            int arrayPlace = 0;

            //This will make the top and bottom row closed
            if (rowNumArray[0] = 0 || rowNumArray[] = boardHeight-1)
            {
                while ((arrayPlace +1) < (boardWidth))
                {
                    rowNumArray[0] = 0;
                    rowNumArray[boardWidth - 1] = 0;
                    rowNumArray[arrayPlace+1] = 4;
                    arrayPlace++;
                }
            }
            //This dictates that with the 2nd and 2nd last rows the first block is closed, and 
            //the remaining blocks are tele1 or tele2
            else if (rowNumArray[] = 1 || rowNumArray = (boardHeight-2))
            {
                rowNumArray[0] = 1;
                rowNumArray[1] = 4;
                rowNumArray[boardWidth - 2] = 5;
                rowNumArray[boardWidth - 1] = 1;

                while (arrayPlace + 2 < (boardWidth) && (arrayPlace + 2) < (boardWidth))
                {
                    rowNumArray[arrayPlace] = 4;
                    arrayPlace++;
                }
            }


        }
        private int randomize()
        {
            //Here I am seting up the percentages for the random tile function.
            //This function will be called as the loop above iterates across the
            //length of the row array.

            //The options will be open block (20%), obstruction (40%), & coin (40%).
            //Fruit will be called later.
            int[] randomTileOption = new int[10];

            randomTileOption[0] = 0;
            randomTileOption[1] = 1;
            randomTileOption[2] = 3;
            randomTileOption[3] = 1;
            randomTileOption[4] = 3;
            randomTileOption[5] = 1;
            randomTileOption[6] = 3;
            randomTileOption[7] = 1;
            randomTileOption[8] = 3;
            randomTileOption[9] = 0;

            int randomTile = randomTileOption[randomRoll()];

            return randomTile;
        }

        private int randomRoll()
        {
            //Here I will simulate a roll to emulate a more random approach.
            //There will be 5 rolls, with an equal chance of rolling 0, 1, or 2.

            Random random = new Random();

            int totalRoll = 0;
            int rollTimes = 1;

            while (rollTimes < 6) /*iterate 5 times*/
            {

                int diceRoll = random.Next(0, 3);
                totalRoll = totalRoll + diceRoll;
                rollTimes++;
            }

            return totalRoll;
        }

        public void createFruit()
        {
            //When called, this will place a fruit on the board via checking the
            //board to see if there are any fruit present, then, if there is 
            //less than 2 present, place a fruit on the designated tile.

            if ()
            {
                
            }
        }

        public void steppedOnFruit()
        {
            //Here is the trigger for when you pick up the fruit.
        }

        public void PlaceFruit()
        {
            //Here the player places the fruit on the tile he is standing on.
            //After 2 units of time, it turns from red (inactive) to black (active)

        }

        public int FruitSlow(int unitSpeed)
        {
            //This effect is called when a player or monster steps on a black tile. 
            //This halves their movement speed for 20 units of time. 
            //Multiple instances of this effect can affect the same unit, however the
            //time allotment for this effect is independant of other effects on the unit.

            unitSpeed = unitSpeed / 2;

            return unitSpeed;


        }

}


    /* BOARD RULES
     *  Create Array per row, values are as follows:
     *      0: Empty. No obstruction, fruit, coin or teleporter
     *      1: Obstruction. Fills block. No player/monster/fruit/coin/tele can exist here.
     *      2: Fruit: "Item". Picked up by stepping on it.
     *      3. Coin: When block is stepped on by player, score goes +1, block turns 0.
     *      4. TeleTop: Top Tele unit.
     *      5. TeleBot: Bottom Tele unit.
     *      6. TeleLeft: Tele left unit.
     *      7. TeleRight: Tele right unit.
     *      8. Debuff - Inactive: Warning that it will activate soon.
     *      9. Debuff - Active: Slows member (Player or OpFor) who enters for 20 secs. Stackable.
     * 
     * Initial Test Case:
     *      Create test Board array. - Pass
     *  
     *      Change empty spaces into coins, and clear spots for monster spawns. - Pass
     * 
     *      Create a XxY board, size determined by user, that randomises itself, between options of
     *      Open, Close, & Coin.
     *      
     *      Randomize an array value, using roll mechanic. - Pass
     * 
     */