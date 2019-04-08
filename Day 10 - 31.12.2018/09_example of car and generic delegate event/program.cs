using System;

namespace carTest
{

    class Car
    {
        private int gasCounter;
        public event Action<double, int, int> HandleGas;
        public int GasPerKm { get; set; }


        public Car(int gasPerKm)
        {
            GasPerKm = gasPerKm;
        }

        public void AddGas(int amount)
        {
            if (amount > 0)
                gasCounter += amount;
        }


        public void StartDrive(double km)
        {

            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine($"Starting to drive: {km} km, gasCounter: {gasCounter}");

            HandleGas?.Invoke(km, gasCounter, GasPerKm);

            gasCounter-= (int)(km * GasPerKm);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car(5);

            car1.AddGas(180);

            car1.HandleGas += (km, amount, gasPerKm) =>
            {
                if (km * gasPerKm > amount)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Car 1 - You dont have gas!!!");
                }
            };


            car1.StartDrive(20);

            car1.StartDrive(80);



            Car car2 = new Car(3);

            car2.AddGas(10);

            car2.HandleGas += (km, amount, gasPerKm) =>
            {
                if (km * gasPerKm > amount)
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Car 2 - You dont have gas!!!");
                }
            };


            car2.StartDrive(20);
            
        }
    }
}
