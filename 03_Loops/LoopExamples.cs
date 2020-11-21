using System;
using System.Globalization;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _03_Loops {
    [TestClass]
    public class LoopExamples {
        [TestMethod]
        public void ForLoops() {

            int studentCount = 15;
            //1  Starting point
            //2  Condition that while true, keeps the loop running
            //3  What happens after each loop
            //4  Body of the loop, what happens each iteration
            //for  //1       //2             //3
            for (int i = 0; i < studentCount; i++) {
                //4 body of loop
                Console.WriteLine(i);
            }
        }
        [TestMethod]
        public void ForEachLoops() {
            string name = "Eleven Fifty Academy";
            //1  Collection that is being worked on
            //2  name of the current iteration being used
            //3  Current Type in the collection
            //4  in keyword, used to seperate the individual and the collection
            //5 Body of the loop
            //foreach //3  //2  //4  //1

            int j = 0;//I added the j and the second for loop to make it print in a pattern
            foreach (char letter in name) {  //5
                j++;
                Console.WriteLine(letter);
                for (int i = 0; i < j; i++) {
                    Console.Write(" ");
                }
            }
        }
        [TestMethod]
        public void WhileLoops() {
            int total = 1;

            //1  Loop runs while the condition is true
            //2  the body of the loop

            //while    //1
            while (total != 30) {
                Console.WriteLine(total);
                total++;
            }

        }
    }
    }

