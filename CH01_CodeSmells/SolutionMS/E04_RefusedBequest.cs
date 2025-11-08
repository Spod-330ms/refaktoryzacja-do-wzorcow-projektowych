using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH01_CodeSmells.SolutionMS
{
    internal class RefusedBequest
    {
        public interface IEmployee
        {
            void Work();
            void AttendMeeting();
        }

        public class BasicEmployee
        {
            public string Name { get; set; }
            public string Position { get; set; }
        }
        public class Employee : BasicEmployee, IEmployee
        {
            public string Name { get; set; }
            public string Position { get; set; }
            public void Work() { /* Implementacja */ }
            public void AttendMeeting() { /* Implementacja */ }
            public void SubmitReport() { /* Implementacja */ }
        }

        public class Manager : BasicEmployee, IEmployee
        {
            public void Work() { /* Implementacja */ }
            public void AttendMeeting() { /* Implementacja */ }

            public void ManageTeam() { /* Implementacja */ }
        }


    }
}
