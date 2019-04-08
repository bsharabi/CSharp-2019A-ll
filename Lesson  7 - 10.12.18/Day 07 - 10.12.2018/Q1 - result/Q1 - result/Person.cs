namespace Q1___result
{
    class Person
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        private Date birthDate;

        public Date BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }


        private Person mam;

        public Person Mam
        {
            get { return mam; }
            set { mam = value; }
        }




        private Person dad;

        public Person Dad
        {
            get { return dad; }
            set { dad = value; }
        }


        public Person(string name, Date birthDate, Person mam, Person dad)
        {
            Name = name;
            BirthDate = birthDate;
            Mam = mam;
            Dad = dad;
        }


        public string GetDescription()
        {
            string res = $"Name: {Name}, BirthDate: {BirthDate.GetDescription()}";

            if(Mam!=null && Dad != null)
            {
                res += $"\n{Mam.GetDescription()}\n{Dad.GetDescription()}";
            }


            return res;
        }

        }
}
