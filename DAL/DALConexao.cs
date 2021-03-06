﻿using System;
using System.Data.SqlClient;
using Oracle.DataAccess.Client;

namespace DAL
{
    public class DALConexao
    {
        private String _stringConexao;
        private SqlConnection _conexao;
        private SqlTransaction _transaction;


        public DALConexao(String dadosConexao)
        {
            this._conexao = new SqlConnection();
            this.StringConexao = dadosConexao;
            this._conexao.ConnectionString = dadosConexao;
        }

        public String StringConexao
        {
            get { return this._stringConexao; }
            set { this._stringConexao = value; }
        }

        public SqlConnection ObjetoConexao
        {
            get { return this._conexao; }
            set { this._conexao = value; }

        }

        public SqlTransaction ObjetoTransacao
        {
            get { return this._transaction; }
            set { this._transaction = value; }
        }
        public void Conectar()
        {
            this._conexao.Open();
        }

        public void Desconectar()
        {
            this._conexao.Close();
        }
        public void IniciarTransacao()
        {
            this._transaction = _conexao.BeginTransaction();
        }

        public void TerminarTransacao()
        {
            this._transaction.Commit();
        }

        public void CancelarTransacao()
        {
            this._transaction.Rollback();
        }
             
    }
    public class DALTABConexao
    {
        private String _stringConexao;
        private OracleConnection _conexao;
        private OracleTransaction _transaction;

        public DALTABConexao(String dadosConexao)
        {

            this._conexao = new OracleConnection();

            this.StringConexao = dadosConexao;
            this._conexao.ConnectionString = dadosConexao;
        }

        public String StringConexao
        {
            get { return this._stringConexao; }
            set { this._stringConexao = value; }
        }


        public OracleConnection ObjetoConexao

        {
            get { return this._conexao; }
            set { this._conexao = value; }

        }

        public OracleTransaction ObjetoTransacao
        {
            get { return this._transaction; }
            set { this._transaction = value; }
        }
        public void Conectar()
        {
            this._conexao.Open();
        }

        public void Desconectar()
        {
            this._conexao.Close();
        }
        public void IniciarTransacao()
        {
            this._transaction = _conexao.BeginTransaction();
        }

        public void TerminarTransacao()
        {
            this._transaction.Commit();
        }

        public void CancelarTransacao()
        {
            this._transaction.Rollback();
        }

    }
}
