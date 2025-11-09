using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_Solution_MS.EX02_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Przykład Facctory");

            List<AWojownik> soldiers = new List<AWojownik>() {
                Garnizon.CreateSoldier(TypWojownika.Piechur, "Aragorn"),
                Garnizon.CreateSoldier(TypWojownika.Piechur, "Boromir"),
                Garnizon.CreateSoldier(TypWojownika.Piechur, "Faramir"),
                Garnizon.CreateSoldier(TypWojownika.Konny, "Artur"),
                Garnizon.CreateSoldier(TypWojownika.Konny, "Lancelot"),
                Garnizon.CreateSoldier(TypWojownika.Konny, "Perseval"),
                Garnizon.CreateSoldier(TypWojownika.Strzelec, "Legolas"),
                Garnizon.CreateSoldier(TypWojownika.Strzelec, "Inny Elf"),
                Garnizon.CreateSoldier(TypWojownika.Strzelec, "Robin"),
                Garnizon.CreateSoldier(TypWojownika.Strzelec, "Hood"),
            };


        }
    }
}
