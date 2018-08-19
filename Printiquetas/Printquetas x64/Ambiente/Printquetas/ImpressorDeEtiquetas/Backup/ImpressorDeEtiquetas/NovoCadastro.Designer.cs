namespace ImpressorDeEtiquetas
{
    partial class NovoCadastro
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
            this.btnOk = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtContato1 = new System.Windows.Forms.TextBox();
            this.txtContato2 = new System.Windows.Forms.TextBox();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtContato6 = new System.Windows.Forms.TextBox();
            this.txtContato5 = new System.Windows.Forms.TextBox();
            this.txtContato4 = new System.Windows.Forms.TextBox();
            this.txtContato3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.lblTelefones = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(518, 363);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(82, 36);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "Cadastrar";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(33, 29);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(213, 20);
            this.txtNome.TabIndex = 0;
            // 
            // txtContato1
            // 
            this.txtContato1.Location = new System.Drawing.Point(17, 22);
            this.txtContato1.Name = "txtContato1";
            this.txtContato1.Size = new System.Drawing.Size(161, 20);
            this.txtContato1.TabIndex = 0;
            // 
            // txtContato2
            // 
            this.txtContato2.Location = new System.Drawing.Point(17, 58);
            this.txtContato2.Name = "txtContato2";
            this.txtContato2.Size = new System.Drawing.Size(161, 20);
            this.txtContato2.TabIndex = 1;
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(6, 38);
            this.txtRua.MaxLength = 100;
            this.txtRua.Multiline = true;
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(219, 37);
            this.txtRua.TabIndex = 0;
            this.txtRua.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtContato6);
            this.groupBox1.Controls.Add(this.txtContato5);
            this.groupBox1.Controls.Add(this.txtContato4);
            this.groupBox1.Controls.Add(this.txtContato3);
            this.groupBox1.Controls.Add(this.txtContato2);
            this.groupBox1.Controls.Add(this.txtContato1);
            this.groupBox1.Location = new System.Drawing.Point(312, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 239);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nome dos Contatos";
            // 
            // txtContato6
            // 
            this.txtContato6.Location = new System.Drawing.Point(17, 204);
            this.txtContato6.Name = "txtContato6";
            this.txtContato6.Size = new System.Drawing.Size(161, 20);
            this.txtContato6.TabIndex = 5;
            // 
            // txtContato5
            // 
            this.txtContato5.Location = new System.Drawing.Point(17, 171);
            this.txtContato5.Name = "txtContato5";
            this.txtContato5.Size = new System.Drawing.Size(161, 20);
            this.txtContato5.TabIndex = 4;
            // 
            // txtContato4
            // 
            this.txtContato4.Location = new System.Drawing.Point(17, 135);
            this.txtContato4.Name = "txtContato4";
            this.txtContato4.Size = new System.Drawing.Size(161, 20);
            this.txtContato4.TabIndex = 3;
            // 
            // txtContato3
            // 
            this.txtContato3.Location = new System.Drawing.Point(17, 96);
            this.txtContato3.Name = "txtContato3";
            this.txtContato3.Size = new System.Drawing.Size(161, 20);
            this.txtContato3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Rua e Numero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nome Empresa";
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(57, 154);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(79, 20);
            this.txtCep.TabIndex = 3;
            this.txtCep.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(6, 111);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(130, 20);
            this.txtCidade.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtUF);
            this.groupBox2.Controls.Add(this.txtRua);
            this.groupBox2.Controls.Add(this.txtCidade);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtCep);
            this.groupBox2.Location = new System.Drawing.Point(33, 192);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(231, 183);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Endereço";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Cep";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Cidade";
            // 
            // txtUF
            // 
            this.txtUF.Location = new System.Drawing.Point(181, 111);
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(32, 20);
            this.txtUF.TabIndex = 2;
            this.txtUF.TextChanged += new System.EventHandler(this.textBox11_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(217, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "UF";
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(428, 363);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(84, 36);
            this.btnAlterar.TabIndex = 4;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(347, 363);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(75, 36);
            this.btnDeletar.TabIndex = 5;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // lblTelefones
            // 
            this.lblTelefones.AutoSize = true;
            this.lblTelefones.Location = new System.Drawing.Point(33, 94);
            this.lblTelefones.Name = "lblTelefones";
            this.lblTelefones.Size = new System.Drawing.Size(54, 13);
            this.lblTelefones.TabIndex = 15;
            this.lblTelefones.Text = "Telefones";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(33, 110);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(213, 20);
            this.txtTelefone.TabIndex = 16;
            // 
            // NovoCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(645, 436);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.lblTelefones);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnOk);
            this.Name = "NovoCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NovoCadastro";
            this.Load += new System.EventHandler(this.NovoCadastro_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtContato1;
        private System.Windows.Forms.TextBox txtContato2;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtContato6;
        private System.Windows.Forms.TextBox txtContato5;
        private System.Windows.Forms.TextBox txtContato4;
        private System.Windows.Forms.TextBox txtContato3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUF;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Label lblTelefones;
        private System.Windows.Forms.TextBox txtTelefone;
    }
}