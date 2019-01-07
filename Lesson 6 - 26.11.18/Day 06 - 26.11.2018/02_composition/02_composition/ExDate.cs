namespace _02_composition
{
    class ExDate
    {
        private int day;

        public int Day
        {
            get { return day; }
            set { day = value; }
        }


        private int month;

        public int Month
        {
            get { return month; }
            set { month = value; }
        }


        private int year;

        public int Year
        {
            get { return year; }
            set { year = value; }
        }


        public ExDate(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;

        }


       
    }
}
