using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2ChallengeWithGroup {
    class Greeter {
        public void HelloUser(string name) {

            Console.WriteLine($"Hello {name}");
        }
        public void ByeUser(string name) {
            Console.WriteLine($"Farewell {name}");
        }
        public void GreetingBasedOnTime() {
            DateTime now = DateTime.Now;
            if (now.Hour < 12) {
                Console.WriteLine("Good Morning!");

            } else if (now.Hour < 17) {
                Console.WriteLine("Good Afternoon!");
            }
            else if (now.Hour < 21) {
                Console.WriteLine("Good Evening");
            }
            else
                Console.WriteLine("Good Night");

        }


    }

}
