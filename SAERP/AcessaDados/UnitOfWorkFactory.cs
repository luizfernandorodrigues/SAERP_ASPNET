using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SAERP.AcessaDados
{
    public class UnitOfWorkFactory
    {
        public static IUnitOfWork Create()
        {
            string connString = ConfigurationManager.ConnectionStrings["ConectaBanco"].ConnectionString;
            var connection = new SqlConnection(connString);
            connection.Open();
            return new UnitOfWork(connection, true);
        }
    }
}