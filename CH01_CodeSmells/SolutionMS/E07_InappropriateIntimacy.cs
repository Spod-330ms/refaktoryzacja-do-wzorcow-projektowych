using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH01_CodeSmells.SolutionMS
{
    public class Course
    {
        private int _credits;
        private bool _isCompleted;

        public int Credits
        {
            get { return _credits; }
            private set { _credits = value; }
        }

        public bool IsCompleted
        {
            get { return _isCompleted; }
            private set { _isCompleted = value; }
        }

        public void MarkAsCompleted()
        {
            _isCompleted = true;
        }
        public void SetCredits(int credits)
        {
            _credits = credits;
        }
    }

    public class Student
    {
        public void CompleteCourse(Course course)
        {
            course.SetCredits(3);
            course.MarkAsCompleted();
        }
    }
}
