namespace CreditSio.Forms
{
    partial class F_Materiel
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
            this.AddMateriel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddMateriel
            // 
            this.AddMateriel.Location = new System.Drawing.Point(47, 354);
            this.AddMateriel.Name = "AddMateriel";
            this.AddMateriel.Size = new System.Drawing.Size(141, 61);
            this.AddMateriel.TabIndex = 0;
            this.AddMateriel.Text = "Ajout Materiel";
            this.AddMateriel.UseVisualStyleBackColor = true;
            this.AddMateriel.Click += new System.EventHandler(this.AddMateriel_Click);
            // 
            // F_Materiel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddMateriel);
            this.Name = "F_Materiel";
            this.Text = "F_Materiel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddMateriel;
    }
}