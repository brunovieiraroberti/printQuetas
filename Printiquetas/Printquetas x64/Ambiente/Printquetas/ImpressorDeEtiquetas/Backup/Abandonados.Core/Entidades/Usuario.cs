using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Abandonados.Core.Model;

namespace Abandonados.Core.Entidades
{
	public class Usuario : IUsuario
	{
		#region Attributes

		private int _iID;
		private string _sNome;
		private string _sEmail;
		private TipoUsuario _eTipo;
		private StatusUsuario _eStatus;
		private string _sSenha;

		#endregion

		#region Initialize

		public Usuario()
		{  }

		public Usuario(string sNome, string sEmail, string sSenha)
		{
			_sNome = sNome;
			_sEmail = sEmail;
			_sSenha = sSenha;
		}

		#endregion

		#region IUsuario Members

		public int ID
		{
			get { return _iID; }
			set { _iID = value; }
		}

		public string Nome
		{
			get { return _sNome; }
			set { _sNome = value; }
		}

		public string Email
		{
			get { return _sEmail; }
			set { _sEmail = value; }
		}

		public TipoUsuario Tipo
		{
			get { return _eTipo; }
			set { _eTipo = value; }
		}

		public StatusUsuario Status
		{
			get { return _eStatus; }
			set { _eStatus = value; }
		}

		public string Senha
		{
			get { return _sSenha; }
			set { _sSenha = value; }
		}

		#endregion
	}
}
