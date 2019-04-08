namespace class_task_solution
{
    class Student : Person
    {
        public new string Print()
        {
            return base.Print() + $"  , SchoolName: {SchoolName} , StudySubject: {StudySubject}";
        }

        public string SchoolName { get; set; }
        public string StudySubject { get; set; }

        public Student(bool isMale, string name, int age, string id, string schoolName , string studySubject) :
            base(isMale, name, age, id)
        {
            SchoolName = schoolName;
            StudySubject = studySubject;
        }
    }
}
