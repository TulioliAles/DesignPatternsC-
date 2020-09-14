using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._2_Structural._2._1_Adapter
{
    public interface ILogger
    {
        void Log(string message);
        void LogError(Exception exception);
    }
}
