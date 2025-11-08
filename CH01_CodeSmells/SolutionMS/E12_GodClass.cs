using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH01_CodeSmells.SolutionMS
{
    public class UserManager
    {
        public void ManageUsers()
        {
            Console.WriteLine("Managing users.");
        }
    }
    public class SystemConfigurator
    {
        public void ConfigureSystem()
        {
            Console.WriteLine("Configuring system.");
        }
    }
    public class SystemReportGenerator
    {
        public void GenerateSystemReport()
        {
            Console.WriteLine("System report generated.");
        }
    }
    public class LogRegistrar
    {
        public void RegisterLog(string log)
        {
            Console.WriteLine($"Log: {log}");
        }
    }
    public class AdminPanel
    {
        public UserManager UserManager { get; set; }
        public SystemConfigurator SystemConfigurator { get; set; }
        public SystemReportGenerator SystemReportGenerator { get; set; }
        public LogRegistrar LogRegistrar { get; set; }
        public AdminPanel()
        {
            UserManager = new UserManager();
            SystemConfigurator = new SystemConfigurator();
            SystemReportGenerator = new SystemReportGenerator();
            LogRegistrar = new LogRegistrar();
        }
    }

    
}
