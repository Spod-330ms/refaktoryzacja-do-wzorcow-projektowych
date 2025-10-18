using RefactoringToDesignPatterns.CH01_CodeSmells.Solutions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH01_CodeSmells.SolutionMS
{
    internal class E06_DataClumps
    {
        public void RegisterEvent(EventDetails eventDetails)
        {
            Console.WriteLine(eventDetails.ToString());
        }
    }

    internal class EventDetails
    {
        public string EventName { get; }
        public DateTime EventDate { get; }
        public string Location { get; }
        public EventDetails(string eventName, DateTime eventDate, string location)
        {
            EventName = eventName;
            EventDate = eventDate;
            Location = location;
        }

        override public string ToString()
        {
            return $"Event: {this.EventName}, Date: {this.EventDate}, Location: {this.Location}";
        }
    }
}
