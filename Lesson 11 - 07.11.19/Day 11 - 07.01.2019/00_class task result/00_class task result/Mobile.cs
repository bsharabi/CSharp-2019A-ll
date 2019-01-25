
namespace _00_class_task_result
{
    class Mobile:Electronic
    {
        //----------------METHODES----------------------
        public override string GetInfo()
        {
            return $"{base.GetInfo()}, isSmartphone:{isSmartphone}, PhoneNumber: {PhoneNumber}";
        }


        public string SendSms<T>(T msg, string number)
        {
            return $"phone number: {PhoneNumber}, sent: {msg} to: {number}";
        }

        //----------------PROPS----------------------
        private bool isSmartphone;

        public bool IsSmartphone
        {
            get { return isSmartphone; }
            set { isSmartphone = value; }
        }


        private string phoneNumber;

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set {
                int num;

                if (value.Length == 10 && int.TryParse(value, out num))
                {
                    phoneNumber = value;
                }
            }
        }



    }
}
