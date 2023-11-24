using System;
using System.Collections.Generic;

namespace AirportOperationSimulation
{
    public class Passenger
    {
        private Dictionary<string, int> QueueWaitTimes = new Dictionary<string, int>();

        public Passenger()
        {
            foreach (var queue in new[] { "CheckIn", "Security", "Immigration" })
            {
                QueueWaitTimes[queue] = 0;
            }
        }

        public void SetQueueWaitTime(string type, int minutes)
        {
            if (QueueWaitTimes.ContainsKey(type))
            {
                QueueWaitTimes[type] = minutes;
            }
            else
            {
                throw new InvalidOperationException($"Queue type {type} not recognized.");
            }
        }

        public int GetQueueWaitTime(string type)
        {
            if (QueueWaitTimes.ContainsKey(type))
            {
                return QueueWaitTimes[type];
            }
            else
            {
                throw new InvalidOperationException($"Queue type {type} not recognized.");
            }
        }

        public int TotalQueueWaitTime => QueueWaitTimes.Values.Sum();
    }
}
