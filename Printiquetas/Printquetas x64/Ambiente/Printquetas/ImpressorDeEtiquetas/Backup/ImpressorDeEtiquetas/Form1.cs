using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using Abandonados.Core.Entidades;
using Abandonados.Core.Control;

namespace ImpressorDeEtiquetas
{
    public partial class Form1 : Form
    {
        private IList<string> lstString1 = new List<string>();
        private IList<string> lstString2 = new List<string>();

        private List<Empresa> lstEmpresa1to2uni = new List<Empresa>();
        private List<Empresa> lstEmpresa1to2all = new List<Empresa>();
        private List<Empresa> lstEmpresa2to1uni = new List<Empresa>();
        private List<Empresa> lstEmpresa2to1all = new List<Empresa>();

        private Dictionary<int, float> _dcIndiceEtiquetas = new Dictionary<int, float>();
        private List<Empresa> _lstImpressaoFinal = new List<Empresa>();
        private List<Empresa> _lstCountImpressaoFinal = new List<Empresa>();
        int iCount = 0, iCountMorePagesTotal = 0, iCountMorePages = 0;

        private List<Empresa> lstEmpresaAImprimir = new List<Empresa>();
        private List<Empresa> lstEmpresaAll = new List<Empresa>();

        string sTextoAImprimir = string.Empty;

        int i = 0;

        string sContEtiqueta = string.Empty;

        public Form1()
        {
            InitializeComponent();

            CarregaDicionario(_dcIndiceEtiquetas);            
        }

