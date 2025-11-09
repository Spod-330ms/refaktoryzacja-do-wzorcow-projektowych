using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_Solution_MS.EX02_Factory
{
    public abstract class AWojownik
    {
        internal string Name { get; }
        public AWojownik(string name)
        {
            Name = name;
        }
        public abstract void Attack();
    }
}
