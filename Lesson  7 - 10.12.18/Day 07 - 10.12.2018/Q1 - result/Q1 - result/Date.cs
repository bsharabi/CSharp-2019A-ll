
namespace Q1___result
{
    class Date
    {
        private int year;

        public int Year
        {
            get { return year; }
            set { year = value; }
        }


        private int month;

        public int Month
        {
            get { return month; }
            set
            {
                if (value > 0 && value <= 12)
                {
                    month = value;
                }
            }
        }


        private int day;

        public int Day
        {
            get { return day; }
            set
            {
                if (value > 0 && value <= 31)
                {
                    day = value;
                }
            }
        }


        public Date(int year, int month, int day)
        {
            Year = year;
            Month = month;
            Day = day;
        }


        public string GetDescription()
        {
            return $"{Day}/{Month}/{Year}";
        }


    }
}
