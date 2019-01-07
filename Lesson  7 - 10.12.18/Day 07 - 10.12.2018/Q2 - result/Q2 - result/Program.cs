using System;

namespace Q2___result
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Movie movie1 = new Movie(150,"Avatar");
            Movie movie2 = new Movie(140, "Alice");

            CinemaRoom room1 = new CinemaRoom(movie1);
            CinemaRoom room2 = new CinemaRoom(movie2);


            Cinema myCinema = new Cinema();

            myCinema.RoomsArr[0] = room1;
            myCinema.RoomsArr[1] = room2;

            myCinema.BuyTicket("Avatar", 4);
            myCinema.BuyTicket("Alice", 6);


            Console.WriteLine(myCinema.GetDescription());
        }
    }
}
