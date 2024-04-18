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
            this.listStock = new System.Windows.Forms.ListView();
            this.Materiel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Taille = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pointure = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantite = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            // listStock
            // 
            this.listStock.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Materiel,
            this.Taille,
            this.Pointure,
            this.Quantite});
            this.listStock.HideSelection = false;
            this.listStock.Location = new System.Drawing.Point(47, 42);
            this.listStock.Name = "listStock";
            this.listStock.Size = new System.Drawing.Size(565, 233);
            this.listStock.TabIndex = 0;
            this.listStock.UseCompatibleStateImageBehavior = false;
            this.listStock.View = System.Windows.Forms.View.Details;
            this.listStock.SelectedIndexChanged += new System.EventHandler(this.F_StockLoad);
            // 
            // Materiel
            // 
            this.Materiel.Text = "Materiel";
            this.Materiel.Width = 84;
            // 
            // Taille
            // 
            this.Taille.Text = "Taille";
            this.Taille.Width = 70;
            // 
            // Pointure
            // 
            this.Pointure.Text = "Pointure";
            this.Pointure.Width = 93;
            // 
            // Quantite
            // 
            this.Quantite.Text = "Quantite";
            this.Quantite.Width = 86;
            // 
            // F_Materiel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listStock);
            this.Controls.Add(this.AddMateriel);
            this.Name = "F_Materiel";
            this.Text = "F_Materiel";
            this.Load += new System.EventHandler(this.F_StockLoad);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddMateriel;
        private System.Windows.Forms.ListView listStock;
        private System.Windows.Forms.ColumnHeader Materiel;
        private System.Windows.Forms.ColumnHeader Taille;
        private System.Windows.Forms.ColumnHeader Pointure;
        private System.Windows.Forms.ColumnHeader Quantite;
    }
}