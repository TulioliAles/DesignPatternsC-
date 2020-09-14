using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._2_Structural._2._1_Adapter
{
    public class LogNetMasterService : ILogNetMaster
    {
        public void LogInfo(string message)
        {
            Console.WriteLine("Log Customizado - " + message);
        }

        public void LogException(Exception exception)
        {
            Console.WriteLine("Log Customizado - " + exception.Message);
        }
    }
}
