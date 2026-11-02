namespace ProjetConnexionSportif
{
    partial class FrmConnexion
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBoxMdp = new System.Windows.Forms.TextBox();
            this.txtBoxLogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMDP = new System.Windows.Forms.Label();
            this.btnConnexion = new System.Windows.Forms.Button();
            this.lLblMdpOublier = new System.Windows.Forms.LinkLabel();
            this.lLblCreerCompte = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // txtBoxMdp
            // 
            this.txtBoxMdp.Location = new System.Drawing.Point(303, 180);
            this.txtBoxMdp.Name = "txtBoxMdp";
            this.txtBoxMdp.Size = new System.Drawing.Size(100, 20);
            this.txtBoxMdp.TabIndex = 0;
            // 
            // txtBoxLogin
            // 
            this.txtBoxLogin.Location = new System.Drawing.Point(303, 120);
            this.txtBoxLogin.Name = "txtBoxLogin";
            this.txtBoxLogin.Size = new System.Drawing.Size(100, 20);
            this.txtBoxLogin.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(337, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "LOGIN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblMDP
            // 
            this.lblMDP.AutoSize = true;
            this.lblMDP.Location = new System.Drawing.Point(337, 164);
            this.lblMDP.Name = "lblMDP";
            this.lblMDP.Size = new System.Drawing.Size(31, 13);
            this.lblMDP.TabIndex = 3;
            this.lblMDP.Text = "MDP";
            // 
            // btnConnexion
            // 
            this.btnConnexion.Location = new System.Drawing.Point(287, 228);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(135, 47);
            this.btnConnexion.TabIndex = 4;
            this.btnConnexion.Text = "Connexion";
            this.btnConnexion.UseVisualStyleBackColor = true;
            this.btnConnexion.Click += new System.EventHandler(this.btnConnexion_Click);
            // 
            // lLblMdpOublier
            // 
            this.lLblMdpOublier.AutoSize = true;
            this.lLblMdpOublier.Location = new System.Drawing.Point(238, 183);
            this.lLblMdpOublier.Name = "lLblMdpOublier";
            this.lLblMdpOublier.Size = new System.Drawing.Size(59, 13);
            this.lLblMdpOublier.TabIndex = 5;
            this.lLblMdpOublier.TabStop = true;
            this.lLblMdpOublier.Text = "Mdp oublié";
            this.lLblMdpOublier.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lLblMdpOublier_LinkClicked);
            // 
            // lLblCreerCompte
            // 
            this.lLblCreerCompte.AutoSize = true;
            this.lLblCreerCompte.Location = new System.Drawing.Point(532, 71);
            this.lLblCreerCompte.Name = "lLblCreerCompte";
            this.lLblCreerCompte.Size = new System.Drawing.Size(85, 13);
            this.lLblCreerCompte.TabIndex = 6;
            this.lLblCreerCompte.TabStop = true;
            this.lLblCreerCompte.Text = "Creer un compte";
            this.lLblCreerCompte.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lLblCreerCompte_LinkClicked);
            // 
            // FrmConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lLblCreerCompte);
            this.Controls.Add(this.lLblMdpOublier);
            this.Controls.Add(this.btnConnexion);
            this.Controls.Add(this.lblMDP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxLogin);
            this.Controls.Add(this.txtBoxMdp);
            this.Name = "FrmConnexion";
            this.Text = "Connexion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxMdp;
        private System.Windows.Forms.TextBox txtBoxLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMDP;
        private System.Windows.Forms.Button btnConnexion;
        private System.Windows.Forms.LinkLabel lLblMdpOublier;
        private System.Windows.Forms.LinkLabel lLblCreerCompte;
    }
}

