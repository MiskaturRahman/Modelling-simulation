using System;

namespace AirportOperationSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Simulation parameters
            int numberOfPassengers = 100000;
            int checkInQueueServiceTime = 15;
            int securityCheckQueueServiceTime = 30;
            int immigrationQueueServiceTime = 30;

            // Create a simulation instance
            AirportSimulation airportSimulation = new AirportSimulation(numberOfPassengers, checkInQueueServiceTime, securityCheckQueueServiceTime, immigrationQueueServiceTime);

            // Print simulation results
            Console.WriteLine("Simulation Results:");
            Console.WriteLine($"Total Passengers Processed: {airportSimulation.Passengers.Count}");
            Console.WriteLine($"Average Check-In Queue Time: {airportSimulation.AverageCheckInQueueTime} minutes");
            Console.WriteLine($"Average Security Check Queue Time: {airportSimulation.AverageSecurityCheckQueueTime} minutes");
            Console.WriteLine($"Average Immigration Queue Time: {airportSimulation.AverageImmigrationQueueTime} minutes");
            Console.WriteLine($"Average Total Queue Time: {airportSimulation.AverageTotalQueueTime} minutes");
        }
    }
}
