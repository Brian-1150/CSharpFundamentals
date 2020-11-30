using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _08_Interfaces {

    public interface IFruit {           //starts with I because it is an interface
        string Name { get; }           //no "public" because all Interface is public.  get only because fruit names should be constant
        bool Peeled { get; set; }       // prop with get and set
        string Peel();                  //Method with only a return type and no paramaters.
                                        //Interface is called a contract and it this one is agreeing to do "at least" these three things.  It can do more, but MUST do these.
    }

    public class Banana : IFruit {
        public string Name {
            get { return "Banana"; }
        }
        public bool Peeled { get; set; }
        public string Peel() {
            Peeled = true;
            return "You peeled the banana";
        }
    }
    public class Orange : IFruit {
        public string Name {
            get {
                return "Orange";
            }
        }

        public bool Peeled { get; set; }

        public string Peel() {
            Peeled = true;
            return "You peeled the orange";
        }
        public string Squeeze() {
            return "You squeezed the orange";
        }
    }
    public class Grape : IFruit {
        public string Name {
            get { return "Grape"; }
        }
        public bool Peeled { get; set; }   //notice peeled not set to true like the others
        public string Peel() {
            return "Who peels grapes?";
        }
    }




    [TestClass]
    public class IntroductionToInterfaces {
        [TestMethod]
        public void CallingInterfaceMethods() {
            // New up an instance of an Ifruit
            IFruit fruit = new Orange();    //calling just Ifruit props , not banana or orange
                                            // we can change new Banana to Orange or grape and get new output for everything
            string output = fruit.Peel();
            Console.WriteLine(output);

            Console.WriteLine($"The {fruit.Name} is peeled: " + fruit.Peeled);

            var fruits = new Orange();  // but from here I can call orange sqeeze method, because "var" not Ifruit.
            fruits.Squeeze();

        }
        [TestMethod]
        public void InterfacesInCollections() {
            var orange = new Orange();

            var fruitSalad = new List<IFruit>();
            fruitSalad.Add(orange);
            fruitSalad.Add(new Banana());
            fruitSalad.Add(new Grape());

            foreach (var fruit in fruitSalad) {
                Console.WriteLine(fruit.Name);
                Console.WriteLine(fruit.Peel());
            }
            Console.WriteLine(orange.Squeeze());  //this can be called directly because it is only in orange class.  can't be part of the foreach loop

        }
        private string GetFruitName(IFruit fruit) => $"This fruit is called {fruit.Name}"; //style without {} from quiz I did not know about

        [TestMethod]
        public void InterfacesMethods() {
            var grape = new Grape();
            var output = GetFruitName(grape);
            Console.WriteLine(output);
        }
    }
}
