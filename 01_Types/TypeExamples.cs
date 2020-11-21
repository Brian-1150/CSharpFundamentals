using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_Types {
    [TestClass]
    public class TypeExamples {
        [TestMethod]
        public void ValueTypes() {
            //  Whole Numbers
            byte oneBytesWorth = 225;
            short smallWholeNumber = 16;
            Int16 anotherSmallNumber = 16;
            int wholeNumber = 32;
            long largeWholeNumber = 64;

            // Decimals
            float floatexample = 1.234567f; //f is needed
            double doubleExample = 1.237d; // d is not needed
            decimal decimalExample = 1.7000m;  // m is needed

            //character

            char letter = 'j';

            //Operators
            int numOne = 17;
            int numTwo = 5;
            int sum = numOne + numTwo;
            Console.WriteLine(sum);
            int diff = numOne - numTwo;
            Console.WriteLine(diff);
            int prod = numOne * numTwo;
            Console.WriteLine(prod);
            int quot = numOne / numTwo;
            Console.WriteLine(quot);
            int remainder = numOne % numTwo;
            Console.WriteLine(remainder);

            Console.WriteLine("Hello");


        }

        [TestMethod]
        public void RefernceTypes() {

            //Strings
            string stringExample = "This is a string";
            string name = "Brian";
            string declared;  // been declared but not value
            declared = "Now is has been initialized";

            // Formatting strings
            string concatenate = stringExample + name; // This is a stringBrian
            string interpolate = $"{name}. Here is the string: {stringExample}.";
            Console.WriteLine(concatenate);
            Console.WriteLine(interpolate);

            //  Other Object Examples
            DateTime now = DateTime.Now;
            Console.WriteLine(now);

            DateTime randomDate = new DateTime(2019, 6, 29);

            TimeSpan waitTime = randomDate - now;
            Console.WriteLine(waitTime.TotalSeconds);

            //  Collections
            //  Arrays
            string anotherExampleString = "Hello World";
            string[] stringArray = { anotherExampleString, "Hello", "World", "!" };
            string[] students = new string[15];

            Console.WriteLine(stringArray);

            //  Lists
            System.Collections.Generic.List<string> listOfStrings = new List<string>(); //**THIS IS NOT HOW IT WORKED IN THE VIDEO
            listOfStrings.Add("Lawrence");  // unlike arrays, lists we can just keep adding to it.  arrays are a predetermined length

            //  Queue
            Queue<string> firstInFirstOut = new Queue<string>();
            firstInFirstOut.Enqueue("Luke"); //adds luke to the end of the line

            //  Dictionaries
            Dictionary<char, string> keyValuePair = new Dictionary<char, string>();
            keyValuePair.Add('j', "Josh"); //this means that the key 'j' will give us "josh"


            //  Other Collections
            SortedList<int, string> sortedKeyValuePair = new SortedList<int, string>();
            Stack<string> firstInLastOut = new Stack<string>(); //like stack of plates. last one goes on top and is the first one back out
        }
    }
}