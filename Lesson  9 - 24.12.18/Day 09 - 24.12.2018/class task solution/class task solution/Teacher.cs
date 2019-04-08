
namespace class_task_solution
{
    class Teacher : Person
    {
        public new string Print()
        {
            return base.Print() + $"  , YearsOfEx: {YearsOfEx} , TeachSubject: {TeachSubject}";
        }

        public int YearsOfEx { get; set; }
        public string TeachSubject { get; set; }

        public Teacher(bool isMale, string name, int age, string id, int yearsOfEx, string teachSubject) :
            base(isMale, name, age, id)
        {
            YearsOfEx = yearsOfEx;
            TeachSubject = teachSubject;
        }
    }
}
