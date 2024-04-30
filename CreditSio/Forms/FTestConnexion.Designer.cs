
namespace CreditSio.Forms
{
    partial class FTestConnexion
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
            this.tbxLogin = new System.Windows.Forms.TextBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnConnecter = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVoirComptes = new System.Windows.Forms.Button();
            this.labBienvenue = new System.Windows.Forms.Label();
            this.labConnexion = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxLogin
            // 
            this.tbxLogin.Location = new System.Drawing.Point(24, 98);
            this.tbxLogin.Name = "tbxLogin";
            this.tbxLogin.Size = new System.Drawing.Size(276, 26);
            this.tbxLogin.TabIndex = 0;
            this.tbxLogin.TextChanged += new System.EventHandler(this.tbxLogin_TextChanged);
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(24, 187);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.PasswordChar = '*';
            this.tbxPassword.Size = new System.Drawing.Size(276, 26);
            this.tbxPassword.TabIndex = 1;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(20, 66);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(135, 20);
            this.lblLogin.TabIndex = 2;
            this.lblLogin.Text = "Identifiant (login) :";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(20, 154);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(113, 20);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Mot de passe :";
            // 
            // btnConnecter
            // 
            this.btnConnecter.Location = new System.Drawing.Point(85, 270);
            this.btnConnecter.Name = "btnConnecter";
            this.btnConnecter.Size = new System.Drawing.Size(147, 32);
            this.btnConnecter.TabIndex = 4;
            this.btnConnecter.Text = "Se connecter";
            this.btnConnecter.UseVisualStyleBackColor = true;
            this.btnConnecter.Click += new System.EventHandler(this.btnConnecter_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnVoirComptes);
            this.panel1.Controls.Add(this.labBienvenue);
            this.panel1.Controls.Add(this.labConnexion);
            this.panel1.Location = new System.Drawing.Point(431, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(343, 236);
            this.panel1.TabIndex = 5;
            // 
            // btnVoirComptes
            // 
            this.btnVoirComptes.Location = new System.Drawing.Point(35, 147);
            this.btnVoirComptes.Name = "btnVoirComptes";
            this.btnVoirComptes.Size = new System.Drawing.Size(193, 48);
            this.btnVoirComptes.TabIndex = 2;
            this.btnVoirComptes.Text = "Lancer L\'application";
            this.btnVoirComptes.UseVisualStyleBackColor = true;
            this.btnVoirComptes.Visible = false;
            this.btnVoirComptes.Click += new System.EventHandler(this.btnVoirComptes_Click);
            // 
            // labBienvenue
            // 
            this.labBienvenue.AutoSize = true;
            this.labBienvenue.Location = new System.Drawing.Point(31, 88);
            this.labBienvenue.Name = "labBienvenue";
            this.labBienvenue.Size = new System.Drawing.Size(92, 20);
            this.labBienvenue.TabIndex = 1;
            this.labBienvenue.Text = "Bienvenue, ";
            this.labBienvenue.Visible = false;
            // 
            // labConnexion
            // 
            this.labConnexion.AutoSize = true;
            this.labConnexion.Location = new System.Drawing.Point(31, 34);
            this.labConnexion.Name = "labConnexion";
            this.labConnexion.Size = new System.Drawing.Size(197, 20);
            this.labConnexion.TabIndex = 0;
            this.labConnexion.Text = "Vous n\'êtes pas connecté.";
            // 
            // FTestConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 349);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnConnecter);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.tbxLogin);
            this.Name = "FTestConnexion";
            this.Text = "Connexion à l\'application";
            this.Load += new System.EventHandler(this.FTestConnexion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxLogin;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnConnecter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnVoirComptes;
        private System.Windows.Forms.Label labBienvenue;
        private System.Windows.Forms.Label labConnexion;
    }
}