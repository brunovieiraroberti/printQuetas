using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Abandonados.Core.Model
{
    class XMLConexao
    {
        private static string _sNomeArquivo = Environment.CurrentDirectory + @"\Config_Connection.xml";
        private static XDocument _Doc = XDocument.Load(_sNomeArquivo);

        public static XDocument Doc
        {
			get { return XMLConexao._Doc; }			
        }

        public static void Save()
        {
            _Doc.Save(_sNomeArquivo);
        }
    }
}

