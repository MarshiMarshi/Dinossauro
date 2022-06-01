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
                addControl(tpDinossauros, 85);
                addControl(tpBrinquedos, 85);
            }
        }

        // TODO: Melhorar metodo addControl
        private void addControl(TabPage tp, int height, Produto produto = default)
        {
            if (produto == default)
            {
                for (int i = tp.Controls.Count - 1; i >= 0; i--)
                    if (tp.Controls[i].Text != "Criar")
                        tp.Controls[i].Dispose();
                tp.Refresh();

                foreach (Produto prod in Global.produtos)
                {
                    if ((tp.Name == "tpDinossauros" && prod.tipo.First<Enum>().GetType() == typeof(TipoDinossauroEnum)) || (tp.Name == "tpBrinquedos" && prod.tipo.First<Enum>().GetType() == typeof(TipoBrinquedoEnum)))
                    {
                        PictureBox imgProd = new PictureBox();
                        Button btnComprar = new Button();
                        Label lblNome = new Label();
                        Label lblPreco = new Label();

                        imgProd.Image = prod.img;
                        imgProd.Size = new Size(50, 50);
                        imgProd.SizeMode = PictureBoxSizeMode.Zoom;

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
                            tp.AutoScrollMargin = new Size(0, 64);

                        imgProd.Location = new Point(42, tp.AutoScrollPosition.Y + height - 21);
                        tp.Controls.Add(imgProd);

                        lblNome.Location = new Point(110, tp.AutoScrollPosition.Y + height);
                        tp.Controls.Add(lblNome);


                        lblPreco.Location = new Point(282, tp.AutoScrollPosition.Y + height);
                        tp.Controls.Add(lblPreco);

                        btnComprar.Location = new Point(371, tp.AutoScrollPosition.Y + height - 5);
                        tp.Controls.Add(btnComprar);

                        if (prod.descricao != null)
                        {
                            Button btnInfo = new Button();

                            btnInfo.Text = "Info";
                            btnInfo.TabIndex = int.Parse(prod.cod.ToString());
                            btnInfo.Size = new Size(75, 23);
                            btnInfo.Location = new Point(452, tp.AutoScrollPosition.Y + height - 5);
                            tp.Controls.Add(btnInfo);

                            btnInfo.Click += new EventHandler(btnInfo_Click);
                        }

                        height += 70;
                        btnComprar.Click += new EventHandler(btnComprar_Click);
                    }
                }
            }
            else
            {
                PictureBox imgProd = new PictureBox();
                Button btnComprar = new Button();
                Label lblNome = new Label();
                Label lblPreco = new Label();

                imgProd.Image = produto.img;
                imgProd.Size = new Size(50, 50);
                imgProd.SizeMode = PictureBoxSizeMode.Zoom;

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
                    tp.AutoScrollMargin = new Size(0, 64);

                imgProd.Location = new Point(42, tp.AutoScrollPosition.Y + height - 21);
                tp.Controls.Add(imgProd);

                lblNome.Location = new Point(110, tp.AutoScrollPosition.Y + height);
                tp.Controls.Add(lblNome);


                lblPreco.Location = new Point(282, tp.AutoScrollPosition.Y + height);
                tp.Controls.Add(lblPreco);

                btnComprar.Location = new Point(371, tp.AutoScrollPosition.Y + height - 5);
                tp.Controls.Add(btnComprar);

                if (produto.descricao != null)
                {
                    Button btnInfo = new Button();

                    btnInfo.Text = "Info";
                    btnInfo.TabIndex = int.Parse(produto.cod.ToString());
                    btnInfo.Size = new Size(75, 23);
                    btnInfo.Location = new Point(452, tp.AutoScrollPosition.Y + height - 5);
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
            filtros(grpFiltrosDinossauros, tpDinossauros, 64, TipoDinossauroEnum.Carnivoro);
        }

        private void chkHerbivoro_CheckedChanged(object sender, EventArgs e)
        {
            filtros(grpFiltrosDinossauros, tpDinossauros, 64, TipoDinossauroEnum.Herbivoro);
        }

        private void chkBipede_CheckedChanged(object sender, EventArgs e)
        {
            filtros(grpFiltrosDinossauros, tpDinossauros, 64, TipoDinossauroEnum.Bipede);
        }

        private void chkQuadrupede_CheckedChanged(object sender, EventArgs e)
        {
            filtros(grpFiltrosDinossauros, tpDinossauros, 64, TipoDinossauroEnum.Quadrupede);
        }

        private void chkEspinhos_CheckedChanged(object sender, EventArgs e)
        {
            filtros(grpFiltrosDinossauros, tpDinossauros, 64, TipoDinossauroEnum.Espinhos);
        }

        private void chkAquatico_CheckedChanged(object sender, EventArgs e)
        {
            filtros(grpFiltrosDinossauros, tpDinossauros, 64, TipoDinossauroEnum.Aquatico);
        }

        private void chkVoador_CheckedChanged(object sender, EventArgs e)
        {
            filtros(grpFiltrosDinossauros, tpDinossauros, 64, TipoDinossauroEnum.Voador);
        }
        #endregion

        // TODO: Refazer filtros
        private void filtros(GroupBox grp, TabPage tp, int height, Enum tipoProduto)
        {
            /*for (int i = tp.Controls.Count - 1; i >= 0; i--)
                if (tp.Controls[i].Text != "Criar")
                    tp.Controls[i].Dispose();
            tp.Refresh();

            List<CheckBox> lstCheck = new List<CheckBox>();
            foreach (CheckBox chk in grp.Controls)
            {
                if (chk.Checked)
                    lstCheck.Add(chk);
                else
                    lstCheck.Remove(chk);
            }

            foreach (Produto prod in Global.produtos)
            {
                if (prod.tipo.First<Enum>().GetType() == tipoProduto)
                {
                    foreach (CheckBox chk in lstCheck)
                    {
                        foreach (var tipo in lstTipo)
                        {
                            if (chk.Text == tipo.ToString())
                            {
                                MessageBox.Show(tipo.ToString());
                                MessageBox.Show(chk.Text);
                                addControl(tp, height, prod);
                                height += 44;
                            }
                        }
                    }
                }
            }*/
        }

        private void btnAplicarFiltro_Click(object sender, EventArgs e)
        {
            int heightDino = 85;
            int heightBrin = 85;
            List<CheckBox> chkList = new List<CheckBox>();

            foreach (CheckBox chk in grpFiltrosDinossauros.Controls)
            {
                if (chk.Checked)
                    chkList.Add(chk);
                else if (chkList.Contains(chk))
                    chkList.Remove(chk);
            }

            foreach (CheckBox chk in grpFiltrosBrinquedos.Controls)
            {
                if (chk.Checked)
                    chkList.Add(chk);
                else if (chkList.Contains(chk))
                    chkList.Remove(chk);
            }

            if (chkList.Count != 0)
            {
                for (int i = tpDinossauros.Controls.Count - 1; i >= 0; i--)
                    if (tpDinossauros.Controls[i].Text != "Criar")
                        tpDinossauros.Controls[i].Dispose();
                tpDinossauros.Refresh();

                foreach (Produto prod in Global.produtos)
                {
                    foreach (CheckBox chk in chkList)
                    {
                        foreach (Enum tipo in prod.tipo)
                        {
                            if (tipo.GetType() == typeof(TipoDinossauroEnum))
                            {
                                if (chk.Text == tipo.ToString())
                                {
                                    if (tpDinossauros.Controls[int.Parse(prod.cod.ToString())] == null)
                                    {
                                        addControl(tpDinossauros, heightDino, prod);
                                        heightDino += 70;
                                    }
                                }
                            }
                            else
                            {
                                if ( chk.Text == tipo.ToString())
                                {
                                    if (tpBrinquedos.Controls[int.Parse(prod.cod.ToString())] == null)
                                    {
                                        addControl(tpBrinquedos, heightBrin, prod);
                                        heightBrin += 70;
                                    }
                                }
                            }

                        }
                    }
                }
            }
        }
    }
}

