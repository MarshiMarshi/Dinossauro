using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaDinossauro
{
    // TODO: Terminar o Codigo
    // TODO: Organizar o codigo
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lvwPedido.Columns[0].Width = -2;
            lvwPedido.Columns[1].Width = -2;
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            if (Global.produtos.Count > 0)
            {
                addControl(tpDinossauros, 64);
                addControl(tpBrinquedos, 64);
            }
        }

        // TODO: Melhorar metodo addControl
        private void addControl(TabPage tp, int height, Produto produto = default)
        {
            if (produto == default)
            {
                foreach (Control ctrl in tp.Controls)
                    if (!ctrl.Name.Contains("btnCriar"))
                        ctrl.Dispose();
                tp.Refresh();

                foreach (Produto prod in Global.produtos)
                {
                    Button btnComprar = new Button();
                    Label lblNome = new Label();
                    Label lblPreco = new Label();

                    lblNome.Text = prod.nome;
                    lblNome.AutoSize = true;
                    lblNome.TabIndex = int.Parse(prod.cod.ToString());

                    lblPreco.Text = prod.preco.ToString();
                    lblPreco.AutoSize = true;
                    lblPreco.TabIndex = int.Parse(prod.cod.ToString());

                    btnComprar.Text = "Comprar";
                    btnComprar.TabIndex = int.Parse(prod.cod.ToString());
                    btnComprar.Size = new Size(75, 23);

                    if (tp.AutoScroll)
                        tp.AutoScrollMargin = new Size(0, 10);

                    lblNome.Location = new Point(57, tp.AutoScrollPosition.Y + height);
                    tp.Controls.Add(lblNome);


                    lblPreco.Location = new Point(253, tp.AutoScrollPosition.Y + height);
                    tp.Controls.Add(lblPreco);

                    btnComprar.Location = new Point(342, tp.AutoScrollPosition.Y + height - 5);
                    tp.Controls.Add(btnComprar);

                    if (prod.descricao != null)
                    {
                        Button btnInfo = new Button();

                        btnInfo.Text = "Info";
                        btnInfo.TabIndex = int.Parse(prod.cod.ToString());
                        btnInfo.Size = new Size(75, 23);
                        btnInfo.Location = new Point(423, tp.AutoScrollPosition.Y + height - 5);
                        tp.Controls.Add(btnInfo);

                        btnInfo.Click += new EventHandler(btnInfo_Click);
                    }

                    height += 44;
                    btnComprar.Click += new EventHandler(btnComprar_Click);
                }
            }
            else
            {
                Button btnComprar = new Button();
                Label lblNome = new Label();
                Label lblPreco = new Label();

                lblNome.Text = produto.nome;
                lblNome.AutoSize = true;
                lblNome.TabIndex = int.Parse(produto.cod.ToString());

                lblPreco.Text = produto.preco.ToString();
                lblPreco.AutoSize = true;
                lblPreco.TabIndex = int.Parse(produto.cod.ToString());

                btnComprar.Text = "Comprar";
                btnComprar.TabIndex = int.Parse(produto.cod.ToString());
                btnComprar.Size = new Size(75, 23);

                if (tp.AutoScroll)
                    tp.AutoScrollMargin = new Size(0, 10);

                lblNome.Location = new Point(57, tp.AutoScrollPosition.Y + height);
                tp.Controls.Add(lblNome);


                lblPreco.Location = new Point(253, tp.AutoScrollPosition.Y + height);
                tp.Controls.Add(lblPreco);

                btnComprar.Location = new Point(342, tp.AutoScrollPosition.Y + height - 5);
                tp.Controls.Add(btnComprar);

                if (produto.descricao != null)
                {
                    Button btnInfo = new Button();

                    btnInfo.Text = "Info";
                    btnInfo.TabIndex = int.Parse(produto.cod.ToString());
                    btnInfo.Size = new Size(75, 23);
                    btnInfo.Location = new Point(423, tp.AutoScrollPosition.Y + height - 5);
                    tp.Controls.Add(btnInfo);

                    btnInfo.Click += new EventHandler(btnInfo_Click);
                }

                btnComprar.Click += new EventHandler(btnComprar_Click);
            }
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            double total = 0;
            foreach (Produto prod in Global.produtos)
            {
                if ((sender as Button).TabIndex == prod.cod)
                    total += prod.preco;
                lvwPedido.Items.Add(new ListViewItem(new[] { prod.nome, prod.preco.ToString() }));
            }
            lblPrecoTotal.Text = string.Format("Total: {0}", total);
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            frmInfoProduto frmInfo = new frmInfoProduto((sender as Button).TabIndex);
            frmInfo.ShowDialog();
        }

        private void btnCriarDinossauro_Click(object sender, EventArgs e)
        {
            frmCriarProduto frm = new frmCriarProduto(true);
            frm.ShowDialog();
        }

        private void btnCriarBrinquedo_Click(object sender, EventArgs e)
        {
            frmCriarProduto frm = new frmCriarProduto(false);
            frm.ShowDialog();
        }

        private void btnComprarCarrinho_Click(object sender, EventArgs e)
        {
            frmTermos termos = new frmTermos();

            if (termos.ShowDialog() == DialogResult.Yes)
                MessageBox.Show("Termos aceitos");
            else
                MessageBox.Show("Termos Rejeitados");
        }

        #region Eventos CheckedChanged

        private void chkCarnivoro_CheckedChanged(object sender, EventArgs e)
        {
            filtros(true);
        }

        private void chkHerbivoro_CheckedChanged(object sender, EventArgs e)
        {
            filtros(true);
        }

        private void chkBipede_CheckedChanged(object sender, EventArgs e)
        {
            filtros(true);
        }

        private void chkQuadrupede_CheckedChanged(object sender, EventArgs e)
        {
            filtros(true);
        }

        private void chkEspinhos_CheckedChanged(object sender, EventArgs e)
        {
            filtros(true);
        }

        private void chkAquatico_CheckedChanged(object sender, EventArgs e)
        {
            filtros(true);
        }

        private void chkVoador_CheckedChanged(object sender, EventArgs e)
        {
            filtros(true);
        }
        #endregion

        // TODO: Refazer filtros
        private void filtros(TabPage tp, int height, Enum tipoProduto)
        {

            height += 44;
        }
    }
}
