using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Abandonados.Core.Entidades;
using Abandonados.Core.Control;

namespace ImpressorDeEtiquetas
{
    public partial class NovoCadastro : Form
    {
        private Empresa _objEmpresa = null;
        private UserControlDAO _objControl = new UserControlDAO();

        public NovoCadastro()
        {
            InitializeComponent();

            btnAlterar.Visible = false;
            btnDeletar.Visible = false;
        }

        public NovoCadastro(Empresa objEmpresa)
        {
            InitializeComponent();

            _objEmpresa = objEmpresa;

            btnOk.Visible = false;

            CarregaCampos(_objEmpresa);
        }

        private void CarregaCampos(Empresa objEmpresa)
        {   
            txtNome.Text = objEmpresa.Nome;
            txtTelefone.Text = objEmpresa.Telefone;

            txtRua.Text = objEmpresa.Endereco.Rua;
            txtCidade.Text = objEmpresa.Endereco.Cidade;
            txtUF.Text = objEmpresa.Endereco.UF;
            txtCep.Text = objEmpresa.Endereco.Cep;

            if (objEmpresa.Contatos != null && objEmpresa.Contatos.Count > 0)
                txtContato1.Text = objEmpresa.Contatos[0].ToString();
            if (objEmpresa.Contatos != null && objEmpresa.Contatos.Count > 1)
                txtContato2.Text = objEmpresa.Contatos[1].ToString();
            if (objEmpresa.Contatos != null && objEmpresa.Contatos.Count > 2)
                txtContato3.Text = objEmpresa.Contatos[2].ToString();
            if (objEmpresa.Contatos != null && objEmpresa.Contatos.Count > 3)
                txtContato4.Text = objEmpresa.Contatos[3].ToString();
            if (objEmpresa.Contatos != null && objEmpresa.Contatos.Count > 4)
                txtContato5.Text = objEmpresa.Contatos[4].ToString();
            if (objEmpresa.Contatos != null && objEmpresa.Contatos.Count > 5)
                txtContato6.Text = objEmpresa.Contatos[5].ToString();
            
         }

        //Salvar
        private void button1_Click(object sender, EventArgs e)
        {
            Empresa objEmpresa = new Empresa();

            _objControl.SalvarEmpresa(CarregaEmpresa(objEmpresa));

            this.Close();
        }

        private Empresa CarregaEmpresa(Empresa objEmpresa)
        {
            Endereco objEndereço = new Endereco();

            if (_objEmpresa != null && _objEmpresa.Endereco != null)
                objEndereço = _objEmpresa.Endereco;
            
            objEndereço.Rua = txtRua.Text;
            objEndereço.Cidade = txtCidade.Text;
            objEndereço.UF = txtUF.Text;
            objEndereço.Cep = txtCep.Text;
            
            #region Contatos
            Contato objContato = null;
            List<Contato> lstContato = new List<Contato>();

            objContato = new Contato();
            if (objEmpresa.Contatos != null && objEmpresa.Contatos.Count >= 1)
                objContato = _objEmpresa.Contatos[0];
            objContato.Nome = txtContato1.Text;
            lstContato.Add(objContato);

            objContato = new Contato();
            if (objEmpresa.Contatos != null && objEmpresa.Contatos.Count >= 2)
                objContato = _objEmpresa.Contatos[1];
                objContato.Nome = txtContato2.Text;
            lstContato.Add(objContato);

            objContato = new Contato();
            if (objEmpresa.Contatos != null && objEmpresa.Contatos.Count >= 3)
                objContato = _objEmpresa.Contatos[2];
                objContato.Nome = txtContato3.Text;
            lstContato.Add(objContato);

            objContato = new Contato();
            if (objEmpresa.Contatos != null && objEmpresa.Contatos.Count >= 4)
                objContato = _objEmpresa.Contatos[3];
                objContato.Nome = txtContato4.Text;
            lstContato.Add(objContato);

            objContato = new Contato();
            if (objEmpresa.Contatos != null && objEmpresa.Contatos.Count >= 5)
                objContato = _objEmpresa.Contatos[4];
                objContato.Nome = txtContato5.Text;
            lstContato.Add(objContato);

            objContato = new Contato();
            if (objEmpresa.Contatos != null && objEmpresa.Contatos.Count >= 6)
                objContato = _objEmpresa.Contatos[5];
                objContato.Nome = txtContato6.Text;
            lstContato.Add(objContato);
            #endregion

            objEmpresa.Nome = txtNome.Text;
            objEmpresa.Telefone = txtTelefone.Text;
            objEmpresa.Contatos = lstContato;
            objEmpresa.Endereco = objEndereço;

            return objEmpresa;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void NovoCadastro_Load(object sender, EventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            _objControl.AlterarEmpresa(CarregaEmpresa(_objEmpresa));

            this.Close();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            _objControl.ExcluirEmpresa(CarregaEmpresa(_objEmpresa));

            this.Close();
        }
    }
}
