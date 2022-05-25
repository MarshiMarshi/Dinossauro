
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTermos));
            this.btnSim = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblTermos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSim
            // 
            this.btnSim.Location = new System.Drawing.Point(123, 220);
            this.btnSim.Name = "btnSim";
            this.btnSim.Size = new System.Drawing.Size(75, 23);
            this.btnSim.TabIndex = 0;
            this.btnSim.Text = "Sim";
            this.btnSim.UseVisualStyleBackColor = true;
            this.btnSim.Click += new System.EventHandler(this.btnSim_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(221, 220);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblTermos
            // 
            this.lblTermos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTermos.Location = new System.Drawing.Point(53, 24);
            this.lblTermos.Name = "lblTermos";
            this.lblTermos.Size = new System.Drawing.Size(302, 166);
            this.lblTermos.TabIndex = 2;
            this.lblTermos.Text = resources.GetString("lblTermos.Text");
            // 
            // frmTermos
            // 
            this.AcceptButton = this.btnSim;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(419, 283);
            this.Controls.Add(this.lblTermos);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSim);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmTermos";
            this.Text = "frmTermos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSim;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblTermos;
    }
}