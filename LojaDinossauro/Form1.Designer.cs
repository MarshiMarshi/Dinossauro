
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.CheckBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnBuscarImage = new System.Windows.Forms.Button();
            this.tabLoja = new System.Windows.Forms.TabControl();
            this.tpDinossauros = new System.Windows.Forms.TabPage();
            this.tpBrinquedos = new System.Windows.Forms.TabPage();
            this.btnCriarBrinquedo = new System.Windows.Forms.Button();
            this.tpCarrinho = new System.Windows.Forms.TabPage();
            this.lstFiltrosUsados = new System.Windows.Forms.ListBox();
            this.grpFiltrosDinossauros = new System.Windows.Forms.GroupBox();
            this.grpFiltrosBrinquedos = new System.Windows.Forms.GroupBox();
            this.tabLoja.SuspendLayout();
            this.tpDinossauros.SuspendLayout();
            this.tpBrinquedos.SuspendLayout();
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
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(27, 36);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(71, 17);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Carnivoro";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // CheckBox2
            // 
            this.CheckBox2.AutoSize = true;
            this.CheckBox2.Location = new System.Drawing.Point(27, 59);
            this.CheckBox2.Name = "CheckBox2";
            this.CheckBox2.Size = new System.Drawing.Size(72, 17);
            this.CheckBox2.TabIndex = 12;
            this.CheckBox2.Text = "Herbivoro";
            this.CheckBox2.UseVisualStyleBackColor = true;
            this.CheckBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(27, 82);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(80, 17);
            this.checkBox3.TabIndex = 13;
            this.checkBox3.Text = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(27, 105);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(80, 17);
            this.checkBox4.TabIndex = 14;
            this.checkBox4.Text = "checkBox4";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(172, 532);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 15;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(172, 476);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 16;
            // 
            // btnBuscarImage
            // 
            this.btnBuscarImage.Location = new System.Drawing.Point(172, 503);
            this.btnBuscarImage.Name = "btnBuscarImage";
            this.btnBuscarImage.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarImage.TabIndex = 18;
            this.btnBuscarImage.Text = "Buscar";
            this.btnBuscarImage.UseVisualStyleBackColor = true;
            this.btnBuscarImage.Click += new System.EventHandler(this.btnBuscarImage_Click);
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
            this.tabLoja.TabIndex = 19;
            // 
            // tpDinossauros
            // 
            this.tpDinossauros.AutoScroll = true;
            this.tpDinossauros.Controls.Add(this.btnCriarDinossauro);
            this.tpDinossauros.Location = new System.Drawing.Point(4, 22);
            this.tpDinossauros.Name = "tpDinossauros";
            this.tpDinossauros.Padding = new System.Windows.Forms.Padding(3);
            this.tpDinossauros.Size = new System.Drawing.Size(517, 294);
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
            this.btnCriarBrinquedo.TabIndex = 4;
            this.btnCriarBrinquedo.Text = "Criar";
            this.btnCriarBrinquedo.UseVisualStyleBackColor = true;
            this.btnCriarBrinquedo.Click += new System.EventHandler(this.btnCriarBrinquedo_Click);
            // 
            // tpCarrinho
            // 
            this.tpCarrinho.Location = new System.Drawing.Point(4, 22);
            this.tpCarrinho.Name = "tpCarrinho";
            this.tpCarrinho.Size = new System.Drawing.Size(517, 294);
            this.tpCarrinho.TabIndex = 2;
            this.tpCarrinho.Text = "Carrinho";
            this.tpCarrinho.UseVisualStyleBackColor = true;
            // 
            // lstFiltrosUsados
            // 
            this.lstFiltrosUsados.FormattingEnabled = true;
            this.lstFiltrosUsados.Location = new System.Drawing.Point(12, 198);
            this.lstFiltrosUsados.Name = "lstFiltrosUsados";
            this.lstFiltrosUsados.Size = new System.Drawing.Size(241, 147);
            this.lstFiltrosUsados.TabIndex = 20;
            // 
            // grpFiltrosDinossauros
            // 
            this.grpFiltrosDinossauros.Controls.Add(this.checkBox1);
            this.grpFiltrosDinossauros.Controls.Add(this.CheckBox2);
            this.grpFiltrosDinossauros.Controls.Add(this.checkBox3);
            this.grpFiltrosDinossauros.Controls.Add(this.checkBox4);
            this.grpFiltrosDinossauros.Location = new System.Drawing.Point(12, 25);
            this.grpFiltrosDinossauros.Name = "grpFiltrosDinossauros";
            this.grpFiltrosDinossauros.Size = new System.Drawing.Size(241, 159);
            this.grpFiltrosDinossauros.TabIndex = 21;
            this.grpFiltrosDinossauros.TabStop = false;
            this.grpFiltrosDinossauros.Text = "Filtros";
            // 
            // grpFiltrosBrinquedos
            // 
            this.grpFiltrosBrinquedos.Location = new System.Drawing.Point(307, 446);
            this.grpFiltrosBrinquedos.Name = "grpFiltrosBrinquedos";
            this.grpFiltrosBrinquedos.Size = new System.Drawing.Size(241, 159);
            this.grpFiltrosBrinquedos.TabIndex = 19;
            this.grpFiltrosBrinquedos.TabStop = false;
            this.grpFiltrosBrinquedos.Text = "Brinquedos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(796, 357);
            this.Controls.Add(this.grpFiltrosBrinquedos);
            this.Controls.Add(this.btnBuscarImage);
            this.Controls.Add(this.grpFiltrosDinossauros);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lstFiltrosUsados);
            this.Controls.Add(this.tabLoja);
            this.Controls.Add(this.textBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabLoja.ResumeLayout(false);
            this.tpDinossauros.ResumeLayout(false);
            this.tpBrinquedos.ResumeLayout(false);
            this.grpFiltrosDinossauros.ResumeLayout(false);
            this.grpFiltrosDinossauros.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCriarDinossauro;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox CheckBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnBuscarImage;
        private System.Windows.Forms.TabControl tabLoja;
        private System.Windows.Forms.TabPage tpDinossauros;
        private System.Windows.Forms.TabPage tpBrinquedos;
        private System.Windows.Forms.TabPage tpCarrinho;
        private System.Windows.Forms.ListBox lstFiltrosUsados;
        private System.Windows.Forms.GroupBox grpFiltrosDinossauros;
        private System.Windows.Forms.GroupBox grpFiltrosBrinquedos;
        private System.Windows.Forms.Button btnCriarBrinquedo;
    }
}

