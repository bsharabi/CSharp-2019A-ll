namespace Q2___result
{
    class CinemaRoom
    {

        private bool[][] chairMatrix;

        public bool[][] ChairMatrix
        {
            get { return chairMatrix; }
            set { chairMatrix = value; }
        }

        private Movie myMovie;

        public Movie MyMovie
        {
            get { return myMovie; }
            set { myMovie = value; }
        }


        public CinemaRoom(Movie myMovie)
        {
            //here all the elements in the matrix contains the default bool value - false
            ChairMatrix = new bool[10][];

            for (int row = 0; row < ChairMatrix.Length; row++)
            {
                ChairMatrix[row] = new bool[8];
            }


            MyMovie = myMovie;

        }


        public bool BuyChairs(int amount)
        {
            for (int row = 0; row < ChairMatrix.Length; row++)
            {
                for (int col = 0; col < ChairMatrix[row].Length; col++)
                {
                    if (!ChairMatrix[row][col])
                    {
                        amount--;
                        ChairMatrix[row][col] = true;

                        if (amount == 0)
                        {
                            break;
                        }
                    }
                }

                if (amount == 0)
                {
                    break;
                }

            }

            return amount == 0;
        }


        public string GetDescription()
        {
            string res = $"Movie in this room\n{MyMovie.GetDescription()}";
            res += "\n\nThe ChairMatrix in the room (V= orderded, X = not ordered)\n";

            foreach (bool[] arr in ChairMatrix)
            {
                foreach (bool element in arr)
                {
                    res += (element) ? " V | " : " X | ";
                }
                res += "\n---------------------------------------------\n";
            }

            return res;
        }

    }
}
