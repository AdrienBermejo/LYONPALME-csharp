
namespace CreditSio.Forms
{
    partial class FTestsComptes
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
            this.lvComptes = new System.Windows.Forms.ListView();
            this.TypeCompte = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SOLDE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DECOUVERT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TYPEEPARGNE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TAUXINTERET = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvComptes
            // 
            this.lvComptes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TypeCompte,
            this.ID,
            this.SOLDE,
            this.DECOUVERT,
            this.TYPEEPARGNE,
            this.TAUXINTERET});
            this.lvComptes.HideSelection = false;
            this.lvComptes.Location = new System.Drawing.Point(29, 24);
            this.lvComptes.Name = "lvComptes";
            this.lvComptes.Size = new System.Drawing.Size(1032, 502);
            this.lvComptes.TabIndex = 0;
            this.lvComptes.UseCompatibleStateImageBehavior = false;
            this.lvComptes.View = System.Windows.Forms.View.Details;
            // 
            // TypeCompte
            // 
            this.TypeCompte.Text = "TYPE du COMPTE";
            this.TypeCompte.Width = 165;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // SOLDE
            // 
            this.SOLDE.Text = "SOLDE";
            this.SOLDE.Width = 84;
            // 
            // DECOUVERT
            // 
            this.DECOUVERT.Text = "DECOUVERT AUTORISE";
            this.DECOUVERT.Width = 207;
            // 
            // TYPEEPARGNE
            // 
            this.TYPEEPARGNE.Text = "TYPE EPARGNE";
            this.TYPEEPARGNE.Width = 185;
            // 
            // TAUXINTERET
            // 
            this.TAUXINTERET.Text = "TAUX INTERETS";
            this.TAUXINTERET.Width = 150;
            // 
            // FTestsComptes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 682);
            this.Controls.Add(this.lvComptes);
            this.Name = "FTestsComptes";
            this.Text = "FTestsComptes";
            this.Load += new System.EventHandler(this.FTestsComptes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvComptes;
        private System.Windows.Forms.ColumnHeader TypeCompte;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader SOLDE;
        private System.Windows.Forms.ColumnHeader DECOUVERT;
        private System.Windows.Forms.ColumnHeader TYPEEPARGNE;
        private System.Windows.Forms.ColumnHeader TAUXINTERET;
    }
}