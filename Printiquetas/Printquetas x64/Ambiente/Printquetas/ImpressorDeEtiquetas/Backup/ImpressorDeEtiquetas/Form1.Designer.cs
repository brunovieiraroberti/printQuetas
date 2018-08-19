namespace ImpressorDeEtiquetas
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lstPrincipal = new System.Windows.Forms.ListBox();
            this.btnLst1ToLst2All = new System.Windows.Forms.Button();
            this.btnLst1ToLst2Unit = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnLst2ToLst1Unit = new System.Windows.Forms.Button();
            this.btnLst2ToLst1All = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoCadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atualizarF5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarF8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLimparLst1 = new System.Windows.Forms.Button();
            this.btnLimparLst2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboContato = new System.Windows.Forms.ComboBox();
            this.lstAImprimir = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblCont1 = new System.Windows.Forms.Label();
            this.lblCont2 = new System.Windows.Forms.Label();
            this.lblCont3 = new System.Windows.Forms.Label();
            this.lblCont4 = new System.Windows.Forms.Label();
            this.lblCont5 = new System.Windows.Forms.Label();
            this.lblCont6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstPrincipal
            // 
            this.lstPrincipal.FormattingEnabled = true;
            this.lstPrincipal.Location = new System.Drawing.Point(27, 268);
            this.lstPrincipal.Name = "lstPrincipal";
            this.lstPrincipal.Size = new System.Drawing.Size(314, 329);
            this.lstPrincipal.TabIndex = 0;
            this.lstPrincipal.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstPrincipal_MouseDoubleClick);
            this.lstPrincipal.SelectedIndexChanged += new System.EventHandler(this.lstPrincipal_SelectedIndexChanged);
            // 
            // btnLst1ToLst2All
            // 
            this.btnLst1ToLst2All.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLst1ToLst2All.Location = new System.Drawing.Point(384, 262);
            this.btnLst1ToLst2All.Name = "btnLst1ToLst2All";
            this.btnLst1ToLst2All.Size = new System.Drawing.Size(75, 45);
            this.btnLst1ToLst2All.TabIndex = 2;
            this.btnLst1ToLst2All.Text = ">>";
            this.btnLst1ToLst2All.UseVisualStyleBackColor = true;
            this.btnLst1ToLst2All.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLst1ToLst2Unit
            // 
            this.btnLst1ToLst2Unit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLst1ToLst2Unit.Location = new System.Drawing.Point(384, 211);
            this.btnLst1ToLst2Unit.Name = "btnLst1ToLst2Unit";
            this.btnLst1ToLst2Unit.Size = new System.Drawing.Size(75, 45);
            this.btnLst1ToLst2Unit.TabIndex = 1;
            this.btnLst1ToLst2Unit.Text = ">";
            this.btnLst1ToLst2Unit.UseVisualStyleBackColor = true;
            this.btnLst1ToLst2Unit.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(779, 575);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 32);
            this.button4.TabIndex = 9;
            this.button4.Text = "Imprimir";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnLst2ToLst1Unit
            // 
            this.btnLst2ToLst1Unit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLst2ToLst1Unit.Location = new System.Drawing.Point(384, 427);
            this.btnLst2ToLst1Unit.Name = "btnLst2ToLst1Unit";
            this.btnLst2ToLst1Unit.Size = new System.Drawing.Size(75, 45);
            this.btnLst2ToLst1Unit.TabIndex = 3;
            this.btnLst2ToLst1Unit.Text = "<";
            this.btnLst2ToLst1Unit.UseVisualStyleBackColor = true;
            this.btnLst2ToLst1Unit.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnLst2ToLst1All
            // 
            this.btnLst2ToLst1All.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLst2ToLst1All.Location = new System.Drawing.Point(384, 478);
            this.btnLst2ToLst1All.Name = "btnLst2ToLst1All";
            this.btnLst2ToLst1All.Size = new System.Drawing.Size(75, 45);
            this.btnLst2ToLst1All.TabIndex = 4;
            this.btnLst2ToLst1All.Text = "<<";
            this.btnLst2ToLst1All.UseVisualStyleBackColor = true;
            this.btnLst2ToLst1All.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(276, 24);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(61, 31);
            this.button7.TabIndex = 1;
            this.button7.Text = ">";
            this.button7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Location = new System.Drawing.Point(28, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 74);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(242, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(893, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoCadastroToolStripMenuItem,
            this.atualizarF5ToolStripMenuItem,
            this.alterarF8ToolStripMenuItem});
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.novoToolStripMenuItem.Text = "Menu";
            // 
            // novoCadastroToolStripMenuItem
            // 
            this.novoCadastroToolStripMenuItem.Name = "novoCadastroToolStripMenuItem";
            this.novoCadastroToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.novoCadastroToolStripMenuItem.Text = "&Novo cadastro         F9";
            this.novoCadastroToolStripMenuItem.Click += new System.EventHandler(this.novoCadastroToolStripMenuItem_Click);
            // 
            // atualizarF5ToolStripMenuItem
            // 
            this.atualizarF5ToolStripMenuItem.Name = "atualizarF5ToolStripMenuItem";
            this.atualizarF5ToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.atualizarF5ToolStripMenuItem.Text = "Atualizar                  F5";
            this.atualizarF5ToolStripMenuItem.Click += new System.EventHandler(this.atualizarF5ToolStripMenuItem_Click);
            // 
            // alterarF8ToolStripMenuItem
            // 
            this.alterarF8ToolStripMenuItem.Name = "alterarF8ToolStripMenuItem";
            this.alterarF8ToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.alterarF8ToolStripMenuItem.Text = "Alterar                     F8";
            this.alterarF8ToolStripMenuItem.Click += new System.EventHandler(this.alterarF8ToolStripMenuItem_Click);
            // 
            // btnLimparLst1
            // 
            this.btnLimparLst1.Location = new System.Drawing.Point(626, 154);
            this.btnLimparLst1.Name = "btnLimparLst1";
            this.btnLimparLst1.Size = new System.Drawing.Size(75, 23);
            this.btnLimparLst1.TabIndex = 7;
            this.btnLimparLst1.Text = "Limpar\r\n";
            this.btnLimparLst1.UseVisualStyleBackColor = true;
            this.btnLimparLst1.Click += new System.EventHandler(this.btnLimparLst1_Click);
            // 
            // btnLimparLst2
            // 
            this.btnLimparLst2.Location = new System.Drawing.Point(266, 246);
            this.btnLimparLst2.Name = "btnLimparLst2";
            this.btnLimparLst2.Size = new System.Drawing.Size(75, 23);
            this.btnLimparLst2.TabIndex = 6;
            this.btnLimparLst2.Text = "Limpar";
            this.btnLimparLst2.UseVisualStyleBackColor = true;
            this.btnLimparLst2.Click += new System.EventHandler(this.btnLimparLst2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "LIsta de cadastradas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(493, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Lista a Imprimir";
            // 
            // cboContato
            // 
            this.cboContato.FormattingEnabled = true;
            this.cboContato.Location = new System.Drawing.Point(717, 332);
            this.cboContato.Name = "cboContato";
            this.cboContato.Size = new System.Drawing.Size(147, 21);
            this.cboContato.TabIndex = 8;
            this.cboContato.SelectedIndexChanged += new System.EventHandler(this.cboContato_SelectedIndexChanged);
            // 
            // lstAImprimir
            // 
            this.lstAImprimir.FormattingEnabled = true;
            this.lstAImprimir.Location = new System.Drawing.Point(496, 177);
            this.lstAImprimir.Name = "lstAImprimir";
            this.lstAImprimir.Size = new System.Drawing.Size(205, 420);
            this.lstAImprimir.TabIndex = 5;
            this.lstAImprimir.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstAImprimir_MouseDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(717, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Selecione o Contato";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(15, 14);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 20;
            this.lblNome.Text = "Nome";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(15, 31);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(49, 13);
            this.lblTelefone.TabIndex = 21;
            this.lblTelefone.Text = "Telefone";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(15, 47);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(53, 13);
            this.lblEndereco.TabIndex = 22;
            this.lblEndereco.Text = "Endereço";
            // 
            // lblCont1
            // 
            this.lblCont1.AutoSize = true;
            this.lblCont1.Location = new System.Drawing.Point(15, 80);
            this.lblCont1.Name = "lblCont1";
            this.lblCont1.Size = new System.Drawing.Size(10, 13);
            this.lblCont1.TabIndex = 23;
            this.lblCont1.Text = "-";
            // 
            // lblCont2
            // 
            this.lblCont2.AutoSize = true;
            this.lblCont2.Location = new System.Drawing.Point(15, 93);
            this.lblCont2.Name = "lblCont2";
            this.lblCont2.Size = new System.Drawing.Size(10, 13);
            this.lblCont2.TabIndex = 24;
            this.lblCont2.Text = "-";
            // 
            // lblCont3
            // 
            this.lblCont3.AutoSize = true;
            this.lblCont3.Location = new System.Drawing.Point(15, 106);
            this.lblCont3.Name = "lblCont3";
            this.lblCont3.Size = new System.Drawing.Size(10, 13);
            this.lblCont3.TabIndex = 25;
            this.lblCont3.Text = "-";
            // 
            // lblCont4
            // 
            this.lblCont4.AutoSize = true;
            this.lblCont4.Location = new System.Drawing.Point(135, 80);
            this.lblCont4.Name = "lblCont4";
            this.lblCont4.Size = new System.Drawing.Size(10, 13);
            this.lblCont4.TabIndex = 26;
            this.lblCont4.Text = "-";
            // 
            // lblCont5
            // 
            this.lblCont5.AutoSize = true;
            this.lblCont5.Location = new System.Drawing.Point(135, 93);
            this.lblCont5.Name = "lblCont5";
            this.lblCont5.Size = new System.Drawing.Size(10, 13);
            this.lblCont5.TabIndex = 27;
            this.lblCont5.Text = "-";
            // 
            // lblCont6
            // 
            this.lblCont6.AutoSize = true;
            this.lblCont6.Location = new System.Drawing.Point(135, 106);
            this.lblCont6.Name = "lblCont6";
            this.lblCont6.Size = new System.Drawing.Size(10, 13);
            this.lblCont6.TabIndex = 28;
            this.lblCont6.Text = "-";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTelefone);
            this.groupBox2.Controls.Add(this.lblCont6);
            this.groupBox2.Controls.Add(this.lblNome);
            this.groupBox2.Controls.Add(this.lblCont5);
            this.groupBox2.Controls.Add(this.lblEndereco);
            this.groupBox2.Controls.Add(this.lblCont4);
            this.groupBox2.Controls.Add(this.lblCont1);
            this.groupBox2.Controls.Add(this.lblCont3);
            this.groupBox2.Controls.Add(this.lblCont2);
            this.groupBox2.Location = new System.Drawing.Point(28, 117);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(279, 123);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Descrição";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(893, 619);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstAImprimir);
            this.Controls.Add(this.cboContato);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLimparLst2);
            this.Controls.Add(this.btnLimparLst1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLst2ToLst1All);
            this.Controls.Add(this.btnLst2ToLst1Unit);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnLst1ToLst2Unit);
            this.Controls.Add(this.btnLst1ToLst2All);
            this.Controls.Add(this.lstPrincipal);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Impressor de Etiquetas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstPrincipal;
        private System.Windows.Forms.Button btnLst1ToLst2All;
        private System.Windows.Forms.Button btnLst1ToLst2Unit;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnLst2ToLst1Unit;
        private System.Windows.Forms.Button btnLst2ToLst1All;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoCadastroToolStripMenuItem;
        private System.Windows.Forms.Button btnLimparLst1;
        private System.Windows.Forms.Button btnLimparLst2;
        private System.Windows.Forms.ToolStripMenuItem atualizarF5ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboContato;
        private System.Windows.Forms.ListBox lstAImprimir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ToolStripMenuItem alterarF8ToolStripMenuItem;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblCont1;
        private System.Windows.Forms.Label lblCont2;
        private System.Windows.Forms.Label lblCont3;
        private System.Windows.Forms.Label lblCont4;
        private System.Windows.Forms.Label lblCont5;
        private System.Windows.Forms.Label lblCont6;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

