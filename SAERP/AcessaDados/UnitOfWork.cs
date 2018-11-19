using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace SAERP.AcessaDados
{
    public class UnitOfWork : IUnitOfWork
    {
        public bool _hasConnection { get; set; }
        public IDbTransaction _transaction { get; set; }
        public IDbConnection _connection { get; set; }

        public UnitOfWork(IDbConnection connection, bool hasconnection)
        {
            _connection = connection;
            _hasConnection = hasconnection;
            _transaction = connection.BeginTransaction();
        }

        public IDbCommand CreateCommand()
        {
            var command = _connection.CreateCommand();
            command.Transaction = _transaction;
            return command;
        }

        public void SaveChanges()
        {
            if (_transaction == null)
            {
                throw new InvalidOperationException("A Transação já Foi Comitada!");
            }
            _transaction.Commit();
            _transaction = null;
        }

        public void Dispose()
        {
            if (_transaction != null)
            {
                _transaction.Rollback();
                _transaction = null;
            }

            if (_connection != null && _hasConnection)
            {
                _connection.Close();
                _connection = null;
            }
        }
    }
}