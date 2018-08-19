using System;
using System.Collections.Generic;
using System.Text;

namespace Abandonados.Core.Entidades
{
    public class Etiqueta
    {
        private Empresa _Empresa;
        private Endereco _Endereco;
        private Contato _Contato;

        public Empresa Empresa
        {
            get { return _Empresa; }
            set { _Empresa = value; }
        }

        public Endereco Endereco
        {
            get { return _Endereco; }
            set { _Endereco = value; }
        }

        public Contato NomeEmpresa
        {
            get { return _Contato; }
            set { _Contato = value; }
        }
    }
}
