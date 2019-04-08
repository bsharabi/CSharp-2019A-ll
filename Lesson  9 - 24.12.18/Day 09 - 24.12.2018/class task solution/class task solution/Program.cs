using System;


namespace class_task_solution
{
    class Program
    {


        static void InitArr(Person[] personArr)
        {
            for (int i = 0; i < personArr.Length; i++)
            {
                Random rnd = new Random();
                int choice = rnd.Next(0, 3);


                switch (choice)
                {
                    case 0:
                        personArr[i] = new Student(true, "Bob", 20, "123456789", "Ariel", "Computers");
                        break;
                    case 1:
                        personArr[i] = new Teacher(false, "Alice", 25, "111111111", 7, "Math");
                        break;
                    case 2:
                        personArr[i] = new Worker(true, "Tom", 32, "222222222", 15000);
                        break;
                    default:
                        break;
                }
            }
        }


        static void PrintInfo(Person[] personArr, Cinema bestCinema)
        {
            decimal total = 0;
            int studentCount = 0;
            int teacherCount = 0;
            int workerCount = 0;

            foreach (Person p in personArr)
            {
                if (p is Student)
                {
                    studentCount++;
                    total += (int)((bestCinema.Price) * (decimal)(1 - (bestCinema.StudentDiscount / 100.0)));
                }
                else if(p is Teacher)
                {
                    teacherCount++;
                    total += (int)((bestCinema.Price) * (decimal)(1 - (bestCinema.TeacherDiscount / 100.0)));
                }
                else
                {
                    workerCount++;
                    total += bestCinema.Price;
                }
            }


            Console.WriteLine($"Total for this day: {total}");
            Console.WriteLine($"Price per movie: {bestCinema.Price}");
            Console.WriteLine($"Total clients: {personArr.Length}");
            Console.WriteLine($"Total studentCount: {studentCount}");
            Console.WriteLine($"Total teacherCount: {teacherCount}");
            Console.WriteLine($"Total workerCount: {workerCount}");
            Console.WriteLine($"StudentDiscount: {bestCinema.StudentDiscount}");
            Console.WriteLine($"TeacherDiscount: {bestCinema.TeacherDiscount}");
        }


        static void Main(string[] args)
        {


            Cinema myCinema = new Cinema();
            myCinema.Price = 35;
            myCinema.CinemaName = "Avatar";



            Person[] arr = new Person[15];


            InitArr(arr);
            PrintInfo(arr, myCinema);


        }
    }
}
