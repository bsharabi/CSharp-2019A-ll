
namespace VarTypes
{
    class Program
    {
        static void Main(string[] args)
        {

            //****************val type********************


            //----------numeric (מספרים שלמים)---------

            // 1 byte - from 0 to 255
            byte b = 12;

            // 1 byte - from -128 to 127 
            sbyte sb = 12;

            // 4 byte
            int i = 12;

            // 4 byte - רק מספרים חיוביים
            uint u = 12;

            // 8 byte
            long l = 12;

            // 8 byte - רק מספרים חיוביים
            ulong ul = 12;




            //----------numeric (מספרים עשרוניים)--------
            double db = 12.4;
            float f = 2.44f;
            decimal dm= 3.55m;


            //----------תווים-----------------------------
            // 2 byte
            char ch = 'a';


            //----------בוליאני---------------------------
            //can contain only `true` or `false`
            bool bl = true;

            //****************ref type********************
            string s = "Hello";

        }
    }
}
