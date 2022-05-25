
namespace LojaDinossauro
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCriarDinossauro = new System.Windows.Forms.Button();
            this.chkCarnivoro = new System.Windows.Forms.CheckBox();
            this.chkHerbivoro = new System.Windows.Forms.CheckBox();
            this.chkBipede = new System.Windows.Forms.CheckBox();
            this.chkQuadrupede = new System.Windows.Forms.CheckBox();
            this.tabLoja = new System.Windows.Forms.TabControl();
            this.tpDinossauros = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tpBrinquedos = new System.Windows.Forms.TabPage();
            this.btnCriarBrinquedo = new System.Windows.Forms.Button();
            this.tpCarrinho = new System.Windows.Forms.TabPage();
            this.lblPrecoTotal = new System.Windows.Forms.Label();
            this.rdoIrmao = new System.Windows.Forms.RadioButton();
            this.rdoRins = new System.Windows.Forms.RadioButton();
            this.rdoDebito = new System.Windows.Forms.RadioButton();
            this.rdoCredito = new System.Windows.Forms.RadioButton();
            this.lblFormaPagamento = new System.Windows.Forms.Label();
            this.btnComprarCarrinho = new System.Windows.Forms.Button();
            this.lvwPedido = new System.Windows.Forms.ListView();
            this.chNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPreco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpFiltrosDinossauros = new System.Windows.Forms.GroupBox();
            this.chkVoador = new System.Windows.Forms.CheckBox();
            this.chkAquatico = new System.Windows.Forms.CheckBox();
            this.chkEspinhos = new System.Windows.Forms.CheckBox();
            this.grpFiltrosBrinquedos = new System.Windows.Forms.GroupBox();
            this.tabLoja.SuspendLayout();
            this.tpDinossauros.SuspendLayout();
            this.tpBrinquedos.SuspendLayout();
            this.tpCarrinho.SuspendLayout();
            this.grpFiltrosDinossauros.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCriarDinossauro
            // 
            this.btnCriarDinossauro.Location = new System.Drawing.Point(17, 10);
            this.btnCriarDinossauro.Name = "btnCriarDinossauro";
            this.btnCriarDinossauro.Size = new System.Drawing.Size(75, 23);
            this.btnCriarDinossauro.TabIndex = 3;
            this.btnCriarDinossauro.Text = "Criar";
            this.btnCriarDinossauro.UseVisualStyleBackColor = true;
            this.btnCriarDinossauro.Click += new System.EventHandler(this.btnCriarDinossauro_Click);
            // 
            // chkCarnivoro
            // 
            this.chkCarnivoro.AutoSize = true;
            this.chkCarnivoro.Location = new System.Drawing.Point(27, 36);
            this.chkCarnivoro.Name = "chkCarnivoro";
            this.chkCarnivoro.Size = new System.Drawing.Size(71, 17);
            this.chkCarnivoro.TabIndex = 11;
            this.chkCarnivoro.Text = "Carnivoro";
            this.chkCarnivoro.UseVisualStyleBackColor = true;
            this.chkCarnivoro.CheckedChanged += new System.EventHandler(this.chkCarnivoro_CheckedChanged);
            // 
            // chkHerbivoro
            // 
            this.chkHerbivoro.AutoSize = true;
            this.chkHerbivoro.Location = new System.Drawing.Point(27, 59);
            this.chkHerbivoro.Name = "chkHerbivoro";
            this.chkHerbivoro.Size = new System.Drawing.Size(72, 17);
            this.chkHerbivoro.TabIndex = 12;
            this.chkHerbivoro.Text = "Herbivoro";
            this.chkHerbivoro.UseVisualStyleBackColor = true;
            this.chkHerbivoro.CheckedChanged += new System.EventHandler(this.chkHerbivoro_CheckedChanged);
            // 
            // chkBipede
            // 
            this.chkBipede.AutoSize = true;
            this.chkBipede.Location = new System.Drawing.Point(27, 82);
            this.chkBipede.Name = "chkBipede";
            this.chkBipede.Size = new System.Drawing.Size(59, 17);
            this.chkBipede.TabIndex = 13;
            this.chkBipede.Text = "Bipede";
            this.chkBipede.UseVisualStyleBackColor = true;
            // 
            // chkQuadrupede
            // 
            this.chkQuadrupede.AutoSize = true;
            this.chkQuadrupede.Location = new System.Drawing.Point(27, 105);
            this.chkQuadrupede.Name = "chkQuadrupede";
            this.chkQuadrupede.Size = new System.Drawing.Size(85, 17);
            this.chkQuadrupede.TabIndex = 14;
            this.chkQuadrupede.Text = "Quadrupede";
            this.chkQuadrupede.UseVisualStyleBackColor = true;
            this.chkQuadrupede.CheckedChanged += new System.EventHandler(this.chkQuadrupede_CheckedChanged);
            // 
            // tabLoja
            // 
            this.tabLoja.Controls.Add(this.tpDinossauros);
            this.tabLoja.Controls.Add(this.tpBrinquedos);
            this.tabLoja.Controls.Add(this.tpCarrinho);
            this.tabLoja.Location = new System.Drawing.Point(259, 25);
            this.tabLoja.Name = "tabLoja";
            this.tabLoja.SelectedIndex = 0;
            this.tabLoja.Size = new System.Drawing.Size(525, 320);
            this.tabLoja.TabIndex = 0;
            // 
            // tpDinossauros
            // 
            this.tpDinossauros.AutoScroll = true;
            this.tpDinossauros.Controls.Add(this.label2);
            this.tpDinossauros.Controls.Add(this.label1);
            this.tpDinossauros.Controls.Add(this.button2);
            this.tpDinossauros.Controls.Add(this.button1);
            this.tpDinossauros.Controls.Add(this.btnCriarDinossauro);
            this.tpDinossauros.Location = new System.Drawing.Point(4, 22);
            this.tpDinossauros.Name = "tpDinossauros";
            this.tpDinossauros.Padding = new System.Windows.Forms.Padding(3);
            this.tpDinossauros.Size = new System.Drawing.Size(517, 294);
            this.tpDinossauros.TabIndex = 0;
            this.tpDinossauros.Text = "Dinossauros";
            this.tpDinossauros.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 61);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(342, 56);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(423, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // tpBrinquedos
            // 
            this.tpBrinquedos.AutoScroll = true;
            this.tpBrinquedos.Controls.Add(this.btnCriarBrinquedo);
            this.tpBrinquedos.Location = new System.Drawing.Point(4, 22);
            this.tpBrinquedos.Name = "tpBrinquedos";
            this.tpBrinquedos.Padding = new System.Windows.Forms.Padding(3);
            this.tpBrinquedos.Size = new System.Drawing.Size(517, 294);
            this.tpBrinquedos.TabIndex = 1;
            this.tpBrinquedos.Text = "Brinquedos";
            this.tpBrinquedos.UseVisualStyleBackColor = true;
            // 
            // btnCriarBrinquedo
            // 
            this.btnCriarBrinquedo.Location = new System.Drawing.Point(17, 10);
            this.btnCriarBrinquedo.Name = "btnCriarBrinquedo";
            this.btnCriarBrinquedo.Size = new System.Drawing.Size(75, 23);
            this.btnCriarBrinquedo.TabIndex = 0;
            this.btnCriarBrinquedo.Text = "Criar";
            this.btnCriarBrinquedo.UseVisualStyleBackColor = true;
            this.btnCriarBrinquedo.Click += new System.EventHandler(this.btnCriarBrinquedo_Click);
            // 
            // tpCarrinho
            // 
            this.tpCarrinho.Controls.Add(this.lblPrecoTotal);
            this.tpCarrinho.Controls.Add(this.rdoIrmao);
            this.tpCarrinho.Controls.Add(this.rdoRins);
            this.tpCarrinho.Controls.Add(this.rdoDebito);
            this.tpCarrinho.Controls.Add(this.rdoCredito);
            this.tpCarrinho.Controls.Add(this.lblFormaPagamento);
            this.tpCarrinho.Controls.Add(this.btnComprarCarrinho);
            this.tpCarrinho.Controls.Add(this.lvwPedido);
            this.tpCarrinho.Location = new System.Drawing.Point(4, 22);
            this.tpCarrinho.Name = "tpCarrinho";
            this.tpCarrinho.Size = new System.Drawing.Size(517, 294);
            this.tpCarrinho.TabIndex = 2;
            this.tpCarrinho.Text = "Carrinho";
            this.tpCarrinho.UseVisualStyleBackColor = true;
            // 
            // lblPrecoTotal
            // 
            this.lblPrecoTotal.AutoSize = true;
            this.lblPrecoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoTotal.Location = new System.Drawing.Point(15, 30);
            this.lblPrecoTotal.Name = "lblPrecoTotal";
            this.lblPrecoTotal.Size = new System.Drawing.Size(61, 24);
            this.lblPrecoTotal.TabIndex = 7;
            this.lblPrecoTotal.Text = "Total: ";
            // 
            // rdoIrmao
            // 
            this.rdoIrmao.AutoSize = true;
            this.rdoIrmao.Location = new System.Drawing.Point(109, 132);
            this.rdoIrmao.Name = "rdoIrmao";
            this.rdoIrmao.Size = new System.Drawing.Size(51, 17);
            this.rdoIrmao.TabIndex = 6;
            this.rdoIrmao.TabStop = true;
            this.rdoIrmao.Text = "Irmão";
            this.rdoIrmao.UseVisualStyleBackColor = true;
            // 
            // rdoRins
            // 
            this.rdoRins.AutoSize = true;
            this.rdoRins.Location = new System.Drawing.Point(18, 132);
            this.rdoRins.Name = "rdoRins";
            this.rdoRins.Size = new System.Drawing.Size(62, 17);
            this.rdoRins.TabIndex = 5;
            this.rdoRins.TabStop = true;
            this.rdoRins.Text = "Um Rim";
            this.rdoRins.UseVisualStyleBackColor = true;
            // 
            // rdoDebito
            // 
            this.rdoDebito.AutoSize = true;
            this.rdoDebito.Location = new System.Drawing.Point(109, 108);
            this.rdoDebito.Name = "rdoDebito";
            this.rdoDebito.Size = new System.Drawing.Size(56, 17);
            this.rdoDebito.TabIndex = 4;
            this.rdoDebito.TabStop = true;
            this.rdoDebito.Text = "Débito";
            this.rdoDebito.UseVisualStyleBackColor = true;
            // 
            // rdoCredito
            // 
            this.rdoCredito.AutoSize = true;
            this.rdoCredito.Location = new System.Drawing.Point(18, 109);
            this.rdoCredito.Name = "rdoCredito";
            this.rdoCredito.Size = new System.Drawing.Size(58, 17);
            this.rdoCredito.TabIndex = 3;
            this.rdoCredito.TabStop = true;
            this.rdoCredito.Text = "Crédito";
            this.rdoCredito.UseVisualStyleBackColor = true;
            // 
            // lblFormaPagamento
            // 
            this.lblFormaPagamento.AutoSize = true;
            this.lblFormaPagamento.Location = new System.Drawing.Point(25, 83);
            this.lblFormaPagamento.Name = "lblFormaPagamento";
            this.lblFormaPagamento.Size = new System.Drawing.Size(160, 13);
            this.lblFormaPagamento.TabIndex = 2;
            this.lblFormaPagamento.Text = "Ecolha sua forma de pagamento";
            // 
            // btnComprarCarrinho
            // 
            this.btnComprarCarrinho.Location = new System.Drawing.Point(28, 187);
            this.btnComprarCarrinho.Name = "btnComprarCarrinho";
            this.btnComprarCarrinho.Size = new System.Drawing.Size(161, 23);
            this.btnComprarCarrinho.TabIndex = 1;
            this.btnComprarCarrinho.Text = "Comprar";
            this.btnComprarCarrinho.UseVisualStyleBackColor = true;
            this.btnComprarCarrinho.Click += new System.EventHandler(this.btnComprarCarrinho_Click);
            // 
            // lvwPedido
            // 
            this.lvwPedido.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chNome,
            this.chPreco});
            this.lvwPedido.HideSelection = false;
            this.lvwPedido.Location = new System.Drawing.Point(233, 3);
            this.lvwPedido.Name = "lvwPedido";
            this.lvwPedido.Size = new System.Drawing.Size(276, 288);
            this.lvwPedido.TabIndex = 0;
            this.lvwPedido.UseCompatibleStateImageBehavior = false;
            this.lvwPedido.View = System.Windows.Forms.View.Details;
            // 
            // chNome
            // 
            this.chNome.Text = "Nome";
            // 
            // chPreco
            // 
            this.chPreco.Text = "Preço";
            // 
            // grpFiltrosDinossauros
            // 
            this.grpFiltrosDinossauros.Controls.Add(this.chkVoador);
            this.grpFiltrosDinossauros.Controls.Add(this.chkAquatico);
            this.grpFiltrosDinossauros.Controls.Add(this.chkEspinhos);
            this.grpFiltrosDinossauros.Controls.Add(this.chkCarnivoro);
            this.grpFiltrosDinossauros.Controls.Add(this.chkHerbivoro);
            this.grpFiltrosDinossauros.Controls.Add(this.chkBipede);
            this.grpFiltrosDinossauros.Controls.Add(this.chkQuadrupede);
            this.grpFiltrosDinossauros.Location = new System.Drawing.Point(12, 25);
            this.grpFiltrosDinossauros.Name = "grpFiltrosDinossauros";
            this.grpFiltrosDinossauros.Size = new System.Drawing.Size(241, 159);
            this.grpFiltrosDinossauros.TabIndex = 21;
            this.grpFiltrosDinossauros.TabStop = false;
            this.grpFiltrosDinossauros.Text = "Filtros";
            // 
            // chkVoador
            // 
            this.chkVoador.AutoSize = true;
            this.chkVoador.Location = new System.Drawing.Point(133, 82);
            this.chkVoador.Name = "chkVoador";
            this.chkVoador.Size = new System.Drawing.Size(60, 17);
            this.chkVoador.TabIndex = 17;
            this.chkVoador.Text = "Voador";
            this.chkVoador.UseVisualStyleBackColor = true;
            this.chkVoador.CheckedChanged += new System.EventHandler(this.chkVoador_CheckedChanged);
            // 
            // chkAquatico
            // 
            this.chkAquatico.AutoSize = true;
            this.chkAquatico.Location = new System.Drawing.Point(133, 59);
            this.chkAquatico.Name = "chkAquatico";
            this.chkAquatico.Size = new System.Drawing.Size(68, 17);
            this.chkAquatico.TabIndex = 16;
            this.chkAquatico.Text = "Aquatico";
            this.chkAquatico.UseVisualStyleBackColor = true;
            this.chkAquatico.CheckedChanged += new System.EventHandler(this.chkAquatico_CheckedChanged);
            // 
            // chkEspinhos
            // 
            this.chkEspinhos.AutoSize = true;
            this.chkEspinhos.Location = new System.Drawing.Point(133, 36);
            this.chkEspinhos.Name = "chkEspinhos";
            this.chkEspinhos.Size = new System.Drawing.Size(69, 17);
            this.chkEspinhos.TabIndex = 15;
            this.chkEspinhos.Text = "Espinhos";
            this.chkEspinhos.UseVisualStyleBackColor = true;
            this.chkEspinhos.CheckedChanged += new System.EventHandler(this.chkEspinhos_CheckedChanged);
            // 
            // grpFiltrosBrinquedos
            // 
            this.grpFiltrosBrinquedos.Location = new System.Drawing.Point(16, 190);
            this.grpFiltrosBrinquedos.Name = "grpFiltrosBrinquedos";
            this.grpFiltrosBrinquedos.Size = new System.Drawing.Size(241, 159);
            this.grpFiltrosBrinquedos.TabIndex = 19;
            this.grpFiltrosBrinquedos.TabStop = false;
            this.grpFiltrosBrinquedos.Text = "Brinquedos";
            this.grpFiltrosBrinquedos.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(796, 357);
            this.Controls.Add(this.grpFiltrosBrinquedos);
            this.Controls.Add(this.grpFiltrosDinossauros);
            this.Controls.Add(this.tabLoja);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.tabLoja.ResumeLayout(false);
            this.tpDinossauros.ResumeLayout(false);
            this.tpDinossauros.PerformLayout();
            this.tpBrinquedos.ResumeLayout(false);
            this.tpCarrinho.ResumeLayout(false);
            this.tpCarrinho.PerformLayout();
            this.grpFiltrosDinossauros.ResumeLayout(false);
            this.grpFiltrosDinossauros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCriarDinossauro;
        private System.Windows.Forms.CheckBox chkCarnivoro;
        private System.Windows.Forms.CheckBox chkHerbivoro;
        private System.Windows.Forms.CheckBox chkBipede;
        private System.Windows.Forms.CheckBox chkQuadrupede;
        private System.Windows.Forms.TabControl tabLoja;
        private System.Windows.Forms.TabPage tpDinossauros;
        private System.Windows.Forms.TabPage tpBrinquedos;
        private System.Windows.Forms.TabPage tpCarrinho;
        private System.Windows.Forms.GroupBox grpFiltrosDinossauros;
        private System.Windows.Forms.GroupBox grpFiltrosBrinquedos;
        private System.Windows.Forms.Button btnCriarBrinquedo;
        private System.Windows.Forms.CheckBox chkEspinhos;
        private System.Windows.Forms.CheckBox chkVoador;
        private System.Windows.Forms.CheckBox chkAquatico;
        private System.Windows.Forms.ListView lvwPedido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblPrecoTotal;
        private System.Windows.Forms.RadioButton rdoIrmao;
        private System.Windows.Forms.RadioButton rdoRins;
        private System.Windows.Forms.RadioButton rdoDebito;
        private System.Windows.Forms.RadioButton rdoCredito;
        private System.Windows.Forms.Label lblFormaPagamento;
        private System.Windows.Forms.Button btnComprarCarrinho;
        private System.Windows.Forms.ColumnHeader chNome;
        private System.Windows.Forms.ColumnHeader chPreco;
    }
}

