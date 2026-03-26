using System;
using System.Collections.Generic;
using System.Text;

namespace cs_inheritance
{
    public enum BicycleType
    {
        Mountain,
        City,
        Kids
    }
    public class Vehicle
    {
        public static Random rnd = new Random();
        public int WheelsCount { get; set; }
        public virtual String GetInfo()
        {
            var str = String.Format("\nКоличество колес: {0}", this.WheelsCount);
            return str;
        }
    }

    public class Bicycle : Vehicle
    {
        public BicycleType type = BicycleType.Mountain;
        public int WheelRadius = 0;

        public override String GetInfo()
        {
            var str = "Это велосипед";
            str += base.GetInfo();
            str += String.Format("\nТип: {0}", this.type);
            str += String.Format("\nРадиус колес: {0}", this.WheelRadius);
            return str;
        }

        public static Bicycle Generate()
        {
            return new Bicycle
            {
                WheelsCount = 1 + rnd.Next(3),
                WheelRadius = 12 + rnd.Next(18),
                type = (BicycleType)rnd.Next(3)
            };
        }
    }

    public enum CarType
    {
        Bus,
        Truck,
        SUV,
        Passenger
    }
    public class Car : Vehicle
    {
        public CarType type = CarType.Bus;
        public int EngineCapacity = 0;
        public int DoorCount = 0;

        public override String GetInfo()
        {
            var str = "Это машина";
            str += base.GetInfo();
            str += String.Format("\nТип: {0}", this.type);
            str += String.Format("\nОбъем двигателя: {0}", this.EngineCapacity);
            str += String.Format("\nКоличество дверей: {0}", this.DoorCount);
            return str;
        }

        public static Car Generate()
        {
            return new Car
            {
                WheelsCount = 4,
                EngineCapacity = 4 + rnd.Next(18),
                DoorCount = 2 + rnd.Next(4),
                type = (CarType)rnd.Next(3)
            };
        }
    }

    public enum AirplaneEngineType
    {
        Jet,
        Propeller
    }
    public class Airplane : Vehicle
    {
        public AirplaneEngineType type = AirplaneEngineType.Jet;
        public int FlightLevel = 0;

        public override String GetInfo()
        {
            var str = "Я самолет";
            str += base.GetInfo();
            str += String.Format("\nТип: {0}", this.type);
            str += String.Format("\nВысота полета: {0}", this.FlightLevel);
            return str;
        }

        public static Airplane Generate()
        {
            return new Airplane
            {
                WheelsCount = 3 + rnd.Next(29),
                FlightLevel = 1000 + rnd.Next(10000),
                type = (AirplaneEngineType)rnd.Next(2)
            };
        }
    }
}
