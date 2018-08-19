using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Abandonados.Core.Entidades;
using System.Data.OleDb;

namespace Abandonados.Core.Model
{
	internal class UsuarioDAO
	{
		private DBAccess _objAccess = new DBAccess();

		public UsuarioDAO()
		{
		}

		#region IUsuarioDAO Members

		public Empresa SaveEmpresa(Empresa objEmpresa)
		{
            string sSQL = string.Empty;
            int iIDLast = 0;

            //Empresa
            sSQL = "INSERT INTO empresa ( nome, telefone ) VALUES ('" + objEmpresa.Nome + "', '" + objEmpresa.Telefone +"')";
            _objAccess.ExecuteNonQuery(sSQL);

            sSQL = "Select @@Identity";
            iIDLast = Convert.ToInt16(_objAccess.ExecuteScalar(sSQL));

            //Contatos
            if (objEmpresa.Contatos != null)
            {
                foreach (Contato objContato in objEmpresa.Contatos)
                {
                    if (objContato.Nome != string.Empty || objContato.Nome != "")
                    {
                        sSQL = "INSERT INTO contato ( nome, idempresa ) VALUES ('" + objContato.Nome + "', " + iIDLast + ")";
                        _objAccess.ExecuteNonQuery(sSQL);    
                    }                    
                }
            }
            
            //Endereco
            sSQL = "INSERT INTO endereco ( rua, cidade, uf, cep, idempresa ) VALUES ('" +
                                                  objEmpresa.Endereco.Rua + "', '" + objEmpresa.Endereco.Cidade + "', '" +
                                                  objEmpresa.Endereco.UF + "', '" + objEmpresa.Endereco.Cep + "', " + iIDLast + ")";
            _objAccess.ExecuteNonQuery(sSQL);


            Empresa objEmpresaOk = GetEmpresaById(iIDLast);

            return objEmpresaOk;
		}

        public Empresa GetEmpresaById(int iID)
		{
            Empresa objEmpresa = new Empresa();

			string sSQL = "SELECT * FROM empresa WHERE id = " + iID;
			OleDbDataReader objRd = (OleDbDataReader)_objAccess.ExecuteReader(sSQL);

			try
			{
				if (objRd.Read())
				{
                    objEmpresa.ID = Convert.ToInt16(objRd["id"].ToString());
                    objEmpresa.Nome = objRd["nome"].ToString();
                    objEmpresa.Telefone = objRd["telefone"].ToString();
                }

                objEmpresa.Endereco = LoadEnderecoByEmpresa(objEmpresa.ID);
                objEmpresa.Contatos = LoadContatosByEmpresa(objEmpresa.ID);
			}
			catch (Exception)
			{
				//Disparar evento de log de erro
				return null;
			}
            finally
            {
                objRd.Close();
            }

			return objEmpresa;
		}

        public List<Contato> LoadContatosByEmpresa(int idEmpresa)
        {
            List<Contato> lstContatos = new List<Contato>();
            Contato objContato = null;

            string sSQL = "SELECT * FROM contato WHERE idempresa = " + idEmpresa;
            OleDbDataReader objRd = (OleDbDataReader)_objAccess.ExecuteReader(sSQL);

            try
            {
                while(objRd.Read())
                {
                    objContato = new Contato();

                    objContato.ID = Convert.ToInt16(objRd["id"].ToString());
                    objContato.Nome = objRd["nome"].ToString();                    

                    lstContatos.Add(objContato);
                }

            }
            catch (Exception)
            {
                //Disparar evento de log de erro
                return null;
            }
            finally
            {
                objRd.Close();
            }

            return lstContatos;
        }

        public Endereco LoadEnderecoByEmpresa(int idEmpresa)
        {
            Endereco objEndereco = new Endereco();

            string sSQL = "SELECT * FROM endereco WHERE idempresa = " + idEmpresa;
            OleDbDataReader objRd = (OleDbDataReader)_objAccess.ExecuteReader(sSQL);

            try
            {
                if (objRd.Read())
                {
                    objEndereco.ID = Convert.ToInt16(objRd["id"].ToString());
                    objEndereco.Rua = objRd["rua"].ToString();
                    objEndereco.Cidade = objRd["cidade"].ToString();
                    objEndereco.UF = objRd["uf"].ToString();
                    objEndereco.Cep = objRd["cep"].ToString();
                }
            }
            catch (Exception)
            {
                //Disparar evento de log de erro
                return null;
            }
            finally
            {
                objRd.Close();
            }

            return objEndereco;
        }

        public void LoadAllEmpresas(List<Empresa> lstEmpresa)
        {
            Empresa objEmpresa = new Empresa();
            List<Empresa> lstEmpresaAUX = new List<Empresa>();

            string sSQL = "SELECT * FROM empresa";
            OleDbDataReader objRd = (OleDbDataReader)_objAccess.ExecuteReader(sSQL);

            try
            {
                while (objRd.Read())
                {
                    objEmpresa = new Empresa();

                    objEmpresa.ID = Convert.ToInt16(objRd["id"].ToString());
                    objEmpresa.Nome = objRd["nome"].ToString();
                    objEmpresa.Telefone = objRd["telefone"].ToString();

                    lstEmpresa.Add(objEmpresa);
                }                
            }
            catch (Exception objException)
            {
                throw new System.Exception(objException.Message);
                //Disparar evento de log de erro
            }
            finally
            {
                objRd.Close();
            }

            foreach (Empresa item in lstEmpresa)
            {
                item.Endereco = LoadEnderecoByEmpresa(item.ID);
                lstEmpresaAUX.Add(item);
            }

            lstEmpresa.Clear();
            foreach (Empresa item in lstEmpresaAUX)
            {
                item.Contatos = LoadContatosByEmpresa(item.ID);
                lstEmpresa.Add(item);
            }
        }

