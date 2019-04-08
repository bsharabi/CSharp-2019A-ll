
namespace _00_static
{
    class Student
    {
        private int grade;

        public int Grade
        {
            get { return grade; }
            set
            {
                if (value >= 0 && value <= 100)
                {

                    //here we sub from the total grades the current grade
                    sumGrade -= grade;

                    //set the grade to the new grade
                    grade = value;

                    //here we add to the total grades the new grade
                    sumGrade += grade;
                }
            }
        }


        private static int sumGrade=0;
        private static int counter=0;

        public Student(int grade)
        {
            Grade = grade;
            counter++;
        }


        public static string GetTotalGrade()
        {
            return $"The avg grade of the {counter} students is: {sumGrade/counter}";
        }
    }
}
