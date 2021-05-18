using System;
using System.Collections.Generic;
using System.Text;

namespace RoadTime
{
    public static class DriverTimeCalculator
    {
        public static (int driveTime, int restTime) FindDriveAndRestTime(int totalTime, int maxDriveTime, int minRestTime)
        {
            int driveAndRestPeriod = maxDriveTime + minRestTime;

            int quotient = totalTime / driveAndRestPeriod;
            int remainder = totalTime % driveAndRestPeriod;

            int driveTime = quotient * maxDriveTime;
            int restTime = quotient * minRestTime;

            driveTime += Math.Min(remainder, maxDriveTime);
            restTime += Math.Max(0, remainder - maxDriveTime);

            return (driveTime, restTime);
        }
    }
}
