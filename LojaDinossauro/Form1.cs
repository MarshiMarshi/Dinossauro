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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lvwPedido.Columns[0].Width = -2;
            lvwPedido.Columns[1].Width = -2;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_Enter(object sender, EventArgs e)
        {
            
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            if (Global.produtos.Count > 0)
            {
                height = 64;

                foreach (Control ctrl in tpDinossauros.Controls)
                    if (ctrl.Name != "btnCriarDinossauro")
                        ctrl.Dispose();

                tpDinossauros.Refresh();

                foreach (Control ctrl in tpBrinquedos.Controls)
                    if (ctrl.Name != "btnCriarBrinquedo")
                        ctrl.Dispose();

                tpBrinquedos.Refresh();

                foreach (Produto prod in Global.produtos)
                {
                    foreach (Enum tipo in prod.tipo)
                    {
                        if (Enum.IsDefined(typeof(TipoDinossauroEnum), tipo))
                            foreach (Control ctrl in tpDinossauros.Controls)
                                if (ctrl.Name != "btnCriarDinossauro" && !ctrl.TabIndex.Equals(prod.cod))
                                    addControl(prod, true);
                        else
                            addControl(prod, false);

                    }
                }
            }
        }

        private int height = 64;

        private void addControl(Produto prod, bool tipoProduto)
        {
            Button btnComprar = new Button();
            Button btnInfo = new Button();
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
            

            if (tipoProduto)
            {
                if (tpDinossauros.AutoScroll)
                    tpDinossauros.AutoScrollMargin = new Size(0, 10);

                lblNome.Location = new Point(57, tpDinossauros.AutoScrollPosition.Y + height);
                tpDinossauros.Controls.Add(lblNome);

                
                lblPreco.Location = new Point(253, tpDinossauros.AutoScrollPosition.Y + height);
                tpDinossauros.Controls.Add(lblPreco);

                btnComprar.Location = new Point(342, tpDinossauros.AutoScrollPosition.Y + height - 5);
                tpDinossauros.Controls.Add(btnComprar);

                btnInfo.Text = "Info";
                btnInfo.TabIndex = int.Parse(prod.cod.ToString());
                btnInfo.Size = new Size(75, 23);
                btnInfo.Location = new Point(423, tpDinossauros.AutoScrollPosition.Y + height - 5);
                tpDinossauros.Controls.Add(btnInfo);
            }
            else
            {
                if (tpBrinquedos.AutoScroll)
                    tpBrinquedos.AutoScrollMargin = new Size(0, 10);

                lblNome.Location = new Point(57, tpBrinquedos.AutoScrollPosition.Y + height);
                tpBrinquedos.Controls.Add(lblNome);


                lblPreco.Location = new Point(253, tpBrinquedos.AutoScrollPosition.Y + height);
                tpBrinquedos.Controls.Add(lblPreco);

                btnComprar.Location = new Point(342, tpBrinquedos.AutoScrollPosition.Y + height - 5);
                tpBrinquedos.Controls.Add(btnComprar);
            }
            
            height += 44;
            btnComprar.Click += (sender, e) => btnComprar_Click(sender, e, btnComprar.TabIndex);
            btnInfo.Click += (sender, e) => btnInfo_Click(sender, e , btnInfo.TabIndex);
        }

        private void btnComprar_Click(object sender, EventArgs e, long cod)
        {
            double total = 0;
            foreach (Produto prod in Global.produtos)
            {
                if (cod == prod.cod)
                    total += prod.preco;
                    lvwPedido.Items.Add(new ListViewItem(new[] { prod.nome, prod.preco.ToString() }));
            }
            lblPrecoTotal.Text += total;
        }

        private void btnInfo_Click(object sender, EventArgs e, long cod)
        {
            frmInfoProduto frmInfo = new frmInfoProduto(cod);
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

        private void filtros(bool tipoProduto)
        {
            height = 64;

            if (tipoProduto)
            {
                foreach (CheckBox chk in grpFiltrosDinossauros.Controls)
                {
                    if (chk.Checked)
                    {
                        foreach (Control ctrl in tpDinossauros.Controls)
                            if (ctrl.Name != "btnCriarDinossauro")
                                ctrl.Dispose();

                        foreach (Produto prod in Global.produtos)
                            foreach (Enum tipo in prod.tipo)
                                if (chk.Text == tipo.ToString())
                                    addControl(prod, true);
                    }
                }
            }
            else
            {
                foreach (CheckBox chk in grpFiltrosBrinquedos.Controls)
                {
                    if (chk.Checked)
                    {
                        foreach (Control ctrl in tpDinossauros.Controls)
                            if (ctrl.Name != "btnCriarDinossauro")
                                ctrl.Dispose();

                        foreach (Produto prod in Global.produtos)
                            foreach (Enum tipo in prod.tipo)
                                if (chk.Text == tipo.ToString())
                                    addControl(prod, false);
                    }
                }
            }
        }
    }
}
