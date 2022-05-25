using System;
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
    public partial class frmInfoProduto : Form
    {
        public frmInfoProduto(long cod)
        {
            InitializeComponent();

            foreach (Produto prod in Global.produtos)
            {
                if (prod.cod == cod)
                    picImageProduto.Image = prod.img;
                    txtDescricao.Text = prod.descricao;
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
    }
}
