using System;

namespace _01_constructor_with_parameters
{
    class Book
    {

        //--------------Proeries---------------
        private int pageCount;

        public int PageCount
        {
            get { return pageCount; }
            set { pageCount = value; }
        }


        private string bookName;

        public string BookName
        {
            get { return bookName; }
            set { bookName = value; }
        }



        //-------------Constructor----------------
        //new יצירת בנאי שמקבל פרמטרים בקריאה אליו - כלומר ב
        //ומבצע השמה של הערכים האלו לתוך משתני האובייקט שנוצר
        public Book(int pageCount, string bookName)
        {
            PageCount = pageCount;
            BookName = bookName;
        }



        //new יצירת בנאי שלא מקבל פרמטרים בקריאה אליו - כלומר ב
        //כאשר יוצרים בנאי שמקבל פרמטרים 
        //- נדרס הבאי הדיפולטיבי שמוגדר שלא דורש פרמטרים
        //ולכן אם נרצה ליצור משתנה בלי העברת פרמטרים לבנאי
        //חובה להגדיר מחדש בנאי שלא מקבל פרמטרים
        public Book() {}


    

        //--------------Methods---------------
        public void PrintInfo()
        {
            Console.WriteLine($"Book {BookName} has {PageCount} pages");
        }
    }
}
