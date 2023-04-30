namespace GerenciadorDeVendas.Apresentacao
{
    partial class CadastroProdutos
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
            this.Nome = new System.Windows.Forms.Label();
            this.Desc = new System.Windows.Forms.Label();
            this.Preço = new System.Windows.Forms.Label();
            this.Qtd = new System.Windows.Forms.Label();
            this.numPreco = new System.Windows.Forms.NumericUpDown();
            this.numQtd = new System.Windows.Forms.NumericUpDown();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.txbDesc = new System.Windows.Forms.TextBox();
            this.btnConfirma = new System.Windows.Forms.Button();
            this.rbPessoaFisica = new System.Windows.Forms.RadioButton();
            this.rbPessoaJuridica = new System.Windows.Forms.RadioButton();
            this.txtCpf = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numPreco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQtd)).BeginInit();
            this.SuspendLayout();
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(209, 111);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(40, 15);
            this.Nome.TabIndex = 0;
            this.Nome.Text = "Nome";
            // 
            // Desc
            // 
            this.Desc.AutoSize = true;
            this.Desc.Location = new System.Drawing.Point(191, 157);
            this.Desc.Name = "Desc";
            this.Desc.Size = new System.Drawing.Size(58, 15);
            this.Desc.TabIndex = 1;
            this.Desc.Text = "Descrição";
            // 
            // Preço
            // 
            this.Preço.AutoSize = true;
            this.Preço.Location = new System.Drawing.Point(212, 205);
            this.Preço.Name = "Preço";
            this.Preço.Size = new System.Drawing.Size(37, 15);
            this.Preço.TabIndex = 2;
            this.Preço.Text = "Preço";
            // 
            // Qtd
            // 
            this.Qtd.AutoSize = true;
            this.Qtd.Location = new System.Drawing.Point(191, 245);
            this.Qtd.Name = "Qtd";
            this.Qtd.Size = new System.Drawing.Size(69, 15);
            this.Qtd.TabIndex = 3;
            this.Qtd.Text = "Quantidade";
            // 
            // numPreco
            // 
            this.numPreco.Location = new System.Drawing.Point(285, 205);
            this.numPreco.Maximum = new decimal(new int[] {
            9000,
            0,
            0,
            0});
            this.numPreco.Name = "numPreco";
            this.numPreco.Size = new System.Drawing.Size(120, 23);
            this.numPreco.TabIndex = 4;
            // 
            // numQtd
            // 
            this.numQtd.Location = new System.Drawing.Point(285, 245);
            this.numQtd.Maximum = new decimal(new int[] {
            90000,
            0,
            0,
            0});
            this.numQtd.Name = "numQtd";
            this.numQtd.Size = new System.Drawing.Size(120, 23);
            this.numQtd.TabIndex = 5;
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(285, 108);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(100, 23);
            this.txbNome.TabIndex = 6;
            // 
            // txbDesc
            // 
            this.txbDesc.Location = new System.Drawing.Point(285, 157);
            this.txbDesc.Name = "txbDesc";
            this.txbDesc.Size = new System.Drawing.Size(277, 23);
            this.txbDesc.TabIndex = 7;
            // 
            // btnConfirma
            // 
            this.btnConfirma.Location = new System.Drawing.Point(569, 356);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(134, 32);
            this.btnConfirma.TabIndex = 8;
            this.btnConfirma.Text = "Confirma";
            this.btnConfirma.UseVisualStyleBackColor = true;
            this.btnConfirma.Click += new System.EventHandler(this.btnConfirma_Click);
            // 
            // rbPessoaFisica
            // 
            this.rbPessoaFisica.AutoSize = true;
            this.rbPessoaFisica.Location = new System.Drawing.Point(203, 290);
            this.rbPessoaFisica.Name = "rbPessoaFisica";
            this.rbPessoaFisica.Size = new System.Drawing.Size(46, 19);
            this.rbPessoaFisica.TabIndex = 9;
            this.rbPessoaFisica.TabStop = true;
            this.rbPessoaFisica.Text = "CPF";
            this.rbPessoaFisica.UseVisualStyleBackColor = true;
            // 
            // rbPessoaJuridica
            // 
            this.rbPessoaJuridica.AutoSize = true;
            this.rbPessoaJuridica.Location = new System.Drawing.Point(285, 290);
            this.rbPessoaJuridica.Name = "rbPessoaJuridica";
            this.rbPessoaJuridica.Size = new System.Drawing.Size(52, 19);
            this.rbPessoaJuridica.TabIndex = 10;
            this.rbPessoaJuridica.TabStop = true;
            this.rbPessoaJuridica.Text = "CNPJ";
            this.rbPessoaJuridica.UseVisualStyleBackColor = true;
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(203, 324);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(146, 23);
            this.txtCpf.TabIndex = 11;
            this.txtCpf.TextChanged += new System.EventHandler(this.txtCpf_TextChanged);
            // 
            // CadastroProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.rbPessoaJuridica);
            this.Controls.Add(this.rbPessoaFisica);
            this.Controls.Add(this.btnConfirma);
            this.Controls.Add(this.txbDesc);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.numQtd);
            this.Controls.Add(this.numPreco);
            this.Controls.Add(this.Qtd);
            this.Controls.Add(this.Preço);
            this.Controls.Add(this.Desc);
            this.Controls.Add(this.Nome);
            this.Name = "CadastroProdutos";
            this.Text = "CadastroProdutos";
            this.Load += new System.EventHandler(this.CadastroProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numPreco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQtd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Nome;
        private Label Desc;
        private Label Preço;
        private Label Qtd;
        private NumericUpDown numPreco;
        private NumericUpDown numQtd;
        private TextBox txbNome;
        private TextBox txbDesc;
        private Button btnConfirma;
        private RadioButton rbPessoaFisica;
        private RadioButton rbPessoaJuridica;
        private TextBox txtCpf;
    }
}