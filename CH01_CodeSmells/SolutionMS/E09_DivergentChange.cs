using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH01_CodeSmells.SolutionMS
{
    internal class E09_DivergentChange
    {
    }

    public class UserAccount
    {
        public string Username { get; set; }
        public string Password { get; set; }

    }

    public class  AuthenticationService
    {
        public void Login(UserAccount userAccount, string username, string password)
        {
            // Logika logowania
            Console.WriteLine("User logged in.");
        }

        public void Logout(UserAccount userAccount)
        {
            // Logika wylogowania
            Console.WriteLine("User logged out.");
        }
    }

    public class  UserReportGenerator
    {
        public void GenerateReport(UserAccount userAccount)
        {
            // Logika generowania raportu
            Console.WriteLine("Generating user report.");
        }
    }
}
