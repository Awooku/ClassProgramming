using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasseProgrammering_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            // memory - stack forandrer sig ikke, non volatile
            // memory - heap colatile => svarer til en tilfældig placering
            // I "User Hans = new User();" er "new" en volatile Heap

            User Hans = new User();
            Hans.MethodA();
            Hans.alder = 5;

            // en måde man kan få fat i ting fra klassen User
            User Ole = new User();
            Ole.MethodB();

            // en anden måde man kan få fat i ting fra klassen User
            User.Hans();

            User ObjectName = new User();
            ObjectName.MethodA();

            
            //Product etProdukt = new Product();
            //int tal = etProdukt.ProductNumber;
           

            List<User> liste = new List<User>()
            {
                new User
                {
                    alder = 6, navn = "Kent"                 
                }
            };

            List<Product> list = new List<Product>()
            {
                new Product
                {
                    productID = 1, productName = "Saw", description = "Cuts things", weight = 2
                },
                new Product
                {
                    productID = 2, productName = "Hammer", description = "Hammers things", weight = 1.8
                }
            };

             

            // (); betyder at du laver en metode
            // (){ string navn = "whatever"; } er en anonym metode, som ikke virker            

            Console.ReadKey();
        }
    }
    // Encapsulations: public, protected, default & private
    // Der findes to ting i klasser: Attributes og methods
    //3 ting hvis du spørger Flemming:
    // Fields
    // Properties
    // Methods
    // name convention: Klassenavnet skal starte med stort
    class User
    {
        public int alder;
        public string navn;

        public void MethodA()
        {
            alder = 29;
            navn = "Hans";
        }
        public void MethodB()
        {
            alder = 49;
            navn = "Ole";
        }

        //  Constructor

        public User() // initialiserer et objekt
        {
            // man plejer at sætte attributes herinde


        }

        public static void Hans()
        {
            Console.WriteLine("ting");
        }

        // destructor

            /*
        public ~User()
        {

        }
            */

        // ?? er om en refrence som er på heapen
    }
}
