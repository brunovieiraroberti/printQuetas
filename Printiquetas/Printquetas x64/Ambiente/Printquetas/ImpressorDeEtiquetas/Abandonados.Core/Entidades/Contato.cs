using System;
using System.Collections.Generic;
using System.Text;

namespace Abandonados.Core.Entidades
{
    public class Contato
    {
        private int _iID;
        private string _sNome;

        public string Nome
        {
            get { return _sNome; }
            set { _sNome = value; }
        }

        public int ID
        {
            get { return _iID; }
            set { _iID = value; }
        }

        public override string ToString()
        {
            return Nome;
        }
    }
}
