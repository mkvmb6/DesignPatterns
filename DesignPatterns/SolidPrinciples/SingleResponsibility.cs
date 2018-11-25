using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace SolidPrinciples
{
    internal class SingleResponsibility
    {
        private static void Main()
        {
            var logger = new Logger();
            logger.AddLog("Mohit is a bad guy.");
            logger.AddLog("He lied in previous statement.");

            Console.WriteLine($"All logs:\n{logger}");
            var persistance = new Persistance();
            const string fileName = "MyLogs.txt";
            persistance.SaveToFile(logger, fileName);
            Process.Start(fileName);
        }
    }

    //A class should not have more than one responsibility.
    internal class Logger
    {
        private readonly List<string> myLogs = new List<string>();
        private static int myLogCount;

        public int AddLog(string message)
        {
            myLogs.Add($" {++myLogCount}- {message} -{DateTime.Now}");
            return myLogCount;
        }

        public void RemoveLog(int index)
        {
            myLogs.RemoveAt(index);
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, myLogs);
        }

        //Below method is the extra responsibility for this class. So moved it to another class i.e. Persistance.
        //public void SaveToFile(string fileName)
        //{
        //    File.WriteAllText(fileName, ToString());
        //}
    }

    internal class Persistance
    {
        public void SaveToFile(Logger logger, string fileName)
        {
            File.WriteAllText(fileName, logger.ToString());
        }
    }
}