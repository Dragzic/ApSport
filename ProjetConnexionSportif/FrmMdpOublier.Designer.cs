namespace ProjetConnexionSportif
{
    partial class FrmMdpOublier
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
            this.txtBoxNewMdp = new System.Windows.Forms.TextBox();
            this.btnNewMdp = new System.Windows.Forms.Button();
            this.txtBoxNewMdpConfirmation = new System.Windows.Forms.TextBox();
            this.lblNewMdp = new System.Windows.Forms.Label();
            this.lblConfirmationNewMdp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBoxNewMdp
            // 
            this.txtBoxNewMdp.Location = new System.Drawing.Point(304, 142);
            this.txtBoxNewMdp.Name = "txtBoxNewMdp";
            this.txtBoxNewMdp.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNewMdp.TabIndex = 0;
            // 
            // btnNewMdp
            // 
            this.btnNewMdp.Location = new System.Drawing.Point(281, 248);
            this.btnNewMdp.Name = "btnNewMdp";
            this.btnNewMdp.Size = new System.Drawing.Size(163, 60);
            this.btnNewMdp.TabIndex = 1;
            this.btnNewMdp.Text = "Valider Nouveau mdp";
            this.btnNewMdp.UseVisualStyleBackColor = true;
            this.btnNewMdp.Click += new System.EventHandler(this.btnNewMdp_Click);
            // 
            // txtBoxNewMdpConfirmation
            // 
            this.txtBoxNewMdpConfirmation.Location = new System.Drawing.Point(303, 203);
            this.txtBoxNewMdpConfirmation.Name = "txtBoxNewMdpConfirmation";
            this.txtBoxNewMdpConfirmation.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNewMdpConfirmation.TabIndex = 2;
            // 
            // lblNewMdp
            // 
            this.lblNewMdp.AutoSize = true;
            this.lblNewMdp.Location = new System.Drawing.Point(300, 117);
            this.lblNewMdp.Name = "lblNewMdp";
            this.lblNewMdp.Size = new System.Drawing.Size(124, 13);
            this.lblNewMdp.TabIndex = 3;
            this.lblNewMdp.Text = "Nouveau Mot de passe :";
            // 
            // lblConfirmationNewMdp
            // 
            this.lblConfirmationNewMdp.AutoSize = true;
            this.lblConfirmationNewMdp.Location = new System.Drawing.Point(290, 177);
            this.lblConfirmationNewMdp.Name = "lblConfirmationNewMdp";
            this.lblConfirmationNewMdp.Size = new System.Drawing.Size(134, 13);
            this.lblConfirmationNewMdp.TabIndex = 4;
            this.lblConfirmationNewMdp.Text = "Confirmer Le nouveau mdp";
            // 
            // FrmMdpOublier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblConfirmationNewMdp);
            this.Controls.Add(this.lblNewMdp);
            this.Controls.Add(this.txtBoxNewMdpConfirmation);
            this.Controls.Add(this.btnNewMdp);
            this.Controls.Add(this.txtBoxNewMdp);
            this.Name = "FrmMdpOublier";
            this.Text = "FrmMdpOublier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxNewMdp;
        private System.Windows.Forms.Button btnNewMdp;
        private System.Windows.Forms.TextBox txtBoxNewMdpConfirmation;
        private System.Windows.Forms.Label lblNewMdp;
        private System.Windows.Forms.Label lblConfirmationNewMdp;
    }
}