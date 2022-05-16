
namespace LojaDinossauro
{
    partial class frmCriarProduto
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
            this.pnlSenha = new System.Windows.Forms.Panel();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.pnlCriarProduto = new System.Windows.Forms.Panel();
            this.cmbTipoProduto = new System.Windows.Forms.ComboBox();
            this.btnCriarBrinquedo = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCriarDinossauro = new System.Windows.Forms.Button();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblTipoProduto = new System.Windows.Forms.Label();
            this.btnProcurarImagem = new System.Windows.Forms.Button();
            this.picProduto = new System.Windows.Forms.PictureBox();
            this.pnlSenha.SuspendLayout();
            this.pnlCriarProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSenha
            // 
            this.pnlSenha.Controls.Add(this.btnConfirmar);
            this.pnlSenha.Controls.Add(this.lblSenha);
            this.pnlSenha.Controls.Add(this.txtSenha);
            this.pnlSenha.Location = new System.Drawing.Point(93, 12);
            this.pnlSenha.Name = "pnlSenha";
            this.pnlSenha.Size = new System.Drawing.Size(202, 98);
            this.pnlSenha.TabIndex = 0;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(49, 57);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(114, 23);
            this.btnConfirmar.TabIndex = 2;
            this.btnConfirmar.Text = "Prosseguir";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(22, 25);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(41, 13);
            this.lblSenha.TabIndex = 1;
            this.lblSenha.Text = "Senha:";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(78, 22);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(100, 20);
            this.txtSenha.TabIndex = 0;
            // 
            // pnlCriarProduto
            // 
            this.pnlCriarProduto.Controls.Add(this.picProduto);
            this.pnlCriarProduto.Controls.Add(this.btnProcurarImagem);
            this.pnlCriarProduto.Controls.Add(this.lblTipoProduto);
            this.pnlCriarProduto.Controls.Add(this.cmbTipoProduto);
            this.pnlCriarProduto.Controls.Add(this.btnCriarBrinquedo);
            this.pnlCriarProduto.Controls.Add(this.btnVoltar);
            this.pnlCriarProduto.Controls.Add(this.btnLimpar);
            this.pnlCriarProduto.Controls.Add(this.btnCriarDinossauro);
            this.pnlCriarProduto.Controls.Add(this.lblPreco);
            this.pnlCriarProduto.Controls.Add(this.lblNome);
            this.pnlCriarProduto.Controls.Add(this.txtPreco);
            this.pnlCriarProduto.Controls.Add(this.txtNome);
            this.pnlCriarProduto.Location = new System.Drawing.Point(93, 183);
            this.pnlCriarProduto.Name = "pnlCriarProduto";
            this.pnlCriarProduto.Size = new System.Drawing.Size(353, 287);
            this.pnlCriarProduto.TabIndex = 1;
            // 
            // cmbTipoProduto
            // 
            this.cmbTipoProduto.FormattingEnabled = true;
            this.cmbTipoProduto.Location = new System.Drawing.Point(84, 122);
            this.cmbTipoProduto.Name = "cmbTipoProduto";
            this.cmbTipoProduto.Size = new System.Drawing.Size(144, 21);
            this.cmbTipoProduto.TabIndex = 12;
            // 
            // btnCriarBrinquedo
            // 
            this.btnCriarBrinquedo.Location = new System.Drawing.Point(199, 231);
            this.btnCriarBrinquedo.Name = "btnCriarBrinquedo";
            this.btnCriarBrinquedo.Size = new System.Drawing.Size(75, 23);
            this.btnCriarBrinquedo.TabIndex = 11;
            this.btnCriarBrinquedo.Text = "Criar";
            this.btnCriarBrinquedo.UseVisualStyleBackColor = true;
            this.btnCriarBrinquedo.Visible = false;
            this.btnCriarBrinquedo.Click += new System.EventHandler(this.btnCriarBrinquedo_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(37, 202);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 8;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(118, 202);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnCriarDinossauro
            // 
            this.btnCriarDinossauro.Location = new System.Drawing.Point(199, 202);
            this.btnCriarDinossauro.Name = "btnCriarDinossauro";
            this.btnCriarDinossauro.Size = new System.Drawing.Size(75, 23);
            this.btnCriarDinossauro.TabIndex = 6;
            this.btnCriarDinossauro.Text = "Criar";
            this.btnCriarDinossauro.UseVisualStyleBackColor = true;
            this.btnCriarDinossauro.Click += new System.EventHandler(this.btnCriarDinossauro_Click);
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(81, 66);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(38, 13);
            this.lblPreco.TabIndex = 5;
            this.lblPreco.Text = "Preço:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(81, 27);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "Nome:";
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(128, 63);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(100, 20);
            this.txtPreco.TabIndex = 3;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(128, 24);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 2;
            // 
            // lblTipoProduto
            // 
            this.lblTipoProduto.AutoSize = true;
            this.lblTipoProduto.Location = new System.Drawing.Point(75, 106);
            this.lblTipoProduto.Name = "lblTipoProduto";
            this.lblTipoProduto.Size = new System.Drawing.Size(171, 13);
            this.lblTipoProduto.TabIndex = 13;
            this.lblTipoProduto.Text = "Escolha qual tipo de Dinossauro é:";
            // 
            // btnProcurarImagem
            // 
            this.btnProcurarImagem.Location = new System.Drawing.Point(128, 159);
            this.btnProcurarImagem.Name = "btnProcurarImagem";
            this.btnProcurarImagem.Size = new System.Drawing.Size(100, 23);
            this.btnProcurarImagem.TabIndex = 15;
            this.btnProcurarImagem.Text = "Procure Imagem";
            this.btnProcurarImagem.UseVisualStyleBackColor = true;
            this.btnProcurarImagem.Click += new System.EventHandler(this.btnProcurarImagem_Click);
            // 
            // picProduto
            // 
            this.picProduto.Location = new System.Drawing.Point(75, 149);
            this.picProduto.Name = "picProduto";
            this.picProduto.Size = new System.Drawing.Size(37, 37);
            this.picProduto.TabIndex = 16;
            this.picProduto.TabStop = false;
            // 
            // frmCriarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 520);
            this.Controls.Add(this.pnlCriarProduto);
            this.Controls.Add(this.pnlSenha);
            this.Name = "frmCriarProduto";
            this.Text = "frmCriarProduto";
            this.pnlSenha.ResumeLayout(false);
            this.pnlSenha.PerformLayout();
            this.pnlCriarProduto.ResumeLayout(false);
            this.pnlCriarProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProduto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSenha;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Panel pnlCriarProduto;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCriarDinossauro;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnCriarBrinquedo;
        private System.Windows.Forms.ComboBox cmbTipoProduto;
        private System.Windows.Forms.Label lblTipoProduto;
        private System.Windows.Forms.Button btnProcurarImagem;
        private System.Windows.Forms.PictureBox picProduto;
    }
}