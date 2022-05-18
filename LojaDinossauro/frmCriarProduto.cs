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
using System.Threading;
using System.Windows.Forms;

namespace LojaDinossauro
{
    public partial class frmCriarProduto : Form
    {
        public frmCriarProduto(bool tipoProduto)
        {
            InitializeComponent();
            pnlCriarProduto.Hide();
            pnlSenha.Location = new Point(0, 0);

            this.Size = new Size(212, 138);
            this.StartPosition = FormStartPosition.CenterScreen;

            if (tipoProduto)
            {
                foreach (var tipo in Enum.GetValues(typeof(TipoDinossauroEnum)))
                {
                    cmbTipoProduto.Items.Add(tipo);
                }
            }
            else
            {
                lblTipoProduto.Text = lblTipoProduto.Text.Replace("Dinossauro", "Brinquedo");
                btnCriarBrinquedo.Location = btnCriarDinossauro.Location;
                btnCriarDinossauro.Hide();
                btnCriarBrinquedo.Show();

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

                pnlCriarProduto.Show();
                pnlCriarProduto.Location = new Point(0, 0);

                this.Size = new Size(500, 385);
                this.CenterToScreen();
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
                    if (File.Exists($@"{path}\Resources\{openImage.SafeFileName}"))
                        picProduto.Image = new Bitmap($@"{path}\Resources\{openImage.SafeFileName}");
                    else
                        File.Copy(openImage.FileName, $@"{path}\Resources\{openImage.SafeFileName}");
                        picProduto.Image = new Bitmap(openImage.FileName);
                }
            }
            else
            {
                Directory.CreateDirectory($@"{path}\Resources");

                OpenFileDialog openImage = new OpenFileDialog();
                if (openImage.ShowDialog() == DialogResult.OK)
                    File.Copy(openImage.FileName, $@"{path}\Resources\{openImage.SafeFileName}");
                    picProduto.Image = new Bitmap(openImage.FileName);
            }
        }

        private void btnCriarDinossauro_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Control ctrl in pnlText.Controls)
                {
                    if (ctrl.GetType() == typeof(TextBox))
                        if (string.IsNullOrWhiteSpace(ctrl.Text))
                            throw new ArgumentNullException();

                }

                if (!double.TryParse(txtPreco.Text, out double precoParse))
                    if (!double.TryParse(txtPreco.Text.Replace(',', '.'), out precoParse))
                        throw new TypeAccessException();

                if (lstTipoProduto.Items.Count == 0)
                    throw new ArgumentNullException();

                else if (picProduto.Image == null)
                    throw new ArgumentNullException();


                Produto produto = new Produto();

                produto.cod = Global.produtos.Count + 1;
                produto.nome = txtNome.Text;
                produto.preco = double.Parse(txtPreco.Text);
                produto.descricao = txtDescricao.Text;

                foreach (Enum tipo in lstTipoProduto.Items)
                {
                    produto.tipo.Add(tipo);
                }
                
                produto.img = picProduto.Image;

                Global.produtos.Add(produto);
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Erro au tentar criar produto. \nAlgum dos itens acima estão em branco!", "Objeto em Nulo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (TypeAccessException)
            {
                MessageBox.Show("O campo Preço deve ser números!", "Tipo incorreto no campo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCriarBrinquedo_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Control ctrl in pnlText.Controls)
                {
                    if (ctrl.GetType() == typeof(TextBox))
                        if (string.IsNullOrWhiteSpace(ctrl.Text))
                            throw new ArgumentNullException();

                }

                if (!double.TryParse(txtPreco.Text, out double precoParse))
                    if (!double.TryParse(txtPreco.Text.Replace(',', '.'), out precoParse))
                        throw new TypeAccessException();

                if (lstTipoProduto.Items.Count == 0)
                    throw new ArgumentNullException();

                if (picProduto.Image == null)
                    throw new ArgumentNullException();


                Produto produto = new Produto();

                produto.cod = Global.produtos.Count + 1;
                produto.nome = txtNome.Text;
                produto.preco = double.Parse(txtPreco.Text.Replace(',', '.'));
                produto.descricao = txtDescricao.Text;

                foreach (Enum tipo in lstTipoProduto.Items)
                {
                    produto.tipo.Add(tipo);
                }
                
                produto.img = picProduto.Image;

                Global.produtos.Add(produto);
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Erro au tentar criar produto. \nAlgum dos itens acima estão em branco!", "Objeto em Nulo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (TypeAccessException)
            {
                MessageBox.Show("O campo Preço deve ser números!", "Tipo incorreto no campo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Dispose();            

            FormCollection frmList = Application.OpenForms;

            foreach (Form frm in frmList)
            {
                if (frm.Text == "Form1")
                    frm.Show();
            }
        }

        private void btnAddTipo_Click(object sender, EventArgs e)
        {
            if (cmbTipoProduto.SelectedIndex >= 0)
                lstTipoProduto.Items.Add(cmbTipoProduto.SelectedItem);
            else
                MessageBox.Show("Selecione um Item da TextBox para ser removido!");
        }

        private void btnDeletarTipo_Click(object sender, EventArgs e)
        {
            if (lstTipoProduto.SelectedItem != null)
                lstTipoProduto.Items.Remove(lstTipoProduto.SelectedItem);
            else
                MessageBox.Show("Selecione um Item da Lista para ser removido!");
        }
    }
}
