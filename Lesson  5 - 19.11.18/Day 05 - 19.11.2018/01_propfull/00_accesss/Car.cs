namespace _00_accesss
{
    class Car
    {

        //-------------Properties--------------

        private int numOfWheels;

        public int NumOfWheels
        {
            //---- Getter + Setter ----
            get { return numOfWheels; }
            set {
                if(value<15 && value >=4)
                numOfWheels = value;
            }
        }
        

        //-------------Methods--------------
        public string GetDescription()
        {
            return $"Car has {numOfWheels} wheels";
        }
    }

}
