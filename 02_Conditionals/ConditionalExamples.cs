using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _02_Conditionals {
    [TestClass]
    public class UnitTest1 {
        [TestMethod]
        public void Booleans() {
            bool isTrue = 17 > 5;
            bool isFalse = 17 == 4;
}

        [TestMethod]
        public void IfElseStatements() {
            bool isTrue = true;
            if(isTrue) {
                //Do something
            }
            int age = 24;
            if (age > 17) {
                Console.WriteLine("You are an adult!");
            }
            else if (age > 7){
                Console.WriteLine("you are a child");
            }
            else {
                Console.WriteLine("you are a baby");
            }

            if (age > 65 && age < 18) {
                //And comparison
            }
            if (age == 17) {
                //Is equal to
            }
            if (age != 19) {
                // not equal to
            }
        }
        [TestMethod]
        public void SwitchCases() {
            int age = 42;
            switch (age) {
                case 18:
                    //code for 18
                    break;
                case 19:
                    //code for 19
                    break;
                case 20:
                    //code for 20
                    break;
                case 21:
                case 22:
                case 23:
                    //code for 21 - 23
                    break;
                default:
                    // catch all code
                    break;
            }
        }
        
        [TestMethod]
        public void Ternaries() {
            int age = 37;

            // bool someVariable = (boolean statement)? trueValue; falsValue;

            bool isAge = (age == 24) ? true: false;
        }
    }
}
