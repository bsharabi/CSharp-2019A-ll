
namespace Q2___result
{
    class Cinema
    {
        private Movie[] moviesArr;

        public Movie[] MoviesArr
        {
            get { return moviesArr; }
            set { moviesArr = value; }
        }


        private CinemaRoom[] roomsArr;

        public CinemaRoom[] RoomsArr
        {
            get { return roomsArr; }
            set { roomsArr = value; }
        }



        public Cinema()
        {
            MoviesArr = new Movie[100];
            RoomsArr = new CinemaRoom[6];
        }

        public bool BuyTicket(string movieName, int amount)
        {
            bool res = false;

            for (int i = 0; i < RoomsArr.Length; i++)
            {
                if (RoomsArr[i]!=null && RoomsArr[i].MyMovie.Name == movieName)
                {
                    res = RoomsArr[i].BuyChairs(amount);
                }
            }

            return res;
        }

        public string GetDescription()
        {
            string res = "";


            for (int i = 0; i < RoomsArr.Length; i++)
            {
                if (RoomsArr[i] != null)
                {
                    res += $"\n------------------ROOM {i}----------------\n";
                    res += RoomsArr[i].GetDescription();
                }
            }

            return res;

        }
    }

   
}
