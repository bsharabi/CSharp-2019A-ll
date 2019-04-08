

namespace _00_class_task_result
{
    class ElectricShop
    {


        //----------------METHODES----------------------
        public void GetInfo(int choice)
        {
            System.Console.ForegroundColor = System.ConsoleColor.White;
            for (int i = 0; i < Stock.Length; i++)
            {
                
                if (choice == 1 && Stock[i] is Computer)
                {
                    System.Console.WriteLine($"Item number {i}");
                    System.Console.WriteLine(Stock[i].GetInfo());
                }

                else if (choice == 2 && Stock[i] is Mobile)
                {
                    System.Console.WriteLine($"Item number {i}");
                    System.Console.WriteLine(Stock[i].GetInfo());
                }
            }

            
        }


        public string Shop(int choice)
        {
            return $"You just bought: {Stock[choice].GetInfo()}";
        }

        //----------------PROPS----------------------
        public Electronic[] Stock { get; set; }

    }
}
