namespace _00_accesss
{

    //הגדרת תבנית שלא תופסת מקום בפועל בזיכרון
    //אלא מאפשרת ליצור ממנה מופעים לפי הגדרתה
    class Car
    {

        //-------------Properties--------------
        private int numOfWheels;

        //------------- Getter + Setter --------------
        public void SetNumOfWheels(int value)
        {
            if(value < 15 && value >= 4)
                numOfWheels = value;
        }


        public int GetNumOfWheels()
        {
           return numOfWheels;
        }



        //-------------Methods--------------
        public string GetDescription()
        {
            return $"Car has {numOfWheels} wheels";
        }
    }

}
