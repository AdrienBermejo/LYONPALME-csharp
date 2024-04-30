namespace CreditSio.Forms
{
    partial class F_MainPage
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
            this.OpenF_Materiel = new System.Windows.Forms.Button();
            this.OpenF_Pret = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // OpenF_Materiel
            // 
            this.OpenF_Materiel.Location = new System.Drawing.Point(73, 277);
            this.OpenF_Materiel.Name = "OpenF_Materiel";
            this.OpenF_Materiel.Size = new System.Drawing.Size(110, 48);
            this.OpenF_Materiel.TabIndex = 0;
            this.OpenF_Materiel.Text = "Materiel";
            this.OpenF_Materiel.UseVisualStyleBackColor = true;
            this.OpenF_Materiel.Click += new System.EventHandler(this.OpenF_Materiel_Click);
            // 
            // OpenF_Pret
            // 
            this.OpenF_Pret.Location = new System.Drawing.Point(73, 348);
            this.OpenF_Pret.Name = "OpenF_Pret";
            this.OpenF_Pret.Size = new System.Drawing.Size(110, 48);
            this.OpenF_Pret.TabIndex = 1;
            this.OpenF_Pret.Text = "Pret";
            this.OpenF_Pret.UseVisualStyleBackColor = true;
            this.OpenF_Pret.Click += new System.EventHandler(this.OpenF_Pret_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CreditSio.Properties.Resources.LP;
            this.pictureBox1.Location = new System.Drawing.Point(73, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(468, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // F_MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.OpenF_Pret);
            this.Controls.Add(this.OpenF_Materiel);
            this.Name = "F_MainPage";
            this.Text = "F_MainPage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OpenF_Materiel;
        private System.Windows.Forms.Button OpenF_Pret;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}