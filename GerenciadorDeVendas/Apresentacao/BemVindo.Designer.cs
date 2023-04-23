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
            // BemVindo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblBemVindo);
            this.Name = "BemVindo";
            this.Text = "BemVindo";
            this.Load += new System.EventHandler(this.BemVindo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblBemVindo;
    }
}