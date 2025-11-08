using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH01_CodeSmells.SolutionMS
{
    public class Excercise2
    {
        public void LogError(string message, DateTime timestamp)
        {
            string formattedMessage = FormatLogMessage(message, timestamp, LogLevel.ERROR);
            Console.WriteLine(formattedMessage);
        }

        public void LogWarning(string message, DateTime timestamp)
        {
            string formattedMessage = FormatLogMessage(message, timestamp, LogLevel.WARNING);
            Console.WriteLine(formattedMessage);
        }

        private string FormatLogMessage(string message, DateTime timestamp, LogLevel level)
        {
            string formattedTimestamp = timestamp.ToString("yyyy-MM-dd HH:mm:ss");
            string formattedMessage = $"{level.ToString()}: [{formattedTimestamp}] {message}";
            
            return formattedMessage;
        }

    }

    public enum LogLevel
    {
        ERROR,
        WARNING
    }
}
