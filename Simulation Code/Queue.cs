using System.Collections.Generic;
using System.Linq;

namespace AirportOperationSimulation
{
    public class Queue
    {
        public string QueueType { get; }
        private List<Passenger> WaitingPassengers;

        public Queue(string type)
        {
            QueueType = type;
            WaitingPassengers = new List<Passenger>();
        }

        public void AddPassenger(Passenger passenger)
        {
            WaitingPassengers.Add(passenger);
        }

        public double AverageWaitTime => WaitingPassengers.Any() ? WaitingPassengers.Average(p => p.GetQueueWaitTime(QueueType)) : 0;
    }
}
