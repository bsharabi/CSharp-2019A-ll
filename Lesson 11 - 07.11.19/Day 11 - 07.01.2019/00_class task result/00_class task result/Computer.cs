namespace _00_class_task_result
{
    class Computer:Electronic
    {
        //----------------METHODES----------------------
        public override string GetInfo()
        {
            return  $"{base.GetInfo()}, IsLaptop:{IsLaptop}";
        }

        //----------------PROPS----------------------
        public bool IsLaptop { get; set; }
    }
}
