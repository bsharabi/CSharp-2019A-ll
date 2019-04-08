namespace class_task_solution
{
    class Person
    {
        public string Print()
        {
            return $" IsMale : {IsMale }= isMale, Name:{Name},Age: {Age}, Id: {Id}";
        }

        public Person(bool isMale, string name, int age, string id)
        {
            IsMale = isMale;
            Name = name;
            Age = age;
            Id = id;

        }


        public bool IsMale { get; set; }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        private int age;

        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 0 && value <= 120)
                {
                    age = value;
                }
            }
        }


        private string id;

        public string Id
        {
            get { return id; }
            set {
                int num;
                if (value.Length==9 && int.TryParse(value, out num))
                {
                    id = value;
                }
            }
        }


    }
}