        private void CarregaDicionario(Dictionary<int, float> dcIndiceEtiquetas)
        {
            dcIndiceEtiquetas.Add(0, 55);
            dcIndiceEtiquetas.Add(1, 151);
            dcIndiceEtiquetas.Add(2, 255);
            dcIndiceEtiquetas.Add(3, 355);
            dcIndiceEtiquetas.Add(4, 455);
            dcIndiceEtiquetas.Add(5, 558);
            dcIndiceEtiquetas.Add(6, 658);
            dcIndiceEtiquetas.Add(7, 758);
            dcIndiceEtiquetas.Add(8, 858);
            dcIndiceEtiquetas.Add(9, 958);
            dcIndiceEtiquetas.Add(10, 55);
            dcIndiceEtiquetas.Add(11, 155);
            dcIndiceEtiquetas.Add(12, 255);
            dcIndiceEtiquetas.Add(13, 355);
            dcIndiceEtiquetas.Add(14, 455);
            dcIndiceEtiquetas.Add(15, 558);
            dcIndiceEtiquetas.Add(16, 658);
            dcIndiceEtiquetas.Add(17, 758);
            dcIndiceEtiquetas.Add(18, 858);
            dcIndiceEtiquetas.Add(19, 958);
            dcIndiceEtiquetas.Add(20, 55);
            dcIndiceEtiquetas.Add(21, 155);
            dcIndiceEtiquetas.Add(22, 255);
            dcIndiceEtiquetas.Add(23, 355);
            dcIndiceEtiquetas.Add(24, 455);
            dcIndiceEtiquetas.Add(25, 558);
            dcIndiceEtiquetas.Add(26, 658);
            dcIndiceEtiquetas.Add(27, 758);
            dcIndiceEtiquetas.Add(28, 858);
            dcIndiceEtiquetas.Add(29, 958);


            //dcIndiceEtiquetas.Add(0, 37);
            //dcIndiceEtiquetas.Add(1, 137);
            //dcIndiceEtiquetas.Add(2, 237);
            //dcIndiceEtiquetas.Add(3, 337);
            //dcIndiceEtiquetas.Add(4, 437);
            //dcIndiceEtiquetas.Add(5, 537);
            //dcIndiceEtiquetas.Add(6, 637);
            //dcIndiceEtiquetas.Add(7, 737);
            //dcIndiceEtiquetas.Add(8, 837);
            //dcIndiceEtiquetas.Add(9, 937);
            //dcIndiceEtiquetas.Add(10, 37);
            //dcIndiceEtiquetas.Add(11, 137);
            //dcIndiceEtiquetas.Add(12, 237);
            //dcIndiceEtiquetas.Add(13, 337);
            //dcIndiceEtiquetas.Add(14, 437);
            //dcIndiceEtiquetas.Add(15, 537);
            //dcIndiceEtiquetas.Add(16, 637);
            //dcIndiceEtiquetas.Add(17, 737);
            //dcIndiceEtiquetas.Add(18, 837);
            //dcIndiceEtiquetas.Add(19, 937);
            //dcIndiceEtiquetas.Add(20, 37);
            //dcIndiceEtiquetas.Add(21, 137);
            //dcIndiceEtiquetas.Add(22, 237);
            //dcIndiceEtiquetas.Add(23, 337);
            //dcIndiceEtiquetas.Add(24, 437);
            //dcIndiceEtiquetas.Add(25, 537);
            //dcIndiceEtiquetas.Add(26, 637);
            //dcIndiceEtiquetas.Add(27, 737);
            //dcIndiceEtiquetas.Add(28, 837);
            //dcIndiceEtiquetas.Add(29, 937);
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //if (iCountImpressao == 2)
            //{
            //    iCount = Convert.ToInt16(sContEtiqueta);
            //    iCountMorePages = iCount;
            //    iCountMorePagesTotal = iCount;

            //    lstAImprimir.DataSource = _lstCountImpressaoFinal;
            //    foreach (Empresa item in _lstCountImpressaoFinal)
            //    {
            //        _lstImpressaoFinal.Add(item);
            //    }
            //}

            //variaveis usadas para definir as configurações da impressão
            float margemEsquerda = e.MarginBounds.Left;
            float margemSuperior = e.MarginBounds.Top;
            Font fonteImpressao = new Font("arial",08);
            SolidBrush mCaneta = new SolidBrush(Color.Black);
            float eixoX = 1.2F, eixoY = 37;

            //sao 10 retangulos
            //y representa a distancia em relacao a parte de cima
            //x representa a distancia em relacao a lado esquerdo

            for (; i < lstAImprimir.Items.Count;)
            {
                //_lstImpressaoFinal.Remove(objEmpresa);
                Empresa objEmpresa = _lstCountImpressaoFinal[i];
                i++;

                sTextoAImprimir = CriarStringDeImpressao(objEmpresa);

                if (iCount == 29 || iCount == 59 || iCount == 89 || iCount == 119 || iCount == 149)
                {
                    e.HasMorePages = true;

                    Imprimir(e, fonteImpressao, mCaneta, eixoX, eixoY, sTextoAImprimir);

                    iCount = 0;
                    iCountMorePages += 1;
                    sTextoAImprimir = string.Empty;

                    break;
                }
                else if ((lstAImprimir.Items.Count + iCountMorePagesTotal) == iCountMorePages)
                    e.HasMorePages = false;                

                Imprimir(e, fonteImpressao, mCaneta, eixoX, eixoY, sTextoAImprimir);

                iCount += 1;
                iCountMorePages += 1;
                sTextoAImprimir = string.Empty;
            }

            if ((lstAImprimir.Items.Count + iCountMorePagesTotal) == iCountMorePages)
            {
                iCount = Convert.ToInt16(sContEtiqueta);
                iCountMorePages = iCount;
                iCountMorePagesTotal = iCount;

                i = 0;

                e.HasMorePages = false;
                return;
            } 
            //lstAImprimir.DataSource = _lstImpressaoFinal;

            //if (lstAImprimir.Items.Count == 0)
            //    iCountImpressao += 2;
        }

        private void Imprimir(System.Drawing.Printing.PrintPageEventArgs e, Font fonteImpressao, SolidBrush mCaneta, float eixoX, float eixoY, string sTextoAImprimir)
        {
            if (iCount >= 0 && iCount <= 9)
            {
                eixoX = 1F;
            }
            if (iCount >= 10 && iCount <= 19)
            {
                eixoX = 276;
            }
            if (iCount >= 20 && iCount <= 29)
            {
                eixoX = 552;
            }

            eixoY = _dcIndiceEtiquetas[iCount];

            //Cria retangulo com tamanho e posição definida
            RectangleF rectangle = new RectangleF(eixoX, eixoY, 264, 115);

            // clear the canvas to white
            SolidBrush solidWhite;
            //if (iCount % 2 == 0)
            //    solidWhite = new SolidBrush(Color.Azure);
            //else
            //    solidWhite = new SolidBrush(Color.DarkGray);
            
            solidWhite = new SolidBrush(Color.White);

            e.Graphics.FillRectangle(solidWhite, rectangle);

            e.Graphics.DrawString(sTextoAImprimir, fonteImpressao, mCaneta, rectangle);
        }

