using System;
using System.Collections.Generic;
using System.Text;

namespace Abandonados.Core.Entidades
{
    public class Endereco
    {
        private int _iID;
        private string _sRua;
        private string _sCidade;
        private string _sUF;
        private string _sCep;

        public int ID
        {
            get { return _iID; }
            set { _iID = value; }
        }

        public string Rua
        {
            get { return _sRua; }
            set { _sRua = value; }
        }

        public string Cidade
        {
            get { return _sCidade; }
            set { _sCidade = value; }
        }

        public string UF
        {
            get { return _sUF; }
            set { _sUF = value; }
        }

        public string Cep
        {
            get { return _sCep; }
            set { _sCep = value; }
        }
    }
}
