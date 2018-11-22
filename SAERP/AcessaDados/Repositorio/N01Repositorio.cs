using SAERP.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SAERP.AcessaDados.Repositorio
{
    public class N01Repositorio
    {
        private readonly UnitOfWork _uow;
        SqlParameterCollection sqlParametros = new SqlCommand().Parameters;

        public N01Repositorio(IUnitOfWork uow)
        {
            if (uow == null)
            {
                throw new ArgumentException("Uow");
            }
            _uow = uow as UnitOfWork;
            if (_uow == null)
            {
                throw new NotSupportedException("UnitOfWork Factory esta nulo.");
            }
        }
        public List<FF08Model> CarregaPlaca()
        {
            List<FF08Model> fF08Models;
            using (var comando = _uow.CreateCommand())
            {
                comando.CommandText = "SELECT " +
                        " FF08.UKEY AS UKEY, " +
                        "FF08.FF08_001_C AS PLACA, " +
                        "FF08.FF08_009_C AS DESCRICAO " +
                    "FROM " +
                        "FF08 " +
                    "WHERE " +
                        "FF08_010_N = @PARAMETRO";
                comando.CommandTimeout = 7200;
                sqlParametros.Add(new SqlParameter("@PARAMETRO", 1));
                foreach (SqlParameter sqlParameter in sqlParametros)
                {
                    comando.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }
                using (var resultado = comando.ExecuteReader())
                {
                    while (resultado.Read())
                    {
                        FF08Model f = new FF08Model();
                        f.Ukey = Convert.ToString(resultado.GetValue())
                    }
                }

                if (linhas == 1)
                {
                    retorno = true;
                }
                return retorno;
            }


            return FF08Model;
        }
    }
}