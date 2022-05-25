
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
            this.btnRemoverTodosTipos = new System.Windows.Forms.Button();
            this.btnAddTipo = new System.Windows.Forms.Button();
            this.pnlText = new System.Windows.Forms.Panel();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.btnRemoverTipo = new System.Windows.Forms.Button();
            this.lstTipoProduto = new System.Windows.Forms.ListBox();
            this.picProduto = new System.Windows.Forms.PictureBox();
            this.btnProcurarImagem = new System.Windows.Forms.Button();
            this.lblTipoProduto = new System.Windows.Forms.Label();
            this.cmbTipoProduto = new System.Windows.Forms.ComboBox();
            this.btnCriarBrinquedo = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCriarDinossauro = new System.Windows.Forms.Button();
            this.pnlSenha.SuspendLayout();
            this.pnlCriarProduto.SuspendLayout();
            this.pnlText.SuspendLayout();
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
            this.txtSenha.PasswordChar = '●';
            this.txtSenha.Size = new System.Drawing.Size(100, 20);
            this.txtSenha.TabIndex = 0;
            // 
            // pnlCriarProduto
            // 
            this.pnlCriarProduto.Controls.Add(this.btnRemoverTodosTipos);
            this.pnlCriarProduto.Controls.Add(this.btnAddTipo);
            this.pnlCriarProduto.Controls.Add(this.pnlText);
            this.pnlCriarProduto.Controls.Add(this.btnRemoverTipo);
            this.pnlCriarProduto.Controls.Add(this.lstTipoProduto);
            this.pnlCriarProduto.Controls.Add(this.picProduto);
            this.pnlCriarProduto.Controls.Add(this.btnProcurarImagem);
            this.pnlCriarProduto.Controls.Add(this.lblTipoProduto);
            this.pnlCriarProduto.Controls.Add(this.cmbTipoProduto);
            this.pnlCriarProduto.Controls.Add(this.btnCriarBrinquedo);
            this.pnlCriarProduto.Controls.Add(this.btnVoltar);
            this.pnlCriarProduto.Controls.Add(this.btnLimpar);
            this.pnlCriarProduto.Controls.Add(this.btnCriarDinossauro);
            this.pnlCriarProduto.Location = new System.Drawing.Point(93, 183);
            this.pnlCriarProduto.Name = "pnlCriarProduto";
            this.pnlCriarProduto.Size = new System.Drawing.Size(485, 368);
            this.pnlCriarProduto.TabIndex = 1;
            // 
            // btnRemoverTodosTipos
            // 
            this.btnRemoverTodosTipos.Location = new System.Drawing.Point(378, 118);
            this.btnRemoverTodosTipos.Name = "btnRemoverTodosTipos";
            this.btnRemoverTodosTipos.Size = new System.Drawing.Size(87, 37);
            this.btnRemoverTodosTipos.TabIndex = 22;
            this.btnRemoverTodosTipos.Text = "Remover todos Tipos";
            this.btnRemoverTodosTipos.UseVisualStyleBackColor = true;
            this.btnRemoverTodosTipos.Click += new System.EventHandler(this.btnRemoverTodosTipos_Click);
            // 
            // btnAddTipo
            // 
            this.btnAddTipo.Location = new System.Drawing.Point(378, 60);
            this.btnAddTipo.Name = "btnAddTipo";
            this.btnAddTipo.Size = new System.Drawing.Size(87, 23);
            this.btnAddTipo.TabIndex = 21;
            this.btnAddTipo.Text = "Adicionar Tipo";
            this.btnAddTipo.UseVisualStyleBackColor = true;
            this.btnAddTipo.Click += new System.EventHandler(this.btnAddTipo_Click);
            // 
            // pnlText
            // 
            this.pnlText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlText.Controls.Add(this.txtDescricao);
            this.pnlText.Controls.Add(this.lblDescricao);
            this.pnlText.Controls.Add(this.txtNome);
            this.pnlText.Controls.Add(this.txtPreco);
            this.pnlText.Controls.Add(this.lblNome);
            this.pnlText.Controls.Add(this.lblPreco);
            this.pnlText.Location = new System.Drawing.Point(25, 43);
            this.pnlText.Name = "pnlText";
            this.pnlText.Size = new System.Drawing.Size(200, 238);
            this.pnlText.TabIndex = 20;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(32, 108);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(144, 115);
            this.txtDescricao.TabIndex = 7;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(29, 89);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(58, 13);
            this.lblDescricao.TabIndex = 6;
            this.lblDescricao.Text = "Descrição:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(76, 16);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 2;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(76, 55);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(100, 20);
            this.txtPreco.TabIndex = 3;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(29, 19);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "Nome:";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(29, 58);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(38, 13);
            this.lblPreco.TabIndex = 5;
            this.lblPreco.Text = "Preço:";
            // 
            // btnRemoverTipo
            // 
            this.btnRemoverTipo.Location = new System.Drawing.Point(378, 89);
            this.btnRemoverTipo.Name = "btnRemoverTipo";
            this.btnRemoverTipo.Size = new System.Drawing.Size(87, 23);
            this.btnRemoverTipo.TabIndex = 19;
            this.btnRemoverTipo.Text = "Remover Tipo";
            this.btnRemoverTipo.UseVisualStyleBackColor = true;
            this.btnRemoverTipo.Click += new System.EventHandler(this.btnRemoverTipo_Click);
            // 
            // lstTipoProduto
            // 
            this.lstTipoProduto.FormattingEnabled = true;
            this.lstTipoProduto.Location = new System.Drawing.Point(252, 60);
            this.lstTipoProduto.Name = "lstTipoProduto";
            this.lstTipoProduto.Size = new System.Drawing.Size(120, 95);
            this.lstTipoProduto.TabIndex = 18;
            // 
            // picProduto
            // 
            this.picProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picProduto.Location = new System.Drawing.Point(252, 161);
            this.picProduto.Name = "picProduto";
            this.picProduto.Size = new System.Drawing.Size(120, 120);
            this.picProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProduto.TabIndex = 17;
            this.picProduto.TabStop = false;
            // 
            // btnProcurarImagem
            // 
            this.btnProcurarImagem.Location = new System.Drawing.Point(378, 228);
            this.btnProcurarImagem.Name = "btnProcurarImagem";
            this.btnProcurarImagem.Size = new System.Drawing.Size(87, 39);
            this.btnProcurarImagem.TabIndex = 15;
            this.btnProcurarImagem.Text = "Procure Imagem";
            this.btnProcurarImagem.UseVisualStyleBackColor = true;
            this.btnProcurarImagem.Click += new System.EventHandler(this.btnProcurarImagem_Click);
            // 
            // lblTipoProduto
            // 
            this.lblTipoProduto.AutoSize = true;
            this.lblTipoProduto.Location = new System.Drawing.Point(249, 18);
            this.lblTipoProduto.Name = "lblTipoProduto";
            this.lblTipoProduto.Size = new System.Drawing.Size(171, 13);
            this.lblTipoProduto.TabIndex = 13;
            this.lblTipoProduto.Text = "Escolha qual tipo de Dinossauro é:";
            // 
            // cmbTipoProduto
            // 
            this.cmbTipoProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoProduto.FormattingEnabled = true;
            this.cmbTipoProduto.Location = new System.Drawing.Point(252, 34);
            this.cmbTipoProduto.Name = "cmbTipoProduto";
            this.cmbTipoProduto.Size = new System.Drawing.Size(144, 21);
            this.cmbTipoProduto.TabIndex = 12;
            // 
            // btnCriarBrinquedo
            // 
            this.btnCriarBrinquedo.Location = new System.Drawing.Point(147, 305);
            this.btnCriarBrinquedo.Name = "btnCriarBrinquedo";
            this.btnCriarBrinquedo.Size = new System.Drawing.Size(75, 23);
            this.btnCriarBrinquedo.TabIndex = 11;
            this.btnCriarBrinquedo.Text = "Salvar";
            this.btnCriarBrinquedo.UseVisualStyleBackColor = true;
            this.btnCriarBrinquedo.Visible = false;
            this.btnCriarBrinquedo.Click += new System.EventHandler(this.btnCriarBrinquedo_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(309, 305);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 8;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(228, 305);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCriarDinossauro
            // 
            this.btnCriarDinossauro.Location = new System.Drawing.Point(390, 305);
            this.btnCriarDinossauro.Name = "btnCriarDinossauro";
            this.btnCriarDinossauro.Size = new System.Drawing.Size(75, 23);
            this.btnCriarDinossauro.TabIndex = 6;
            this.btnCriarDinossauro.Text = "Salvar";
            this.btnCriarDinossauro.UseVisualStyleBackColor = true;
            this.btnCriarDinossauro.Click += new System.EventHandler(this.btnCriarDinossauro_Click);
            // 
            // frmCriarProduto
            // 
            this.AcceptButton = this.btnConfirmar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 591);
            this.Controls.Add(this.pnlCriarProduto);
            this.Controls.Add(this.pnlSenha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmCriarProduto";
            this.Text = "frmCriarProduto";
            this.pnlSenha.ResumeLayout(false);
            this.pnlSenha.PerformLayout();
            this.pnlCriarProduto.ResumeLayout(false);
            this.pnlCriarProduto.PerformLayout();
            this.pnlText.ResumeLayout(false);
            this.pnlText.PerformLayout();
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
        private System.Windows.Forms.ListBox lstTipoProduto;
        private System.Windows.Forms.Panel pnlText;
        private System.Windows.Forms.Button btnRemoverTipo;
        private System.Windows.Forms.Button btnAddTipo;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Button btnRemoverTodosTipos;
    }
}