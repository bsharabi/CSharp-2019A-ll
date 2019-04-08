namespace class_task_solution
{
    class Worker : Person
    {
        public new string Print()
        {
            return base.Print()+$"  , Salary: {Salary}";
        }

        private decimal salary;

        public decimal Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public Worker(bool isMale, string name, int age, string id, decimal salary) : 
            base(isMale, name, age, id)
        {
            Salary = salary;
        }
    }
}
