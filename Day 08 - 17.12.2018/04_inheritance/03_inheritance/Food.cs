namespace _03_inheritance
{
    class Food
    {


        public Food(decimal price, bool isVeg)
        {
            Price = price;
            IsVeg = isVeg;
        }

        //propfull
        private decimal price;

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        //prop
        public bool IsVeg { get; set; }

    }
}
