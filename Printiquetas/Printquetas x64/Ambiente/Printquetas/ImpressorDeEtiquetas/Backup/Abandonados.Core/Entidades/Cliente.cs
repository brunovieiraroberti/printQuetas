using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ImpressorDeEtiquetas
{
    //Obsotelo - nao usar
    public class Cliente
    {
        private int _iID;
        private Boolean _bStatus;
        private string _sEndereço;
        private string _sCidade;
        private string _sUF;
        private string _sCep;
        private string _sNomeEmpresa;
        private string _sNomeContato1;
        private string _sNomeContato2;
        private string _sNomeContato3;
        private string _sNomeContato4;
        private string _sNomeContato5;
        private string _sNomeContato6;

        public string NomeContato1 
        {
            get { return _sNomeContato1;} 
            set{_sNomeContato1 = value;} 
        }

        public string NomeContato2
        {
            get { return _sNomeContato2; }
            set { _sNomeContato2 = value; }
        }

        public string NomeContato3
        {
            get { return _sNomeContato3; }
            set { _sNomeContato3 = value; }
        }

        public string NomeContato4
        {
            get { return _sNomeContato4; }
            set { _sNomeContato4 = value; }
        }

        public string NomeContato5
        {
            get { return _sNomeContato5; }
            set { _sNomeContato5 = value; }
        }

        public string NomeContato6
        {
            get { return _sNomeContato6; }
            set { _sNomeContato6 = value; }
        }

        public string Endereco
        {
            get { return _sEndereço; }
            set { _sEndereço = value; }
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

        public string NomeEmpresa
        {
            get { return _sNomeEmpresa; }
            set { _sNomeEmpresa = value; }
        }

        public Boolean Status
        {
            get { return _bStatus; }
            set { _bStatus = value; }
        }

        public int ID
        {
            get { return _iID; }
            set { _iID = value; }
        }

        public override string ToString()
        {
            return NomeEmpresa + "\r" + Endereco + "\r" + Cidade + " - " + UF + " - " + Cep + "\r\n";
        }
    }
}
