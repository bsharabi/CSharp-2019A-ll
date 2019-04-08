
using System;

namespace class_task_solution
{
    class Cinema
    {
        public string CinemaName { get; set; }

        private decimal price;

        public decimal Price
        {
            get { return price; }
            set
            {

                if (value >= 30 && value <= 200)
                {
                    price = value;
                }

            }
        }

        public readonly int StudentDiscount;
        public readonly int TeacherDiscount;


        public Cinema()
        {
            Random rnd = new Random();
            StudentDiscount = rnd.Next(10, 21);
            TeacherDiscount = rnd.Next(5, 11);
        }
    }
}
