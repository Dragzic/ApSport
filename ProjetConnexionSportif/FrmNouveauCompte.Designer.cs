namespace ProjetConnexionSportif
{
    partial class FrmNouveauCompte
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
            this.txtBoxLoginNewCompte = new System.Windows.Forms.TextBox();
            this.txtBoxMdpNewCompte = new System.Windows.Forms.TextBox();
            this.btnCrerCompte = new System.Windows.Forms.Button();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblMdp = new System.Windows.Forms.Label();
            this.linkLabelConnexion = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // txtBoxLoginNewCompte
            // 
            this.txtBoxLoginNewCompte.Location = new System.Drawing.Point(326, 105);
            this.txtBoxLoginNewCompte.Name = "txtBoxLoginNewCompte";
            this.txtBoxLoginNewCompte.Size = new System.Drawing.Size(100, 20);
            this.txtBoxLoginNewCompte.TabIndex = 0;
            // 
            // txtBoxMdpNewCompte
            // 
            this.txtBoxMdpNewCompte.Location = new System.Drawing.Point(326, 159);
            this.txtBoxMdpNewCompte.Name = "txtBoxMdpNewCompte";
            this.txtBoxMdpNewCompte.Size = new System.Drawing.Size(100, 20);
            this.txtBoxMdpNewCompte.TabIndex = 1;
            // 
            // btnCrerCompte
            // 
            this.btnCrerCompte.Location = new System.Drawing.Point(310, 232);
            this.btnCrerCompte.Name = "btnCrerCompte";
            this.btnCrerCompte.Size = new System.Drawing.Size(135, 61);
            this.btnCrerCompte.TabIndex = 2;
            this.btnCrerCompte.Text = "Créer le Compte";
            this.btnCrerCompte.UseVisualStyleBackColor = true;
            this.btnCrerCompte.Click += new System.EventHandler(this.btnCrerCompte_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(352, 89);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(39, 13);
            this.lblLogin.TabIndex = 3;
            this.lblLogin.Text = "Login :";
            // 
            // lblMdp
            // 
            this.lblMdp.AutoSize = true;
            this.lblMdp.Location = new System.Drawing.Point(337, 143);
            this.lblMdp.Name = "lblMdp";
            this.lblMdp.Size = new System.Drawing.Size(77, 13);
            this.lblMdp.TabIndex = 4;
            this.lblMdp.Text = "Mot de passe :";
            // 
            // linkLabelConnexion
            // 
            this.linkLabelConnexion.AutoSize = true;
            this.linkLabelConnexion.Location = new System.Drawing.Point(12, 9);
            this.linkLabelConnexion.Name = "linkLabelConnexion";
            this.linkLabelConnexion.Size = new System.Drawing.Size(102, 13);
            this.linkLabelConnexion.TabIndex = 5;
            this.linkLabelConnexion.TabStop = true;
            this.linkLabelConnexion.Text = "Ecran de connexion";
            this.linkLabelConnexion.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelConnexion_LinkClicked);
            // 
            // FrmNouveauCompte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabelConnexion);
            this.Controls.Add(this.lblMdp);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.btnCrerCompte);
            this.Controls.Add(this.txtBoxMdpNewCompte);
            this.Controls.Add(this.txtBoxLoginNewCompte);
            this.Name = "FrmNouveauCompte";
            this.Text = "CréationCompte";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxLoginNewCompte;
        private System.Windows.Forms.TextBox txtBoxMdpNewCompte;
        private System.Windows.Forms.Button btnCrerCompte;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblMdp;
        private System.Windows.Forms.LinkLabel linkLabelConnexion;
    }
}