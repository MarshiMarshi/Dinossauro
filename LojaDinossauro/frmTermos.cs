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
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnAceitar_Click(object sender, EventArgs e)
        {
            this.Dispose();

            FormCollection frmList = Application.OpenForms;

            foreach (Form frm in frmList)
            {
                if (frm.Text == "Form1")
                    frm.Show();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
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
