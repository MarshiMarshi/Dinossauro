using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaDinossauro
{
    public partial class frmCriarProduto : Form
    {
        public frmCriarProduto(bool dinossauroBrinquedo)
        {
            InitializeComponent();
            pnlCriarProduto.Hide();
            pnlSenha.Location = new Point(0, 0);
            this.Size = new Size(212, 138);

            if (dinossauroBrinquedo)
            {
                foreach (var tipo in Enum.GetValues(typeof(TipoDinossauroEnum)))
                {
                    cmbTipoProduto.Items.Add(tipo);
                }
            }
            else
            {
                btnCriarBrinquedo.Location = btnCriarDinossauro.Location;
                btnCriarDinossauro.Visible = false;
                btnCriarBrinquedo.Visible = true;

                foreach (var tipo in Enum.GetValues(typeof(TipoBrinquedoEnum)))
                {
                    cmbTipoProduto.Items.Add(tipo);
                }
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (txtSenha.Text == "pipis")
            {
                this.Hide();
                pnlSenha.Hide();

                pnlCriarProduto.Visible = true;
                pnlCriarProduto.Location = new Point(0, 0);
                this.Size = pnlCriarProduto.Size;
                this.Show();
            }
        }

        private void btnProcurarImagem_Click(object sender, EventArgs e)
        {
            string path = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
            

            if (Directory.Exists($@"{path}\Resources"))
            {
                OpenFileDialog openImage = new OpenFileDialog();
                if (openImage.ShowDialog() == DialogResult.OK)
                {
                    File.Copy(openImage.FileName, $@"{path}\Resources\{openImage.SafeFileName}");

                    picProduto.Image.Save(openImage.SafeFileName);
                }
            }
            else
            {
                Directory.CreateDirectory($@"{path}\Resources");

                OpenFileDialog openImage = new OpenFileDialog();
                if (openImage.ShowDialog() == DialogResult.OK)
                {
                    File.Copy(openImage.FileName, $@"{path}\Resources\{openImage.SafeFileName}");

                    picProduto.Image.Save(openImage.SafeFileName);
                }
            }
        }

        private void btnCriarDinossauro_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto(true);

            produto.nome = txtNome.Text;
            produto.preco = double.Parse(txtPreco.Text);
            produto.tipo = cmbTipoProduto.SelectedItem;
            produto.imgPath = picProduto.Image.ToString();
            MessageBox.Show(produto.imgPath);

            Global.produtos.Add(produto);
        }

        private void btnCriarBrinquedo_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto(false);

            produto.nome = txtNome.Text;
            produto.preco = double.Parse(txtPreco.Text);
            produto.tipo = cmbTipoProduto.SelectedItem;
            produto.imgPath = picProduto.Image.ToString();

            Global.produtos.Add(produto);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Dispose();            

            FormCollection frmList = Application.OpenForms;

            foreach (Form frm in frmList)
            {
                if (frm.Text == "Form1")
                {
                    frm.Show();
                }
            }
        }
    }
}
