using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _05_Classes {
    [TestClass]
    public class ClassesTest {
        [TestMethod]
        public void CookieTests() {

            Cookie cookie = new Cookie();
            cookie.Name = "Snickerdoodle";
            Cookie anotherCookie = new Cookie();
            anotherCookie.Name = "Something else";
            cookie.GramsOfFlour = 10;
            Cookie snickerdoodle = new Cookie("Snickerdoodle", false, 2);
        }

        [TestMethod]
        public void VehicleTests() {
            Vehicle car = new Vehicle();
            car.TypeOfVehicle = VehicleType.Car;

            Vehicle newCar = new Vehicle {

                TypeOfVehicle = VehicleType.Motorcycle,
                Make = "Honda",
                Model = "Magna"

            };
        }

        public void FootballPlayerTests() {
            FootballPlayer Carter = new FootballPlayer();
            Carter.Offense = true;
            Carter.Defense = false;
            Carter.SpecialTeams = true;
            Carter.Positions = PossiblePositions.QuarterBack;

            FootballPlayer austin = new FootballPlayer(true, true, true, PossiblePositions.Receiver);
            FootballPlayer brian = new FootballPlayer {
                Offense = false,
                Defense = false,
                SpecialTeams = false,
                OtherPositions = "null"
            };
        }

    }
}
