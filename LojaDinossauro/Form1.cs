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

            this.AutoScroll = false;
            /*lvProduto.Items.Add("T-REX");//.Group = lvProduto.Groups[0];
            lvProduto.Items.Add("1000");//.Group = lvProduto.Groups[1];

            lvProduto.Columns[0].Width = -2;
            lvProduto.Columns[1].Width = -2;


            /*var view = new ListViewItem(new[] { "T-Rex", "1000" });

            lvProduto.Items.Add(view);*/
        }

        private void btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Não vai dar certo");
        }

        private int height = 25;

        /*private void pnl_Paint(object sender, PaintEventArgs e) 
        {
            //103
            var width = pnlProduto.Size.Width / 3;
            //44
            var height = pnlProduto.Size.Height / 3;

            Graphics g = e.Graphics;

            for (int iWidth = 0; iWidth <= pnlProduto.Size.Width; iWidth = iWidth + width)
            {
                g.DrawRectangle(Pens.Red, new Rectangle(iWidth, iHeight, width, height));
            }

            height += height;
        }*/

        private void btnCriarDinossauro_Click(object sender, EventArgs e)
        {
            frmCriarProduto frm = new frmCriarProduto(true);
            frm.ShowDialog();

            /*pnlProduto.Paint += new PaintEventHandler(pnl_Paint);
            this.Refresh();*/
            
            /*Button btn = new Button();
            Label lbl = new Label();
            Label lbl2 = new Label();

            if (pnlProduto.AutoScroll)
            {
                pnlProduto.AutoScrollMargin = new Size(0, 10);
            }

            lbl.Text = textBox1.Text;
            lbl.AutoSize = true;
            lbl.Location = new Point(24, pnlProduto.AutoScrollPosition.Y + height);
            pnlProduto.Controls.Add(lbl);

            lbl2.Text = textBox2.Text;
            lbl2.AutoSize = true;
            lbl2.Location = new Point(153, pnlProduto.AutoScrollPosition.Y + height);
            pnlProduto.Controls.Add(lbl2);

            btn.Text = "Comprar";
            btn.Size = new Size(75, 23);
            btn.Location = new Point(216, pnlProduto.AutoScrollPosition.Y + height-5);
            pnlProduto.Controls.Add(btn);
            
            height += 44;
            btn.Click += new EventHandler(btn_Click);*/
        }

        private void btnCriarBrinquedo_Click(object sender, EventArgs e)
        {
            frmCriarProduto frm = new frmCriarProduto(false);
            frm.ShowDialog();
        }

        private void btnBuscarImage_Click(object sender, EventArgs e)
        {
            /*OpenFileDialog open = new OpenFileDialog();
            open.ShowDialog();*/
            //Directory.CreateDirectory($@"{Directory.GetCurrentDirectory()}\Resources");
            /*MessageBox.Show(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName);
            MessageBox.Show(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName);*/
            //Bitmap.

            string path = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;

            if (Directory.Exists($@"{path}\Resources"))
            {
                OpenFileDialog openImage = new OpenFileDialog();
                if (openImage.ShowDialog() == DialogResult.OK)
                {
                    File.Copy(openImage.FileName, $@"{path}\Resources\{openImage.SafeFileName}");
                }
            }
            else
            {
                Directory.CreateDirectory($@"{path}\Resources");
                
                OpenFileDialog openImage = new OpenFileDialog();
                if (openImage.ShowDialog() == DialogResult.OK)
                {
                    File.Copy(openImage.FileName, $@"{path}\Resources\{openImage.SafeFileName}");
                }
            }
        }

        /*private void filtros(CheckBox chk)
        {
            if (chk.Checked)
            {
                if (chk.Text == TipoProdutoEnum.Carnivoro.ToString())
                {
                    label1.Visible = true;
                }

                if (chk.Text == TipoProdutoEnum.Herbivoro.ToString())
                {
                    label2.Visible = true;
                }
            }
            else
            {
                if (chk.Text == TipoProdutoEnum.Carnivoro.ToString())
                {
                    label1.Visible = false;
                }

                if (chk.Text == TipoProdutoEnum.Herbivoro.ToString())
                {
                    label2.Visible = false;
                }
            }
        }*/

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //filtros(checkBox1);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            //filtros(CheckBox2);
        }
    }
}
