using System;
using Core.Entities;

namespace Entities.Concrete
{
    public class AccessWindow:IEntity
    {
        public AccessWindow(DateTime startTime, DateTime endTime)
        {
            this.StartTime = startTime;
            this.EndTime = endTime;
        }

        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}
