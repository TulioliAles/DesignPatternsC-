using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._01_Creational._1._2_Factory_Method
{
    public class OracleFactory : DbFactory
    {
        // Factory Method
        public override DbConnector CreateConnector(string connectionString)
        {
            return new OracleDbConnector(connectionString);
        }
    }
}
