using System;
using System.Text;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Data.OleDb;
using System.IO;
using System.Configuration;
using System.Xml.Linq;

namespace Abandonados.Core.Model
{
	/// <summary>
	/// Classe de acesso ao Banco de Dados Access
	/// </summary>
	internal class DBAccess : IDisposable
	{
		private IDbCommand cmd = new OleDbCommand();
		private string strLastError = string.Empty;
		OleDbConnection cnn = new OleDbConnection();
        private string strConnection;


        public string LoadCnnString()
        {

           //IEnumerable<XElement> obj = XMLConexao.Doc.Descendants("connectionStrings");
           //foreach (var item in obj)
           //{
           //    strConnection = item.Value.ToString();
           //    strConnection = item.Attribute("name").Value.ToString();
           //    strConnection = item.Element("cnn").Value.ToString();
           //}

            if (cnn.State == System.Data.ConnectionState.Closed)
            {
                strConnection = (from p in XMLConexao.Doc.Descendants("connectionStrings")
                                 where p.Attribute("name").Value.ToString() == "G_S_CONNECTION_STRING"
                                 select p.Value.ToString()).FirstOrDefault().ToString();

                return strConnection + "Password = psxx;";
            }

            return "";
        }

		/// <summary>
		/// Contrutor inicializa obj cmd e cria uma conexao
		/// </summary>
		public DBAccess()
		{
            if (cnn.State == System.Data.ConnectionState.Closed)
            {
                string strConnectionString = LoadCnnString();

                cnn.ConnectionString = strConnectionString;
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.Text;
            }
			
            if (cnn.State == ConnectionState.Closed)
			    cnn.Open();
		}
		 
		~DBAccess()
		{
			if (cnn.State == System.Data.ConnectionState.Open)
			{
                cnn = new OleDbConnection(LoadCnnString());
				cnn.Close();
			}
		}

		private IDataReader ExecuteReader()
		{
			IDataReader reader = null;

            try
            {
                reader = cmd.ExecuteReader();
            }
            catch (Exception objException)
            {
                throw new System.Exception(objException.Message);
            }              

			return reader;
		}

		/// <summary>
		/// Metodo execulta no banco o comando passado como parametro
		/// Ex: SqlDataReader dr = (SqlDataReader)obj.ExecuteReader(texto);
		/// </summary>
		/// <param name="commandtext">Comando em string</param>
		/// <returns>Interface IDataReader</returns>
		public IDataReader ExecuteReader(string commandtext)
		{
			IDataReader reader = null;

			try
			{
				cmd.CommandText = commandtext;
				reader = ExecuteReader();
			}
			catch (Exception objException)
			{
				throw new System.Exception(objException.Message);
			}

			return reader;
		}		

		private int ExecuteNonQuery()
		{
			int i = -1;
			try
			{
				i = cmd.ExecuteNonQuery();
			}
			catch (Exception objException)
			{
				throw new System.Exception(objException.Message);
			}

			return i;
		}

		/// <summary>
		/// Execulta o comando e retorna -1 caso nao consiga
		/// </summary>
		/// <param name="commandtext">Comando em string</param>
		/// <returns>Integer</returns>
		public int ExecuteNonQuery(string commandtext)
		{
			int i = -1;
			try
			{
				cmd.CommandText = commandtext;
				i = ExecuteNonQuery();
			}
			catch (Exception objException)
			{
				throw new System.Exception(objException.Message);
			}

			return i;
		}

		private DataSet ExecuteDataSet()
		{
			OleDbDataAdapter da = null;
			DataSet ds = null;

			try
			{
				da = new OleDbDataAdapter();
				da.SelectCommand = (OleDbCommand)cmd;
				ds = new DataSet();
				da.Fill(ds);
			}
			catch (Exception objException)
			{
				throw new System.Exception(objException.Message);
			}

			return ds;
		}

		/// <summary>
		/// Execulta o comando passado como parametro 
		/// Retorna um data set, bastante usado para objetos com dataSource
		/// </summary>
		/// <param name="commandtext">Comando em string</param>
		/// <returns>DataSet</returns>
		public DataSet ExecuteDataSet(string commandtext)
		{
			DataSet ds = null;

			try
			{
				cmd.CommandText = commandtext;
				ds = ExecuteDataSet();
			}
			catch (Exception objException)
			{
				throw new System.Exception(objException.Message);
			}

			return ds;
		}

		private object ExecuteScalar()
		{
			object obj = null;
			try
			{
				obj = cmd.ExecuteScalar();
			}
			catch (Exception objException)
			{
				throw new System.Exception(objException.Message);
			}

			return obj;
		}

		/// <summary>
		/// Esceculta o comando passado como parametro 
		/// Retorna a 1 col 1 linha do resultado
		/// </summary>
		/// <param name="commandtext">Comando em string</param>
		/// <returns>Object</returns>
		public object ExecuteScalar(string commandtext)
		{
			object obj = null;

			try
			{
				cmd.CommandText = commandtext;
				obj = ExecuteScalar();
			}
			catch (Exception objException)
			{
				throw new System.Exception(objException.Message);
			}

			return obj;
		}

		private string CommandText
		{
			get
			{
				return cmd.CommandText;
			}
			set
			{
				cmd.CommandText = value;
				cmd.Parameters.Clear();
			}
		}

		

		private void Open()
		{
			cmd.Connection.Open();
		}

		private void Close()
		{
			cmd.Connection.Close();
		}

		#region IDisposable Members

		public void Dispose()
		{
			throw new NotImplementedException();
		}

		#endregion
	}
}
