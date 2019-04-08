namespace _03_inheritance
{
    class Food
    {

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
