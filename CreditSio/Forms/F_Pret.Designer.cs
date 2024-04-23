namespace CreditSio.Forms
{
    partial class F_Pret
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
            this.button1 = new System.Windows.Forms.Button();
            this.NumPret = new System.Windows.Forms.TextBox();
            this.SuprPret = new System.Windows.Forms.Button();
            this.TextSupr = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Numero = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Marque = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Taille = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pointure = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prenom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(280, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ajouter un Pret";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NumPret
            // 
            this.NumPret.Location = new System.Drawing.Point(50, 361);
            this.NumPret.Name = "NumPret";
            this.NumPret.Size = new System.Drawing.Size(125, 26);
            this.NumPret.TabIndex = 1;
            // 
            // SuprPret
            // 
            this.SuprPret.Location = new System.Drawing.Point(26, 402);
            this.SuprPret.Name = "SuprPret";
            this.SuprPret.Size = new System.Drawing.Size(163, 36);
            this.SuprPret.TabIndex = 2;
            this.SuprPret.Text = "Suprimer un Pret";
            this.SuprPret.UseVisualStyleBackColor = true;
            // 
            // TextSupr
            // 
            this.TextSupr.AutoSize = true;
            this.TextSupr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.TextSupr.ForeColor = System.Drawing.Color.Snow;
            this.TextSupr.Location = new System.Drawing.Point(-7, 284);
            this.TextSupr.Name = "TextSupr";
            this.TextSupr.Padding = new System.Windows.Forms.Padding(50, 3, 80, 3);
            this.TextSupr.Size = new System.Drawing.Size(261, 26);
            this.TextSupr.TabIndex = 3;
            this.TextSupr.Text = "Suprimer un pret ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(229, 284);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10, 50, 15, 150);
            this.label1.Size = new System.Drawing.Size(25, 220);
            this.label1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Numero du Pret :";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Numero,
            this.Marque,
            this.Type,
            this.Taille,
            this.Pointure,
            this.Nom,
            this.Prenom,
            this.DateD});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(26, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(746, 234);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Numero
            // 
            this.Numero.Text = "Numero Materiel";
            // 
            // Marque
            // 
            this.Marque.Text = "Marque";
            // 
            // Type
            // 
            this.Type.Text = "Type";
            // 
            // Taille
            // 
            this.Taille.Text = "Taille";
            // 
            // Pointure
            // 
            this.Pointure.Text = "Pointure";
            // 
            // Nom
            // 
            this.Nom.Text = "Nom";
            // 
            // Prenom
            // 
            this.Prenom.Text = "Prenom";
            // 
            // DateD
            // 
            this.DateD.Text = "DateDebut";
            // 
            // F_Pret
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextSupr);
            this.Controls.Add(this.SuprPret);
            this.Controls.Add(this.NumPret);
            this.Controls.Add(this.button1);
            this.Name = "F_Pret";
            this.Text = "F_AjoutPret";
            this.ResumeLayout(false);
            this.PerformLayout();
            this.Load += new System.EventHandler(this.listView1_SelectedIndexChanged);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox NumPret;
        private System.Windows.Forms.Button SuprPret;
        private System.Windows.Forms.Label TextSupr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Numero;
        private System.Windows.Forms.ColumnHeader Marque;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader Taille;
        private System.Windows.Forms.ColumnHeader Pointure;
        private System.Windows.Forms.ColumnHeader Nom;
        private System.Windows.Forms.ColumnHeader Prenom;
        private System.Windows.Forms.ColumnHeader DateD;
    }
}