        private string CriarStringDeImpressao(Empresa objEmpresa)
        {
            string sTextoAImprimir = string.Empty;
            sTextoAImprimir = objEmpresa.Nome + "\n";
            sTextoAImprimir += objEmpresa.Endereco.Rua + "\n";

            if (objEmpresa.Endereco.Cidade != string.Empty && objEmpresa.Endereco.UF != string.Empty && objEmpresa.Endereco.Cep != string.Empty)
                sTextoAImprimir += objEmpresa.Endereco.Cidade + " - " + objEmpresa.Endereco.UF + " - Cep: " + objEmpresa.Endereco.Cep;
                        
            sTextoAImprimir += "\r\n \r\n A/C: " + objEmpresa.NomeContato;
            return sTextoAImprimir;
        }

        private void button4_Click(object sender, EventArgs e)
        {            
            sContEtiqueta = Microsoft.VisualBasic.Interaction.InputBox("A partir de qual etiqueta voce dejesa imprimir sendo de (0 a 29)", "Indice de etiqueta", "0", 300, 300);

            LoadLista();

            try
            {
                PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog();
                printPreviewDialog1.Document = this.printDocument1;
                printPreviewDialog1.FormBorderStyle = FormBorderStyle.Fixed3D;
                printPreviewDialog1.ShowDialog();
            }
            catch (Exception exp)
            {
                MessageBox.Show(" Erro : " + exp.Message.ToString());
            }
        }

