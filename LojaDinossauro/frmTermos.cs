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
    public partial class frmTermos : Form
    {
        public frmTermos()
        {
            InitializeComponent();
        }

        private void btnSim_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Parabéns por sua comprar, sobreviva!! :D");

            this.Dispose();

            FormCollection frmList = Application.OpenForms;

            foreach (Form frm in frmList)
            {
                if (frm.Text == "Form1")
                    frm.Show();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Contrato cancelado!!");

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
