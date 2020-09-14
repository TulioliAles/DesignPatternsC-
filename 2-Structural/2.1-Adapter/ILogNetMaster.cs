using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._2_Structural._2._1_Adapter
{
    public interface ILogNetMaster
    {
        void LogInfo(string message);
        void LogException(Exception exception);
    }
}