        private void LoadLista()
        {
            iCount = Convert.ToInt16(sContEtiqueta);
            iCountMorePages = iCount;
            iCountMorePagesTotal = iCount;

            _lstImpressaoFinal = new List<Empresa>();
            _lstCountImpressaoFinal = new List<Empresa>();

            foreach (Empresa item in lstAImprimir.Items)
            {
                _lstImpressaoFinal.Add(item);
            }

            foreach (Empresa item in lstAImprimir.Items)
            {
                _lstCountImpressaoFinal.Add(item);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Empresa> lstEmpresa = new List<Empresa>();
            lstEmpresa = LoadEmpresas();

            lstPrincipal.DataSource = lstEmpresa;

            AutoCompleteStringCollection lstStringsBusca = new AutoCompleteStringCollection();

            foreach (Empresa item in lstPrincipal.Items)
            {
                lstStringsBusca.Add(item.Nome);
            }

            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            comboBox1.AutoCompleteCustomSource = lstStringsBusca;
        }

        private List<Empresa> LoadEmpresas()
        {
            List<Empresa> lstEmpresa = new List<Empresa>();
            List<Empresa> lstEmpresaAux = new List<Empresa>();

            UserControlDAO objControl = new UserControlDAO();
            objControl.CarregarTodasEmpresas(lstEmpresa);

            lstEmpresaAll = lstEmpresa.OrderBy(x => x.Nome).ToList();

            return lstEmpresaAll;
        }

        //btn Lst1 To Lst2 Unit
        private void button2_Click(object sender, EventArgs e)
        {
            Empresa objEmpresaAux = null;
            try
            {
                lstEmpresa1to2uni.Clear();

                foreach (Empresa item in lstAImprimir.Items)
                {
                    objEmpresaAux = new Empresa();
                    objEmpresaAux.Contatos = item.Contatos;
                    objEmpresaAux.Endereco = item.Endereco;
                    objEmpresaAux.ID = item.ID;
                    objEmpresaAux.Nome = item.Nome;
                    objEmpresaAux.NomeContato = item.NomeContato;

                    lstEmpresa1to2uni.Add(objEmpresaAux);
                }

                Empresa objEmpresa = (Empresa)lstPrincipal.SelectedItem;

                List<Contato> lstContato = null;
                if (objEmpresa.Contatos != null)
                {
                    lstContato = new List<Contato>();
                    Contato objContatoAux = null;
                    foreach (Contato item in objEmpresa.Contatos)
                    {
                        objContatoAux = new Contato();

                        objContatoAux.ID = item.ID;
                        objContatoAux.Nome = item.Nome;

                        lstContato.Add(objContatoAux);
                    }
                }

                objEmpresaAux = new Empresa();
                objEmpresaAux.Contatos = lstContato;
                objEmpresaAux.Endereco = objEmpresa.Endereco;
                objEmpresaAux.ID = objEmpresa.ID;
                objEmpresaAux.Nome = objEmpresa.Nome;
                if (objEmpresaAux.Contatos != null && objEmpresaAux.Contatos.Count > 0)
                    objEmpresaAux.NomeContato = objEmpresa.Contatos[0].Nome;

                lstEmpresa1to2uni.Add(objEmpresaAux);

                lstAImprimir.DataSource = null;
                lstAImprimir.DataSource = lstEmpresa1to2uni;
            }
            catch (Exception)
            {
                MessageBox.Show("Selecione um item");
            }           
        }

        //btn Lst1 To Lst2 All
        private void button1_Click(object sender, EventArgs e)
        {
            Empresa objEmpresaAux = null;
            try
            {
                lstEmpresa1to2uni.Clear();
                lstAImprimir.DataSource = null;

                foreach (Empresa item in lstPrincipal.Items)
                {
                    objEmpresaAux = new Empresa();
                    objEmpresaAux.Contatos = item.Contatos;
                    objEmpresaAux.Endereco = item.Endereco;
                    objEmpresaAux.ID = item.ID;
                    objEmpresaAux.Nome = item.Nome;
                    if (item.Contatos != null && item.Contatos.Count > 0)
                    {
                        foreach (Contato objContato in item.Contatos)
                        {
                            if (item.Contatos.Count >= 1)
                            {
                                objEmpresaAux.NomeContato += objContato.Nome + " / ";
                            }
                            //else
                            //{
                            //    objEmpresaAux.NomeContato += objContato.Nome;
                            //}
                        }

                        objEmpresaAux.NomeContato = objEmpresaAux.NomeContato.Remove(objEmpresaAux.NomeContato.Length - 3, 3);
                    }

                    lstEmpresa1to2uni.Add(objEmpresaAux);
                }

                //Empresa objEmpresa = (Empresa)lstPrincipal.SelectedItem;

                //List<Contato> lstContato = null;
                //if (objEmpresa.Contatos != null)
                //{
                //    lstContato = new List<Contato>();
                //    Contato objContatoAux = null;
                //    foreach (Contato item in objEmpresa.Contatos)
                //    {
                //        objContatoAux = new Contato();

                //        objContatoAux.ID = item.ID;
                //        objContatoAux.Nome = item.Nome;

                //        lstContato.Add(objContatoAux);
                //    }
                //}

                //objEmpresaAux = new Empresa();
                //objEmpresaAux.Contatos = lstContato;
                //objEmpresaAux.Endereco = objEmpresa.Endereco;
                //objEmpresaAux.ID = objEmpresa.ID;
                //objEmpresaAux.Nome = objEmpresa.Nome;
                //if (objEmpresa.Contatos != null && objEmpresa.Contatos.Count > 0)
                //    objEmpresaAux.NomeContato = objEmpresa.Contatos[0].Nome;

                lstEmpresa1to2uni.Add(objEmpresaAux);

                lstAImprimir.DataSource = null;
                lstAImprimir.DataSource = lstEmpresa1to2uni;
            }
            catch (Exception)
            {
                MessageBox.Show("Selecione um item");
            }
        }

        //btn Lst2 To Lst1 Unit
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                lstEmpresa2to1uni.Clear();

                foreach (Empresa item in lstAImprimir.Items)
	            {
                    lstEmpresa2to1uni.Add(item); 
	            }                
                
                Empresa objEmpresa = (Empresa)lstAImprimir.SelectedItem;

                lstEmpresa2to1uni.Remove(objEmpresa);

                lstAImprimir.DataSource = null;
                lstAImprimir.DataSource = lstEmpresa2to1uni;
            }
            catch (Exception)
            {
                MessageBox.Show("Selecione um item");
            }            
        }

        //btn Lst2 To Lst1 All
        private void button6_Click(object sender, EventArgs e)
        {
            lstAImprimir.DataSource = null;
        }

        private void novoCadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NovoCadastro frmNovoCadastro = new NovoCadastro();

            frmNovoCadastro.ShowDialog();

