using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2ChallengeWithGroup {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello, what is your name?");
            string name = Console.ReadLine();
            Greeter hello = new Greeter();
            hello.HelloUser(name);
            hello.ByeUser(name);
            Console.WriteLine();
            hello.GreetingBasedOnTime();
        }
    }
}
