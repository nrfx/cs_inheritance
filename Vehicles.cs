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
    }
}
