using System;
using System.Collections.Generic;

namespace PracticeAssessment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventory Store = new Inventory();

            Console.WriteLine(Store.Jeans);

            Console.WriteLine(Store.Cords);


            //This is how I can access private properties with the GetStyle method!
            Console.WriteLine(Store.Jeans.GetStyle());

            Console.WriteLine(Store.Cords.IsAvailable(8));
        }
    }
}
