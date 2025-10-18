using RefactoringToDesignPatterns.CH01_CodeSmells.Solutions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH01_CodeSmells.SolutionMS
{
    internal class E08_LongMessageChain
    {
        public void Example()
        {
            // Przykład wywołania
            School school = new School();
            string teacherName = school.GetTeacherName();
        }
    }

    public class School
    {
        public string GetTeacherName()
        {
            Classroom classroom = new Classroom();
            return classroom.GetTeacher().GetName();
        }
    }

    public class Classroom
    {
        public Teacher GetTeacher()
        {
            return new Teacher();
        }
    }

    public class Teacher
    {
        public string GetName()
        {
            return "John Smith";
        }
    }
}
