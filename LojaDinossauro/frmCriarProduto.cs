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
                    cmbTipoProduto.Items.Add(tipo);
            }
            else
            {
                lblDescrisao.Enabled = false;
                txtDescrisao.Enabled = false;
                lblTipoProduto.Text = lblTipoProduto.Text.Replace("Dinossauro", "Brinquedo");
                btnCriarBrinquedo.Location = btnCriarDinossauro.Location;
                btnCriarDinossauro.Hide();
                btnCriarBrinquedo.Show();

                foreach (var tipo in Enum.GetValues(typeof(TipoBrinquedoEnum)))
                    cmbTipoProduto.Items.Add(tipo);
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
            bool locked = false;
            string pathResources = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Resources"));
            if (!Directory.Exists(pathResources))
                Directory.CreateDirectory(pathResources);

            OpenFileDialog openImage = new OpenFileDialog();
            openImage.InitialDirectory = pathResources;
            if (openImage.ShowDialog() == DialogResult.OK)
            {
                foreach (var imageExtension in typeof(ImageFormat).GetProperties())
                    if (string.Equals(openImage.SafeFileName.Substring(openImage.SafeFileName.LastIndexOf(".")).Remove(0, 1), imageExtension.Name, StringComparison.OrdinalIgnoreCase))
                        locked = true;
                        
                if (locked || string.Equals(openImage.SafeFileName.Substring(openImage.SafeFileName.LastIndexOf(".")).Remove(0, 1), "jpg", StringComparison.OrdinalIgnoreCase))
                {
                    if (!File.Exists(Path.Combine(pathResources, openImage.SafeFileName)))
                        File.Copy(openImage.FileName, Path.Combine(pathResources, openImage.SafeFileName));

                    picProduto.Image = new Bitmap(openImage.FileName);
                }
                else
                {
                    MessageBox.Show("Somente arquivos de imagem devem ser escolhido!", "Arquivo Inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
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
                produto.preco = double.Parse(txtPreco.Text.Replace(',', '.'), System.Globalization.CultureInfo.InvariantCulture);
                produto.descricao = txtDescricao.Text;
                produto.tipo.AddRange(lstTipoProduto.Items.Cast<Enum>());
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
                        if (string.IsNullOrWhiteSpace(ctrl.Text) && ctrl.Enabled != false)
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
                produto.preco = double.Parse(txtPreco.Text.Replace(',', '.'), System.Globalization.CultureInfo.InvariantCulture);
                produto.tipo.AddRange(lstTipoProduto.Items.Cast<Enum>());
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

        private void btnAddTipo_Click(object sender, EventArgs e)
        {
            if (cmbTipoProduto.SelectedIndex >= 0)
            {
                if (!lstTipoProduto.Items.Contains(cmbTipoProduto.SelectedItem))
                    lstTipoProduto.Items.Add(cmbTipoProduto.SelectedItem);
                else
                    MessageBox.Show("Item já adicionado na lista!", "Erro: Adicionar mais de um item", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Selecione um Item da TextBox para ser adicionado!", "Nenhum item selecionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRemoverTipo_Click(object sender, EventArgs e)
        {
            if (lstTipoProduto.SelectedItem != null)
                lstTipoProduto.Items.Remove(lstTipoProduto.SelectedItem);
            else
                MessageBox.Show("Selecione um Item da Lista para ser removido!", "Nenhum item selecionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnRemoverTodosTipos_Click(object sender, EventArgs e)
        {
            lstTipoProduto.Items.Clear();
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

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in pnlText.Controls)
                if (ctrl.GetType() == typeof(TextBox))
                    ctrl.Text = "";

            lstTipoProduto.Items.Clear();
            picProduto.Image = null;
        }
    }
}
