
namespace LojaDinossauro
{
    partial class frmInfoProduto
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
            this.picImageProduto = new System.Windows.Forms.PictureBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picImageProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // picImageProduto
            // 
            this.picImageProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picImageProduto.Location = new System.Drawing.Point(40, 25);
            this.picImageProduto.Name = "picImageProduto";
            this.picImageProduto.Size = new System.Drawing.Size(225, 225);
            this.picImageProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImageProduto.TabIndex = 0;
            this.picImageProduto.TabStop = false;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(310, 25);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.ReadOnly = true;
            this.txtDescricao.Size = new System.Drawing.Size(389, 130);
            this.txtDescricao.TabIndex = 1;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(435, 200);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(167, 23);
            this.btnVoltar.TabIndex = 2;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // frmInfoProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 274);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.picImageProduto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmInfoProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmInfoProduto";
            ((System.ComponentModel.ISupportInitialize)(this.picImageProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picImageProduto;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Button btnVoltar;
    }
}