using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_Solution_MS.SingletonVault
{
    internal class Vault
    {
        private static Vault _instance;
        private static readonly object _lock = new();
        private static string _key;
        private Vault()
        {
            _key = createKey();
        }
        private static string createKey()
        {
            var random = new Random();
            return "4235dfsvxvn454dsfgdgfdgd454353345" + random.Next().ToString();
        }
        public static Vault Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new Vault();
                        }
                    }
                }
                return _instance;
            }
        }
        public string GetKey()
        {
            //Upewnij się że klucz jest zwracany tylko raz - dlatego zmieniam waratość przy każdym GetKey
            _key = createKey();
            return _key;
        }
    }
}
