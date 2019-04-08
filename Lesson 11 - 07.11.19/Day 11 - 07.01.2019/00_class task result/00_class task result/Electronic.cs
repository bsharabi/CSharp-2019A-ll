using System;

namespace _00_class_task_result
{
    class Electronic
    {

        //----------------EVENTS----------------------
        public event Action<int> EndChargeEvent;

        //----------------METHODES----------------------
        public virtual string GetInfo()
        {
            return $"Price: {Price}, Years: {Years} , MinutesToFullCharge: {MinutesToFullCharge}, Vat: {Vat}";
        }


        public void StartCharge(int minutesToCharge)
        {
            if (minutesToCharge >= MinutesToFullCharge)
            {
                EndChargeEvent?.Invoke(minutesToCharge);
            }
        }

        //----------------PROPS----------------------
        private int minutesToFullCharge;

        public int MinutesToFullCharge
        {
            get { return minutesToFullCharge; }
            set
            {
                if (value >= 0)
                {
                    minutesToFullCharge = value;
                }
            }
        }



        private int vat;

        public int Vat
        {
            get { return vat; }
            set
            {
                if (value > 0 && value % 100 == 0)
                {
                    vat = value;
                }
            }
        }

        private int years;

        public int Years
        {
            get { return years; }
            set
            {
                if (value > 0 && value <= 10)
                {
                    years = value;
                }
            }
        }

        private decimal price;

        public decimal Price
        {
            get { return price; }
            set
            {
                if (value > 0)
                {
                    price = value;
                }
            }
        }

    }
}