            lstPrincipal.DataSource = null;
            lstPrincipal.DataSource = LoadEmpresas(); 
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {              
                case Keys.F9:
                    NovoCadastro frmNovoCadastroNovo = new NovoCadastro();
                    frmNovoCadastroNovo.ShowDialog();
                    lstPrincipal.DataSource = null;
                    lstEmpresaAll = LoadEmpresas();
                    lstPrincipal.DataSource = lstEmpresaAll;
                    break;
                case Keys.F5:
                    CarregarCombo1();
                    lstPrincipal.DataSource = null;
                    lstPrincipal.DataSource = LoadEmpresas();
                    break;
                case Keys.F8:
                    Empresa objEmpresa = (Empresa)lstPrincipal.SelectedItem;
                    NovoCadastro frmNovoCadastroAlterar = new NovoCadastro(objEmpresa);
                    frmNovoCadastroAlterar.ShowDialog();
                    lstPrincipal.DataSource = null;
                    lstEmpresaAll = LoadEmpresas();
                    lstPrincipal.DataSource = lstEmpresaAll;
                    break;      
            }
        }

        private void btnLimparLst1_Click(object sender, EventArgs e)
        {
            lstAImprimir.DataSource = null;
        }

        private void btnLimparLst2_Click(object sender, EventArgs e)
        {
            lstPrincipal.DataSource = null;
        }

        private void CarregarCombo1()
        { 
            
        }

        private void gvLista1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gvLista1_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            
        }

        private void gvLista1_NewRowNeeded(object sender, DataGridViewRowEventArgs e)
        {

        }

        private void gvLista1_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {

        }

        private void gvLista1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            
        }

        private void gvLista1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {

        }

        private void gvLista1_DataSourceChanged(object sender, EventArgs e)
        {

        }

        private void gvLista1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        

        private void gvLista1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void gvLista1_Click(object sender, EventArgs e)
        {
            
        }

        private void gvLista1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //LoagGridCombro(e);
        }

        private void gvLista1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void gvLista1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gvLista1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void lstAImprimir_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Empresa objEmpresa = (Empresa)lstAImprimir.SelectedItem;

            cboContato.DataSource = objEmpresa.Contatos;
        }

        private void cboContato_SelectedIndexChanged(object sender, EventArgs e)
        {
            Empresa objEmpresa = (Empresa)lstAImprimir.SelectedItem;
            objEmpresa.NomeContato = cboContato.SelectedItem.ToString();
            //lstEmpresa1to2uni.Add(objEmpresa);

            //lstAImprimir.DataSource = null;
            //lstAImprimir.DataSource = lstEmpresa1to2uni;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lstPrincipal_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblCont1.Text = string.Empty;
            lblCont2.Text = string.Empty;
            lblCont3.Text = string.Empty;
            lblCont4.Text = string.Empty;
            lblCont5.Text = string.Empty;
            lblCont6.Text = string.Empty;

            Empresa objEmpresa = (Empresa)lstPrincipal.SelectedItem;

            if (objEmpresa != null)
            {
                lblNome.Text = objEmpresa.Nome;
                lblTelefone.Text = objEmpresa.Telefone;
                lblEndereco.Text = objEmpresa.Endereco.Rua;

                if (objEmpresa.Contatos != null && objEmpresa.Contatos.Count > 0)
                    lblCont1.Text = objEmpresa.Contatos[0].Nome;
                if (objEmpresa.Contatos != null && objEmpresa.Contatos.Count > 1)
                    lblCont2.Text = objEmpresa.Contatos[1].Nome;
                if (objEmpresa.Contatos != null && objEmpresa.Contatos.Count > 2)
                    lblCont3.Text = objEmpresa.Contatos[2].Nome;
                if (objEmpresa.Contatos != null && objEmpresa.Contatos.Count > 3)
                    lblCont4.Text = objEmpresa.Contatos[3].Nome;
                if (objEmpresa.Contatos != null && objEmpresa.Contatos.Count > 4)
                    lblCont5.Text = objEmpresa.Contatos[4].Nome;
                if (objEmpresa.Contatos != null && objEmpresa.Contatos.Count > 5)
                    lblCont6.Text = objEmpresa.Contatos[5].Nome;
            }            
        }

        private void lstPrincipal_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Empresa objEmpresaAux = null;
            try
            {
                lstEmpresa1to2uni.Clear();

                foreach (Empresa item in lstAImprimir.Items)
                {
                    objEmpresaAux = new Empresa();
                    objEmpresaAux.Contatos = item.Contatos;
                    objEmpresaAux.Endereco = item.Endereco;
                    objEmpresaAux.ID = item.ID;
                    objEmpresaAux.Nome = item.Nome;
                    objEmpresaAux.NomeContato = item.NomeContato;

                    lstEmpresa1to2uni.Add(objEmpresaAux);
                }

                Empresa objEmpresa = (Empresa)lstPrincipal.SelectedItem;

                List<Contato> lstContato = null;
                if (objEmpresa.Contatos != null)
                {
                    lstContato = new List<Contato>();
                    Contato objContatoAux = null;
                    foreach (Contato item in objEmpresa.Contatos)
                    {
                        objContatoAux = new Contato();

                        objContatoAux.ID = item.ID;
                        objContatoAux.Nome = item.Nome;

                        lstContato.Add(objContatoAux);
                    }
                }
                                
                objEmpresaAux = new Empresa();
                objEmpresaAux.Contatos = lstContato;
                objEmpresaAux.Endereco = objEmpresa.Endereco;
                objEmpresaAux.ID = objEmpresa.ID;
                objEmpresaAux.Nome = objEmpresa.Nome;
                if (objEmpresaAux.Contatos != null && objEmpresaAux.Contatos.Count > 0)
                    objEmpresaAux.NomeContato = objEmpresa.Contatos[0].Nome;

                lstEmpresa1to2uni.Add(objEmpresaAux);

                lstAImprimir.DataSource = null;
                lstAImprimir.DataSource = lstEmpresa1to2uni;
            }
            catch (Exception)
            {
                MessageBox.Show("Selecione um item");
            }            
        }

        private void atualizarF5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lstPrincipal.DataSource = null;
            lstEmpresaAll = LoadEmpresas();
            lstPrincipal.DataSource = lstEmpresaAll; 
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            List<Empresa> lstEmpresa = new List<Empresa>();
            lstEmpresa = lstEmpresaAll;
            Empresa objEmpresaAux = null;

            lstEmpresa1to2uni.Clear();

            foreach (Empresa item in lstAImprimir.Items)
            {
                objEmpresaAux = new Empresa();
                objEmpresaAux.Contatos = item.Contatos;
                objEmpresaAux.Endereco = item.Endereco;
                objEmpresaAux.ID = item.ID;
                objEmpresaAux.Nome = item.Nome;
                objEmpresaAux.NomeContato = item.NomeContato;

                lstEmpresa1to2uni.Add(item);
            }

            Empresa objEmpresa = (from item in lstEmpresa where item.Nome.ToUpperInvariant() == comboBox1.Text.ToUpperInvariant() select item).FirstOrDefault();

            List<Contato> lstContato = null;
            if (objEmpresa.Contatos != null)
            {
                lstContato = new List<Contato>();
                Contato objContatoAux = null;
                foreach (Contato item in objEmpresa.Contatos)
                {
                    objContatoAux = new Contato();

                    objContatoAux.ID = item.ID;
                    objContatoAux.Nome = item.Nome;

                    lstContato.Add(objContatoAux);
                }
            }

            objEmpresaAux = new Empresa();
            objEmpresaAux.Contatos = lstContato;
            objEmpresaAux.Endereco = objEmpresa.Endereco;
            objEmpresaAux.ID = objEmpresa.ID;
            objEmpresaAux.Nome = objEmpresa.Nome;
            if (objEmpresaAux.Contatos != null && objEmpresaAux.Contatos.Count > 0)
                objEmpresaAux.NomeContato = objEmpresa.Contatos[0].Nome;

            lstEmpresa1to2uni.Add(objEmpresaAux);

            lstAImprimir.DataSource = null;
            lstAImprimir.DataSource = lstEmpresa1to2uni;                      
        }

        private void alterarF8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Empresa objEmpresa = (Empresa)lstPrincipal.SelectedItem;

            NovoCadastro frmNovoCadastro = new NovoCadastro(objEmpresa);
            frmNovoCadastro.ShowDialog();

            lstPrincipal.DataSource = null;
            lstPrincipal.DataSource = LoadEmpresas();
        }
    }
}
