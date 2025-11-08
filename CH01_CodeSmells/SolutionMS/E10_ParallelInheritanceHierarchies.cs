using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH01_CodeSmells.SolutionMS
{
    internal class E10_ParallelInheritanceHierarchies
    {
    }


    public class FileLogger : ILogger
    {
        public void LogMessage() { /* Implementacja dla pliku */ }
    }

    public class DatabaseLogger : ILogger
    {
        public void LogMessage() { /* Implementacja dla bazy danych */ }
    }


    public class XmlExporter : IExporter
    {
        public void ExportData() { /* Implementacja dla XML */ }
    }

    public class JsonExporter : IExporter
    {
        public void ExportData() { /* Implementacja dla JSON */ }
    }

    public interface ILogger
    {
        void LogMessage();
    }
    public interface IExporter
    {
        void ExportData();
    }
}
