namespace GerenciadorDeVendas.Apresentacao
{
    partial class EditarProduto
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.txbDesc = new System.Windows.Forms.TextBox();
            this.numPreco = new System.Windows.Forms.NumericUpDown();
            this.numQtd = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numPreco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQtd)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(521, 299);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(115, 38);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(127, 299);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(115, 38);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(127, 75);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(100, 23);
            this.txbNome.TabIndex = 2;
            // 
            // txbDesc
            // 
            this.txbDesc.Location = new System.Drawing.Point(127, 174);
            this.txbDesc.Name = "txbDesc";
            this.txbDesc.Size = new System.Drawing.Size(100, 23);
            this.txbDesc.TabIndex = 3;
            // 
            // numPreco
            // 
            this.numPreco.Location = new System.Drawing.Point(127, 123);
            this.numPreco.Name = "numPreco";
            this.numPreco.Size = new System.Drawing.Size(120, 23);
            this.numPreco.TabIndex = 4;
            // 
            // numQtd
            // 
            this.numQtd.Location = new System.Drawing.Point(127, 223);
            this.numQtd.Name = "numQtd";
            this.numQtd.Size = new System.Drawing.Size(120, 23);
            this.numQtd.TabIndex = 5;
            // 
            // EditarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numQtd);
            this.Controls.Add(this.numPreco);
            this.Controls.Add(this.txbDesc);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Name = "EditarProduto";
            this.Text = "EditarProduto";
            ((System.ComponentModel.ISupportInitialize)(this.numPreco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQtd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSalvar;
        private Button btnCancelar;
        private TextBox txbNome;
        private TextBox txbDesc;
        private NumericUpDown numPreco;
        private NumericUpDown numQtd;
    }
}