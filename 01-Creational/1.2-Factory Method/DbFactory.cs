using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._01_Creational._1._2_Factory_Method
{
    public abstract class DbFactory
    {
        public abstract DbConnector CreateConnector(string connectionString);

        public static DbFactory Database(DataBase database)
        {
            if (database == DataBase.SqlServer)
                return new SqlFactory();
            if (database == DataBase.Oracle)
                return new OracleFactory();

            throw new ApplicationException("Banco de dados não reconhecido");
        }
    }
}
