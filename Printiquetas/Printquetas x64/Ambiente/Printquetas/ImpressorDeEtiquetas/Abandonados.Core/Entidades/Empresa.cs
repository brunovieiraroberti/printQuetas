using System;
using System.Collections.Generic;
using System.Text;

namespace Abandonados.Core.Entidades
{
    public class Empresa
    {
        private int _iID;
        private string _sNome;
        private string _sNomeContato;
        private string _sTelefone;
        private Endereco _Endereco;
        private List<Contato> _lstContato;

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

        public string NomeContato
        {
            get { return _sNomeContato; }
            set { _sNomeContato = value; }
        }

        public string Telefone
        {
            get { return _sTelefone; }
            set { _sTelefone = value; }
        }

        public Endereco Endereco
        {
            get { return _Endereco; }
            set { _Endereco = value; }
        }

        public List<Contato> Contatos
        {
            get { return _lstContato; }
            set { _lstContato = value; }
        }

        public override string ToString()
        {
            return Nome;
        }

        //public Contato Contato2
        //{
        //    get { return _Contato2; }
        //    set { _Contato2 = value; }
        //}

        //public Contato Contato3
        //{
        //    get { return _Contato3; }
        //    set { _Contato3 = value; }
        //}

        //public Contato Contato4
        //{
        //    get { return _Contato4; }
        //    set { _Contato4 = value; }
        //}

        //public Contato Contato5
        //{
        //    get { return _Contato5; }
        //    set { _Contato5 = value; }
        //}

        //public Contato Contato6
        //{
        //    get { return _Contato6; }
        //    set { _Contato6 = value; }
        //}
    }
}
