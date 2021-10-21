using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PracticeAssessment3
{
    class Pants
    {
        private string Style { get; set; }
        private List<int> SizeList => GetSizes(Sizes);
        private string Sizes { get; set; }


        public Pants(string Style, string Sizes)
        {
            this.Style = Style;
            this.Sizes = Sizes;

        }
        public override string ToString()
        {
            //return base.ToString();
            string sizes = "";
            foreach (int s in SizeList)
            {
                sizes += Convert.ToString(s) + " ";
            }
            string output = $"Style: {Style}, Sizes: {sizes}";
            return output;
        }

        public List<int> GetSizes(string sizes)
        {
            List<int> sizeInt = new List<int>();
            List<string> sizeString = sizes.Split(',').ToList();
            foreach (string s in sizeString)
            {
                int sInt = int.Parse(s);
                sizeInt.Add(sInt);
            }
            return sizeInt;
        }
        public string GetStyle()
        {
            string style = Style;
            return style;
        }
        public bool IsAvailable(int size)
        {
            foreach (int i in SizeList)
            {
                if (i != size)
                {
                    continue;
                }
                else 
                {
                    return true;    
                }
            }
            return false;
        }
    }
    
}
        
      
        

