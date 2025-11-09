using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_Solution_MS.EX02_Factory.Soldiers
{
    internal class Konny : AWojownik
    {
        public Konny(string name) : base(name)
        {
        }

        public override void Attack()
        {
            throw new NotImplementedException();
        }
    }
}
