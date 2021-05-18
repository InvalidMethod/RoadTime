using System;

namespace RoadTime
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalTripTime = 21;
            int maxDriveTime = 6;
            int minRestTime = 4;
            (int driveTime, int restTime) driveAndRestTuple = DriverTimeCalculator.FindDriveAndRestTime(totalTripTime, maxDriveTime, minRestTime);
            Console.WriteLine($"Given total trip time of {totalTripTime}, the driver was OTR for {driveAndRestTuple.driveTime} and rested for {driveAndRestTuple.restTime} hours");
        }
    }
}
