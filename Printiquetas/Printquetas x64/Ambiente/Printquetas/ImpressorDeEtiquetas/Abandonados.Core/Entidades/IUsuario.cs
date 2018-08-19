using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abandonados.Core.Entidades
{
	public enum TipoUsuario
	{
		Admin = 1,
		Normal = 0
	}

	public enum StatusUsuario
	{
		Ativo = 1,
		Inativo = 0
	}

	public interface IUsuario
	{
		int ID { get; }
		string Nome { get; }
		string Email { get; }
		string Senha { get; }

		/// <summary>
		/// Enum Admin ou Funcionario
		/// </summary>
		TipoUsuario Tipo { get; }

		/// <summary>
		/// Enum Ativo ou Inativo
		/// </summary>
		StatusUsuario Status { get; }
	}	
}