        public void UpdateEmpresa(Empresa objEmpresa)
        {
            string sSQL = string.Empty;
            int iIDLast = 0;

            //Empresa
            sSQL = "UPDATE empresa set nome = '" + objEmpresa.Nome + "', telefone = '" + objEmpresa.Telefone + "' WHERE id = " + objEmpresa.ID;
            _objAccess.ExecuteNonQuery(sSQL);

            //sSQL = "Select @@Identity";
            //iIDLast = Convert.ToInt16(_objAccess.ExecuteScalar(sSQL));
            iIDLast = objEmpresa.ID;

            //Contatos
            if (objEmpresa.Contatos != null)
            {
                foreach (Contato objContato in objEmpresa.Contatos)
                {
                    if (objContato != null && objContato.ID != 0 && (objContato.Nome != string.Empty || objContato.Nome != ""))
                    {
                        sSQL = "UPDATE contato set nome = '" + objContato.Nome + "' WHERE id = " + objContato.ID + "";
                        _objAccess.ExecuteNonQuery(sSQL);
                    }
                    else if (objContato != null && objContato.ID == 0 && (objContato.Nome != string.Empty || objContato.Nome != ""))
                    {
                        sSQL = "INSERT INTO contato ( nome, idempresa ) VALUES ('" + objContato.Nome + "', " + objEmpresa.ID + ")";
                        _objAccess.ExecuteNonQuery(sSQL);
                    }
                }
            }

            //Endereco
            sSQL = "UPDATE endereco set rua = '" + objEmpresa.Endereco.Rua + "', cidade = '" + objEmpresa.Endereco.Cidade +
                    "', uf ='" + objEmpresa.Endereco.UF + " ', cep = '" + objEmpresa.Endereco.Cep + "'" + " WHERE id = " + objEmpresa.Endereco.ID;
            _objAccess.ExecuteNonQuery(sSQL);
        }

        public void DeleteEmpresa(Empresa objEmpresa)
        {
            string sSQL = string.Empty;
            int iIDLast = 0;

            //Empresa
            sSQL = "DELETE FROM empresa WHERE id = " + objEmpresa.ID;
            _objAccess.ExecuteNonQuery(sSQL);

            sSQL = "Select @@Identity";
            iIDLast = Convert.ToInt16(_objAccess.ExecuteScalar(sSQL));

            //Contatos
            if (objEmpresa.Contatos != null)
            {
                foreach (Contato objContato in objEmpresa.Contatos)
                {
                    sSQL = "DELETE FROM contato WHERE id = " + objContato.ID + "";
                    _objAccess.ExecuteNonQuery(sSQL);
                }
            }

            //Endereco
            sSQL = "DELETE FROM endereco WHERE id = " + objEmpresa.Endereco.ID;
            _objAccess.ExecuteNonQuery(sSQL);
        }

        //public IUsuario Load()
        //{
        //    Usuario objUsuario = new Usuario();

        //    string sSQL = "SELECT * FROM Usuarios WHERE ID = " + _objUsuario.ID;
        //    OleDbDataReader objRd = (OleDbDataReader)_objAccess.ExecuteReader(sSQL);

        //    try
        //    {
        //        if (objRd.Read())
        //        {
        //            objUsuario.ID = Convert.ToInt16(objRd["ID"].ToString());
        //            objUsuario.Nome = objRd["Nome"].ToString();
        //            objUsuario.Email = objRd["Email"].ToString();
        //            objUsuario.Senha = objRd["Senha"].ToString();
        //            objUsuario.Status = (StatusUsuario)Enum.Parse(typeof(StatusUsuario), objRd["Status"].ToString());
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        //Disparar evento de log de erro
        //        return null;
        //    }

        //    return objUsuario;
        //}

        //public IUsuario GetUserByEmailAndSenha()
        //{
        //    Usuario objUsuario = new Usuario();

        //    string sSQL = "SELECT * FROM Usuarios WHERE email = '" + _objUsuario.Email + "' AND senha = '" + _objUsuario.Senha + "'";
        //    OleDbDataReader objRd = (OleDbDataReader)_objAccess.ExecuteReader(sSQL);

        //    try
        //    {
        //        if (objRd.Read())
        //        {
        //            objUsuario.ID = Convert.ToInt16(objRd["ID"].ToString());
        //            objUsuario.Nome = objRd["Nome"].ToString();
        //            objUsuario.Email = objRd["Email"].ToString();
        //            objUsuario.Senha = objRd["Senha"].ToString();
        //            objUsuario.Status = (StatusUsuario)Enum.Parse(typeof(StatusUsuario), objRd["Status"].ToString());
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        //Disparar evento de log de erro
        //        return null;
        //    }

        //    return objUsuario;
        //}

        //public IUsuario Delete()
        //{
        //    throw new NotImplementedException();
        //}

        #endregion
	}
}
