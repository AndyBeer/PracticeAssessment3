using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeAssessment3
{
    class Inventory
    {
        public List<Pants> stock = new List<Pants>();
        public Pants Chinos = new Pants("Chinos", "1,2,3,4,5");
        public Pants Jeans = new Pants("Jeans", "1,2,3,4,5");
        public Pants Cords = new Pants("Corderoy", "4,5,6,7,8");
        public Pants Sweats = new Pants("Sweatpants", "10,12,14,16,18");
        public Pants Shorts = new Pants("Shorts", "1,2,3,4");

        public Inventory()
        { 
            stock.Add(Chinos);
            stock.Add(Jeans); 
            stock.Add(Cords); 
            stock.Add(Sweats); 
            stock.Add(Shorts);

        }






    }
}
