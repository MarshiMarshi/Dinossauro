
namespace LojaDinossauro
{
    partial class frmTermos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTermos = new System.Windows.Forms.Label();
            this.btnAceitar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTermos
            // 
            this.lblTermos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTermos.Location = new System.Drawing.Point(30, 28);
            this.lblTermos.Name = "lblTermos";
            this.lblTermos.Size = new System.Drawing.Size(245, 79);
            this.lblTermos.TabIndex = 0;
            this.lblTermos.Text = "Não nos responsabilizamos por mortes ou perdas de membros dos nossos clientes, es" +
    "teja ciente disso.\r\n\r\nAceita os Termos?\r\n";
            // 
            // btnAceitar
            // 
            this.btnAceitar.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnAceitar.Location = new System.Drawing.Point(63, 128);
            this.btnAceitar.Name = "btnAceitar";
            this.btnAceitar.Size = new System.Drawing.Size(75, 23);
            this.btnAceitar.TabIndex = 1;
            this.btnAceitar.Text = "Aceitar";
            this.btnAceitar.UseVisualStyleBackColor = true;
            this.btnAceitar.Click += new System.EventHandler(this.btnAceitar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(144, 128);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmTermos
            // 
            this.AcceptButton = this.btnAceitar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(308, 191);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceitar);
            this.Controls.Add(this.lblTermos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmTermos";
            this.Text = "frmTermos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTermos;
        private System.Windows.Forms.Button btnAceitar;
        private System.Windows.Forms.Button btnCancelar;
    }
}