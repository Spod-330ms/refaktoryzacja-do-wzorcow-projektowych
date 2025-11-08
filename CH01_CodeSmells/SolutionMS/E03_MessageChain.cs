using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH01_CodeSmells.SolutionMS
{
    public class Car
    {
        public Engine GetEngine()
        {
            return new Engine();
        }

        public string GetCylinderSize()
        {
            return GetEngine().GetCylinder().GetSize();
        }
    }

    public class Engine
    {
        public Cylinder GetCylinder()
        {
            return new Cylinder();
        }
    }

    public class Cylinder
    {
        public string GetSize()
        {
            return "2.0L";
        }
    }

    public class  MessageChain
    {
        public void Excercise3()
        {
            Car car = new Car();
            string size = car.GetCylinderSize();
            Console.WriteLine($"Cylinder Size: {size}");
        }
    }
}
