namespace _02_composition
{
    class Program
    {
        static void Main(string[] args)
        {
            Food sushi = new Food();

            sushi.FoodName = "Sushi";
            sushi.LastDate = new ExDate(15, 12, 2018);

            sushi.PrintInfo();
        }
    }
}
