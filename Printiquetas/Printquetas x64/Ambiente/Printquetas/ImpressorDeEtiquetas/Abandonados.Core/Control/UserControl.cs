using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Abandonados.Core.Entidades;
using Abandonados.Core.Model;
using Abandonados.Ultilidades;

namespace Abandonados.Core.Control
{
	public class UserControlDAO
	{
        UsuarioDAO objDAO = new UsuarioDAO();

		public Empresa SalvarEmpresa(Empresa objEmpresa)
		{
            objDAO.SaveEmpresa(objEmpresa);

            return objEmpresa;
		}

		public void CarregarTodasEmpresas(List<Empresa> lstEmpresas)
		{
            objDAO.LoadAllEmpresas(lstEmpresas);
		}

        public Empresa CarregarEmpresa(int ID)
        {
            return null;
        }

        public Empresa AlterarEmpresa(Empresa objEmpresa)
        {
            objDAO.UpdateEmpresa(objEmpresa);

            return objEmpresa;
        }

        public Empresa ExcluirEmpresa(Empresa objEmpresa)
        {
            objDAO.DeleteEmpresa(objEmpresa);

            return objEmpresa;
        }








        //Usuarios
		public IUsuario CarregarUsuario(string sEmail, string sSenha)
		{
            return null;
		}

		public IUsuario ExcluirUsuario(int iIdUser)
		{
            return null;
		}
	}
}
