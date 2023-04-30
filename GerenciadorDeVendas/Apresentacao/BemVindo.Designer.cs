namespace GerenciadorDeVendas.Apresentacao
{
    partial class BemVindo
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
            this.lblBemVindo = new System.Windows.Forms.Label();
            this.btnCadastroProdutos = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.btnCadastroCliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBemVindo
            // 
            this.lblBemVindo.AutoSize = true;
            this.lblBemVindo.Location = new System.Drawing.Point(108, 69);
            this.lblBemVindo.Name = "lblBemVindo";
            this.lblBemVindo.Size = new System.Drawing.Size(0, 15);
            this.lblBemVindo.TabIndex = 0;
            this.lblBemVindo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblBemVindo.Click += new System.EventHandler(this.lblBemVindo_Click);
            // 
            // btnCadastroProdutos
            // 
            this.btnCadastroProdutos.Location = new System.Drawing.Point(289, 154);
            this.btnCadastroProdutos.Name = "btnCadastroProdutos";
            this.btnCadastroProdutos.Size = new System.Drawing.Size(161, 24);
            this.btnCadastroProdutos.TabIndex = 1;
            this.btnCadastroProdutos.Text = "Cadastrar um Produto";
            this.btnCadastroProdutos.UseVisualStyleBackColor = true;
            this.btnCadastroProdutos.Click += new System.EventHandler(this.btnCadastroProdutos_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(289, 211);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(161, 24);
            this.btnListar.TabIndex = 2;
            this.btnListar.Text = "Listar Produtos";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.Location = new System.Drawing.Point(289, 262);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(161, 23);
            this.btnRelatorio.TabIndex = 3;
            this.btnRelatorio.Text = "Relatorio de Vendas";
            this.btnRelatorio.UseVisualStyleBackColor = true;
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
            // 
            // btnCadastroCliente
            // 
            this.btnCadastroCliente.Location = new System.Drawing.Point(289, 102);
            this.btnCadastroCliente.Name = "btnCadastroCliente";
            this.btnCadastroCliente.Size = new System.Drawing.Size(161, 23);
            this.btnCadastroCliente.TabIndex = 4;
            this.btnCadastroCliente.Text = "Cadastrar Clientes";
            this.btnCadastroCliente.UseVisualStyleBackColor = true;
            this.btnCadastroCliente.Click += new System.EventHandler(this.btnCadastroCliente_Click);
            // 
            // BemVindo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCadastroCliente);
            this.Controls.Add(this.btnRelatorio);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnCadastroProdutos);
            this.Controls.Add(this.lblBemVindo);
            this.Name = "BemVindo";
            this.Text = "BemVindo";
            this.Load += new System.EventHandler(this.BemVindo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblBemVindo;
        private Button btnCadastroProdutos;
        private Button btnListar;
        private Button btnRelatorio;
        private Button btnCadastroCliente;
    }
}