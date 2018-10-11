using System;
namespace SEF_AssIgnment1
{
    public class NonRandomTestBoard
    {
        Random random = new Random();

        public NonRandomTestBoard()
        {

        }

        private void CreateTestBoard()
        {
            Create2DArray();
        }
        private int[,] Create2DArray()
        {
            //This creates the test board. A prebuilt maze for pacman.
            //Monsters starts at (6,7) & (8,7)
            //0,0 is top left.
            int[,] board = new int[,]{

                { 1,4,4,4,4,4,4,4,4,4,4,4,4,4,1},
                { 6,0,0,0,0,0,0,0,0,0,0,0,0,0,7},
                { 6,0,1,1,1,0,1,1,1,0,1,1,1,0,7},
                { 6,0,1,0,0,0,1,1,1,0,0,0,1,0,7},
                { 6,0,1,0,1,0,1,1,1,0,1,0,1,0,7},
                { 6,0,0,0,0,0,0,0,0,0,0,0,0,0,7},
                { 6,0,1,0,0,1,1,0,1,1,0,0,1,0,7},
                { 6,0,1,0,1,1,0,0,0,1,1,0,1,0,7},
                { 6,0,1,0,0,1,1,1,1,1,0,0,1,0,7},
                { 6,0,0,0,0,0,0,0,0,0,0,0,0,0,7},
                { 6,0,1,0,1,0,1,1,1,0,1,0,1,0,7},
                { 6,0,1,0,0,0,1,1,1,0,0,0,1,0,7},
                { 6,0,1,1,1,0,1,1,1,0,1,1,1,0,7},
                { 6,0,0,0,0,0,0,0,0,0,0,0,0,0,7},
                { 1,5,5,5,5,5,5,5,5,5,5,5,5,5,1},

            };

            //This replaces all empty spaces with coins.
            for (int y = 0; y < 14; y++)
            {
                for (int x = 0; x < 14; x++)
                {
                    if (board[x, y] == 0)
                    {
                        board[x, y] = 3;
                    }
                }
            }

            //This will ensure that 7,13 remains open for player to spawn
            //by waiting until all the empty spaces are made coins,
            //and then removing the one coin from the spawn location.
            //This will also clear the monster spawn points, although they
            //cannot pick up coins anyway.
            board[7, 13] = 0; //Player Spawn
            board[6, 7] = 0; //Monster 1
            board[8, 7] = 0; //Monster 2

            //I will generalize spawn points so that it will work to inputable values

            //I will also allow for maze internals to be randomized by iterating
            //over the array, and when I find a zero, I will roll a random number
            //selecting from an empty space, a coin, or a block.

            return board;
        }

        public void FruitOnMap(int[,] board)
        {
            int fruitsOnMapATM = 0;
            int randomFruitChance = 0;

            for (int y = 0; y < 14; y++)
            {
                for (int x = 0; x < 14; x++)
                {
                    if (board[x, y] == 2)
                    {
                        fruitsOnMapATM ++;
                    }

                    if (fruitsOnMapATM<2 && board[x,y] /= 2)
                    {
                        randomFruitChance = random.Next(0, 40);

                        if(randomFruitChance == 16) //1 in 40 chance
                        {
                            board[x, y] = 2;

                            fruitsOnMapATM++;
                        }
                    }
                }
            }
        }
    }
}