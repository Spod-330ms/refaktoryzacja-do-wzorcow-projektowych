using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RefactoringToDesignPatterns.CH06_Solution_MS.EX02_Factory.Soldiers;

namespace RefactoringToDesignPatterns.CH06_Solution_MS.EX02_Factory
{
    public static class Garnizon
    {
        public static AWojownik CreateSoldier(TypWojownika type, string name)
        {
            switch(type)
            {
                case TypWojownika.Piechur:
                    {
                        return new Piechur(name);
                    }
                case TypWojownika.Strzelec:
                    {
                        return new Strzelec(name);
                    }
                case TypWojownika.Konny:
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
