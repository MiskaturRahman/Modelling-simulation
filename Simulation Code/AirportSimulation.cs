using System;
using System.Collections.Generic;
using System.Linq;

namespace AirportOperationSimulation
{
    public class AirportSimulation
    {
        public int NumberOfPassengers { get; }
        public Queue CheckInQueue { get; }
        public Queue SecurityCheckQueue { get; }
        public Queue ImmigrationQueue { get; }
        public List<Passenger> Passengers { get; }

        public AirportSimulation(int numberOfPassengers, int checkInServiceTime, int securityServiceTime, int immigrationServiceTime)
        {
            NumberOfPassengers = numberOfPassengers;
            CheckInQueue = new Queue("CheckIn");
            SecurityCheckQueue = new Queue("Security");
            ImmigrationQueue = new Queue("Immigration");
            Passengers = new List<Passenger>();

            // Simulate the passengers going through each queue.
            for (int i = 0; i < NumberOfPassengers; i++)
            {
                var passenger = new Passenger();

                passenger.SetQueueWaitTime("CheckIn", new Random().Next(checkInServiceTime - 3, checkInServiceTime + 3));
                CheckInQueue.AddPassenger(passenger);

                passenger.SetQueueWaitTime("Security", new Random().Next(securityServiceTime - 3, securityServiceTime + 3));
                SecurityCheckQueue.AddPassenger(passenger);

                passenger.SetQueueWaitTime("Immigration", new Random().Next(immigrationServiceTime - 3, immigrationServiceTime + 3));
                ImmigrationQueue.AddPassenger(passenger);

                Passengers.Add(passenger);
            }
        }

        public double AverageCheckInQueueTime => Passengers.Any(p => p.GetQueueWaitTime("CheckIn") > 0) ? CheckInQueue.AverageWaitTime : 0;
        public double AverageSecurityCheckQueueTime => Passengers.Any(p => p.GetQueueWaitTime("Security") > 0) ? SecurityCheckQueue.AverageWaitTime : 0;
        public double AverageImmigrationQueueTime => Passengers.Any(p => p.GetQueueWaitTime("Immigration") > 0) ? ImmigrationQueue.AverageWaitTime : 0;
        public double AverageTotalQueueTime => Passengers.Any() ? Passengers.Average(p => p.TotalQueueWaitTime) : 0;
    }
}
