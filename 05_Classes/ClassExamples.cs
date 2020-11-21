using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes {
    public class Cookie {
        public string Name { get; set; }
        public bool HasNuts { get; set; }
        public double GramsOfFlour { get; set; }

        public Cookie() {

        }

        public Cookie(string name, bool hasNuts, double gramsOfFlour) {
            Name = name;
            HasNuts = hasNuts;
            GramsOfFlour = gramsOfFlour;
        }
    }

        public enum VehicleType { Car, Truck, Van, Motorcycle, Boat }


        public class Vehicle {
            public string Make { get; set; }
            public string Model { get; set; }
            public double Mileage { get; set; }
            public int Year { get; set; }
            public string Color { get; set; }
            public VehicleType TypeOfVehicle { get; set; }

            public Vehicle() {

            }


        }
        public class Order {
            public string CustomerName { get; set; }
            public Cookie OrderedProduct { get; set; }
            public decimal TotalCost { get; set; }
        }
    public enum PossiblePositions { QuarterBack, Receiver, Lineman, RunningBack, Defense,  }
    public class FootballPlayer {
        public bool Offense { get; set; }
        public bool Defense { get; set; }
        public bool SpecialTeams { get; set; }
        public PossiblePositions Positions { get; set; }
        public string OtherPositions { get; set; }

        public FootballPlayer() {
        }
        public FootballPlayer(bool offense, bool defense, bool specialTeams, PossiblePositions positions) {
            Offense = offense;
            Defense = defense;
            SpecialTeams = specialTeams;
            Positions = positions;
        }
    }
    }


