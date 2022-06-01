
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
            this.grpFiltros = new System.Windows.Forms.GroupBox();
            this.btnAplicarFiltro = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tabLoja.SuspendLayout();
            this.tpDinossauros.SuspendLayout();
            this.tpBrinquedos.SuspendLayout();
            this.tpCarrinho.SuspendLayout();
            this.grpFiltrosDinossauros.SuspendLayout();
            this.grpFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.chkCarnivoro.Location = new System.Drawing.Point(24, 26);
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
            this.chkHerbivoro.Location = new System.Drawing.Point(24, 49);
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
            this.chkBipede.Location = new System.Drawing.Point(24, 72);
            this.chkBipede.Name = "chkBipede";
            this.chkBipede.Size = new System.Drawing.Size(59, 17);
            this.chkBipede.TabIndex = 13;
            this.chkBipede.Text = "Bipede";
            this.chkBipede.UseVisualStyleBackColor = true;
            // 
            // chkQuadrupede
            // 
            this.chkQuadrupede.AutoSize = true;
            this.chkQuadrupede.Location = new System.Drawing.Point(24, 95);
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
            this.tabLoja.Location = new System.Drawing.Point(259, 12);
            this.tabLoja.Name = "tabLoja";
            this.tabLoja.SelectedIndex = 0;
            this.tabLoja.Size = new System.Drawing.Size(576, 558);
            this.tabLoja.TabIndex = 0;
            // 
            // tpDinossauros
            // 
            this.tpDinossauros.AutoScroll = true;
            this.tpDinossauros.Controls.Add(this.button3);
            this.tpDinossauros.Controls.Add(this.button4);
            this.tpDinossauros.Controls.Add(this.label4);
            this.tpDinossauros.Controls.Add(this.label3);
            this.tpDinossauros.Controls.Add(this.pictureBox2);
            this.tpDinossauros.Controls.Add(this.pictureBox1);
            this.tpDinossauros.Controls.Add(this.button2);
            this.tpDinossauros.Controls.Add(this.button1);
            this.tpDinossauros.Controls.Add(this.label2);
            this.tpDinossauros.Controls.Add(this.label1);
            this.tpDinossauros.Controls.Add(this.btnCriarDinossauro);
            this.tpDinossauros.Location = new System.Drawing.Point(4, 22);
            this.tpDinossauros.Name = "tpDinossauros";
            this.tpDinossauros.Padding = new System.Windows.Forms.Padding(3);
            this.tpDinossauros.Size = new System.Drawing.Size(568, 532);
            this.tpDinossauros.TabIndex = 0;
            this.tpDinossauros.Text = "Dinossauros";
            this.tpDinossauros.UseVisualStyleBackColor = true;
            // 
            // tpBrinquedos
            // 
            this.tpBrinquedos.AutoScroll = true;
            this.tpBrinquedos.Controls.Add(this.btnCriarBrinquedo);
            this.tpBrinquedos.Location = new System.Drawing.Point(4, 22);
            this.tpBrinquedos.Name = "tpBrinquedos";
            this.tpBrinquedos.Padding = new System.Windows.Forms.Padding(3);
            this.tpBrinquedos.Size = new System.Drawing.Size(513, 532);
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
            this.tpCarrinho.Size = new System.Drawing.Size(513, 532);
            this.tpCarrinho.TabIndex = 2;
            this.tpCarrinho.Text = "Carrinho";
            this.tpCarrinho.UseVisualStyleBackColor = true;
            // 
            // lblPrecoTotal
            // 
            this.lblPrecoTotal.AutoSize = true;
            this.lblPrecoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoTotal.Location = new System.Drawing.Point(74, 45);
            this.lblPrecoTotal.Name = "lblPrecoTotal";
            this.lblPrecoTotal.Size = new System.Drawing.Size(61, 24);
            this.lblPrecoTotal.TabIndex = 7;
            this.lblPrecoTotal.Text = "Total: ";
            // 
            // rdoIrmao
            // 
            this.rdoIrmao.AutoSize = true;
            this.rdoIrmao.Location = new System.Drawing.Point(171, 135);
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
            this.rdoRins.Location = new System.Drawing.Point(80, 135);
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
            this.rdoDebito.Location = new System.Drawing.Point(171, 111);
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
            this.rdoCredito.Location = new System.Drawing.Point(80, 112);
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
            this.lblFormaPagamento.Location = new System.Drawing.Point(75, 86);
            this.lblFormaPagamento.Name = "lblFormaPagamento";
            this.lblFormaPagamento.Size = new System.Drawing.Size(160, 13);
            this.lblFormaPagamento.TabIndex = 2;
            this.lblFormaPagamento.Text = "Ecolha sua forma de pagamento";
            // 
            // btnComprarCarrinho
            // 
            this.btnComprarCarrinho.Location = new System.Drawing.Point(283, 108);
            this.btnComprarCarrinho.Name = "btnComprarCarrinho";
            this.btnComprarCarrinho.Size = new System.Drawing.Size(161, 47);
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
            this.lvwPedido.Location = new System.Drawing.Point(3, 215);
            this.lvwPedido.Name = "lvwPedido";
            this.lvwPedido.Size = new System.Drawing.Size(505, 314);
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
            this.grpFiltrosDinossauros.Location = new System.Drawing.Point(10, 35);
            this.grpFiltrosDinossauros.Name = "grpFiltrosDinossauros";
            this.grpFiltrosDinossauros.Size = new System.Drawing.Size(219, 219);
            this.grpFiltrosDinossauros.TabIndex = 21;
            this.grpFiltrosDinossauros.TabStop = false;
            this.grpFiltrosDinossauros.Text = "Filtro Dinossauros";
            // 
            // chkVoador
            // 
            this.chkVoador.AutoSize = true;
            this.chkVoador.Location = new System.Drawing.Point(130, 72);
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
            this.chkAquatico.Location = new System.Drawing.Point(130, 49);
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
            this.chkEspinhos.Location = new System.Drawing.Point(130, 26);
            this.chkEspinhos.Name = "chkEspinhos";
            this.chkEspinhos.Size = new System.Drawing.Size(69, 17);
            this.chkEspinhos.TabIndex = 15;
            this.chkEspinhos.Text = "Espinhos";
            this.chkEspinhos.UseVisualStyleBackColor = true;
            this.chkEspinhos.CheckedChanged += new System.EventHandler(this.chkEspinhos_CheckedChanged);
            // 
            // grpFiltrosBrinquedos
            // 
            this.grpFiltrosBrinquedos.Location = new System.Drawing.Point(10, 260);
            this.grpFiltrosBrinquedos.Name = "grpFiltrosBrinquedos";
            this.grpFiltrosBrinquedos.Size = new System.Drawing.Size(219, 219);
            this.grpFiltrosBrinquedos.TabIndex = 19;
            this.grpFiltrosBrinquedos.TabStop = false;
            this.grpFiltrosBrinquedos.Text = "Filtro Brinquedos";
            this.grpFiltrosBrinquedos.Visible = false;
            // 
            // grpFiltros
            // 
            this.grpFiltros.Controls.Add(this.btnAplicarFiltro);
            this.grpFiltros.Controls.Add(this.grpFiltrosDinossauros);
            this.grpFiltros.Controls.Add(this.grpFiltrosBrinquedos);
            this.grpFiltros.Location = new System.Drawing.Point(12, 12);
            this.grpFiltros.Name = "grpFiltros";
            this.grpFiltros.Size = new System.Drawing.Size(241, 558);
            this.grpFiltros.TabIndex = 22;
            this.grpFiltros.TabStop = false;
            this.grpFiltros.Text = "Filtros";
            // 
            // btnAplicarFiltro
            // 
            this.btnAplicarFiltro.Location = new System.Drawing.Point(10, 500);
            this.btnAplicarFiltro.Name = "btnAplicarFiltro";
            this.btnAplicarFiltro.Size = new System.Drawing.Size(219, 38);
            this.btnAplicarFiltro.TabIndex = 22;
            this.btnAplicarFiltro.Text = "Aplicar Filtros";
            this.btnAplicarFiltro.UseVisualStyleBackColor = true;
            this.btnAplicarFiltro.Click += new System.EventHandler(this.btnAplicarFiltro_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(371, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(452, 80);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(42, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(42, 134);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "label3";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(452, 150);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(371, 150);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 12;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(282, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 580);
            this.Controls.Add(this.grpFiltros);
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
            this.grpFiltros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.Label lblPrecoTotal;
        private System.Windows.Forms.RadioButton rdoIrmao;
        private System.Windows.Forms.RadioButton rdoRins;
        private System.Windows.Forms.RadioButton rdoDebito;
        private System.Windows.Forms.RadioButton rdoCredito;
        private System.Windows.Forms.Label lblFormaPagamento;
        private System.Windows.Forms.Button btnComprarCarrinho;
        private System.Windows.Forms.ColumnHeader chNome;
        private System.Windows.Forms.ColumnHeader chPreco;
        private System.Windows.Forms.GroupBox grpFiltros;
        private System.Windows.Forms.Button btnAplicarFiltro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}

