
namespace Q2___result
{
    class Movie
    {
        private int length;

        public int Length
        {
            get { return length; }
            set
            {
                if (value > 0)
                {
                    length = value;
                }
            }
        }


        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }



        public Movie(int length, string name)
        {
            Length = length;
            Name = name;
        }


        public string GetDescription()
        {
            return $"Movie Name: {Name}, Movie Length: {Length}";
        }

    }
}
