using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _07_Inheritance {
    [TestClass]
    public class InhertianceTests {
        [TestMethod]
        public void PersonExamples() {
            //var person = new Person();
            //person.FirstName = "Brian";
            var customer = new Customer(true, "Brian", "Campassi", "3174209614", "bpcampassi@gmail.com");
            //customer.Email = "bpcampassi@gmail.com";

            var employee = new Employee();
            employee.FirstName = "Joe";
            employee.HireDate = DateTime.Now;

            var hourlyEmployee = new HourlyEmployee();
            hourlyEmployee.FirstName = "John";
            hourlyEmployee.HourlyWage = 15.00m;

            var salaryEmployee = new SalaryEmployee();
            salaryEmployee.FirstName = "Jason";
            salaryEmployee.Salary = 75000;

            List<Person> people = new List<Person>();
            //people.Add(person);       can't use person anymore directly after it has been assigned to base
            people.Add(customer);
            people.Add(employee);   //We can add all these variations of "people" to the same list 

        }
            public void GamesExamples() {
            var baseball = new BallGames();
            baseball.Name = "Baseball";
            baseball.PlayersPerTeam = 9;

            var uno = new Cardgames();
            uno.Name = "Uno";
            uno.StandardDeck = false;

            var checkers = new BoardGames(true, "Checkers");
            }


        }
    }
}
