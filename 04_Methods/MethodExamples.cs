using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _04_Methods {
    [TestClass]
    public class MethodExamples {
        //Input
        //What we do
        //Output




        //1  access modifier - public/private
        //2  return type - void or return
        //3  method signature - name and parameters
        //4  body - code that does something

        public int AddTwoNumbers(int numOne, int numTwo) {//these are parameters
            int sum = numOne + numTwo;
            return sum;
        }

        private int SubtractTwoNumbers(int a, int b) {
            int num = a - b;
            return num;
        }

        private int MultiplyTwoNumbers(int x, int z) {
            int prod = x * z;
            return prod;
        }

        private int DivideTwoNumbers(int apricot, int cherry) {
            int fruitSalad = apricot / cherry;
            return fruitSalad;
        }

        private int FindRemainder(int a, int numTwo) {
            int remainder = a % numTwo;
            return remainder;
        }

        [TestMethod]
        public void MethodTests() {
         int banana =   AddTwoNumbers(7, 12);//these are arguments
            int sum = AddTwoNumbers(5, 42);
            Console.Write(sum);

            Assert.AreEqual(19, banana); //a way to test that code does what we want
        }
    }
}
