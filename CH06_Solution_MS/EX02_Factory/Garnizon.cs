using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RefactoringToDesignPatterns.CH06_Solution_MS.EX02_Factory.Soldiers;

namespace RefactoringToDesignPatterns.CH06_Solution_MS.EX02_Factory
{
    public class Garnizon
    {
        public Wojownik CreateSoldier(string type, string name)
        {
            switch (type.ToLower())
            {
                case "piechur":
                    {
                        return new Piechur(name);
                    }
                case "strzelec":
                    {
                        return new Strzelec(name);
                    }
                case "konny":
                    {
                        return new Konny(name);
                    }
                default:
                    {
                        throw new ArgumentException("Nieznany typ wojownika");
                    }
            }
        }
    }
}
