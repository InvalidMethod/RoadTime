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

            //prevent divide by 0
            if (driveAndRestPeriod == 0)
                return (0, 0);

            int quotient = totalTime / driveAndRestPeriod;
            int remainder = totalTime % driveAndRestPeriod;

            int driveTime = quotient * maxDriveTime;
            
            driveTime += Math.Min(remainder, maxDriveTime);

            return (driveTime, totalTime - driveTime);
        }
    }
}
