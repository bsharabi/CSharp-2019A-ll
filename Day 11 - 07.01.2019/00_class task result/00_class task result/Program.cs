using System;


namespace _00_class_task_result
{
    class Program
    {
        static void Main(string[] args)
        {


            ElectricShop myShop = new ElectricShop();
            myShop.Stock = new Electronic[]
            {

  
                new Computer() {
                    IsLaptop=true,
                    Price=3000,
                    MinutesToFullCharge=100,
                    Vat=1000,
                    Years=4
                },
                new Computer(){
                    IsLaptop=true,
                    Price=3000,
                    MinutesToFullCharge=100,
                    Vat=1000,
                    Years=4
                },
                new Computer(){
                    IsLaptop=true,
                    Price=3000,
                    MinutesToFullCharge=100,
                    Vat=1000,
                    Years=4
                },
                new Mobile(){
                    IsSmartphone=true,
                    PhoneNumber="0544885581",
                    Price=3000,
                    MinutesToFullCharge=100,
                    Vat=1000,
                    Years=4
                },
                new Mobile(){
                    IsSmartphone=true,
                    PhoneNumber="0544885581",
                    Price=3000,
                    MinutesToFullCharge=100,
                    Vat=1000,
                    Years=4
                },
                new Mobile(){
                    IsSmartphone=true,
                    PhoneNumber="0544885581",
                    Price=3000,
                    MinutesToFullCharge=100,
                    Vat=1000,
                    Years=4
                },
            };


            myShop.Stock[0].EndChargeEvent += (min) =>
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"you charged me: {min}");
            };

            myShop.Stock[1].EndChargeEvent += (min) =>
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"you charged me: {min}");
            };

            myShop.Stock[4].EndChargeEvent += (min) =>
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"you charged me: {min}");
            };

            myShop.Stock[5].EndChargeEvent += (min) =>
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"you charged me: {min}");
            };

          


            myShop.GetInfo(1);
            myShop.Shop(1);
            myShop.Stock[1].StartCharge(100);



            myShop.GetInfo(2);
            myShop.Shop(4);

            (myShop.Stock[4] as Mobile).SendSms(4, "0544885522");

            (myShop.Stock[4] as Mobile).SendSms(true, "0544885522");

            (myShop.Stock[4] as Mobile).SendSms("How are you", "0544885522");

            myShop.Stock[4].StartCharge(100);
        }
    }
}
