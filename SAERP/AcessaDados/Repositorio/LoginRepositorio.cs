using SAERP.Utilitarios;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SAERP.AcessaDados.Repositorio
{
    public class LoginRepositorio
    {
        Util _util = new Util();
        private readonly UnitOfWork _uow;
        SqlParameterCollection sqlParametros = new SqlCommand().Parameters;

        public LoginRepositorio(IUnitOfWork uow)
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
        public bool Login(string login, string senha)
        {
            bool retorno = false;
            try
            {
                //FAÇO HAsh da senha
                string hashSenha = _util.geraHash(senha);
                using (var comando = _uow.CreateCommand())
                {
                    comando.CommandText = "SELECT " +
                            "TOP 1 " +
                            "* " +
                        "FROM USUARIO " +
                        "WHERE " +
                            "USUARIO =@USUARIO AND " +
                            "SENHA = @SENHA";
                    comando.CommandTimeout = 7200;
                    sqlParametros.Add(new SqlParameter("@USUARIO", login));
                    sqlParametros.Add(new SqlParameter("@SENHA", hashSenha));
                    foreach (SqlParameter sqlParameter in sqlParametros)
                    {
                        comando.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                    }
                    int linhas = 0;
                    using (var resultado = comando.ExecuteReader())
                    {
                        while (resultado.Read())
                        {
                            linhas++;
                        }
                    }

                    if (linhas == 1)
                    {
                        retorno = true;
                    }
                    return retorno;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}