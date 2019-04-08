
namespace _03_inheritance
{
    class Pizza:Food
    {
        private int numOfSlices;

        public Pizza(decimal price, bool isVeg, int numOfSlices) : base(price, isVeg)
        {
            NumOfSlices = numOfSlices;
        }

        public int NumOfSlices
        {
            get { return numOfSlices; }
            set { numOfSlices = value; }
        }

    }
}
