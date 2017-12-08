using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasseProgrammering_2._0
{
    class Product
    {
        public int productID; // attribute
        public string productName { get; set; }
        public string description { get; set; }        
        public double weight { get; set; }
        
        
        // get & set er metoder

        string barcode;        

        public string getBarcode()
        {
            return barcode;
        }

        bool SunEqualsYellow = true;
        public void setBarcode(string s)
        {
            if (SunEqualsYellow == true)
            {
                barcode = s;
            }
        }

        public int MyProperty
        {
            get
            {
                if (true)
                {

                }
                for (int i = 0; i < 12; i++)
                {

                }
                foreach (var item in new List<string>())
                {

                }
                return 12;
            }
            set
            {

            }
        }

        /*
          
        Eksempel på metoder istedet for properties

                --PROPERTY--

        public int MyProperty { get; set; }

                --METODE--

        private int myProperty;

        public int GetMyProperty()
        {
            return myProperty;
        }

        public void SetMyProperty(int value)
        {
            myProperty = value;
        }

                I propertien og i metoden står der essentielt det samme.

        */

    }
}
