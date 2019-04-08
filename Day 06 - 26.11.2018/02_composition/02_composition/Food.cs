namespace _02_composition
{
    class Food
    {
        private string foodName;

        public string FoodName
        {
            get { return foodName; }
            set { foodName = value; }
        }


        private ExDate lastDate;

        public ExDate LastDate
        {
            get { return lastDate; }
            set { lastDate = value; }
        }


       public void PrintInfo()
        {
            string dateFormat = $"{ LastDate.Day }/{ LastDate.Month}/{ LastDate.Year}";
            System.Console.WriteLine($"use {FoodName} before {dateFormat}");
        }


    }
}
