using System;
namespace SEF_AssIgnment1
{
    public class TestCase1
    {
        Random random = new Random();

        int boardHeight = 15;
        int boardWidth = 15;        

        public void TestCase1_AssignRandomValueToTile(int boardWidth)
        {
            int[] tileRow1 = new int[boardWidth];
            foreach (int i in tileRow1)
            {
                tileRow1[i] = randomize();
                foreach (int x in tileRow1)
                {
                    System.Console.Write("{0} ", x);
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

    }
}
