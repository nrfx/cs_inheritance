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
    }

    public class Bicycle : Vehicle
    {
        public BicycleType type = BicycleType.Mountain;
        public int WheelRadius = 0;
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
    }
}
