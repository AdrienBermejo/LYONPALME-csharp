namespace CreditSio.Forms
{
    partial class F_AjouterPret
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.EnvoiePret = new System.Windows.Forms.Button();
            this.DateTime = new System.Windows.Forms.DateTimePicker();
            this.Input_EtatPret = new System.Windows.Forms.TextBox();
            this.Input_CodeMateriel = new System.Windows.Forms.TextBox();
            this.Input_NumeroNageur = new System.Windows.Forms.TextBox();
            this.Input_CodePret = new System.Windows.Forms.TextBox();
            this.dStock = new System.Windows.Forms.ListView();
            this.IDMat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identifiant";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numéro du Nageur";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Code du Materiel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date du Pret";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Etat du Materiel";
            // 
            // EnvoiePret
            // 
            this.EnvoiePret.Location = new System.Drawing.Point(293, 365);
            this.EnvoiePret.Name = "EnvoiePret";
            this.EnvoiePret.Size = new System.Drawing.Size(139, 42);
            this.EnvoiePret.TabIndex = 5;
            this.EnvoiePret.Text = "Valider";
            this.EnvoiePret.UseVisualStyleBackColor = true;
            this.EnvoiePret.Click += new System.EventHandler(this.EnvoiePret_Click);
            // 
            // DateTime
            // 
            this.DateTime.Location = new System.Drawing.Point(264, 251);
            this.DateTime.Name = "DateTime";
            this.DateTime.Size = new System.Drawing.Size(200, 26);
            this.DateTime.TabIndex = 6;
            this.DateTime.ValueChanged += new System.EventHandler(this.DateTime_ValueChanged);
            // 
            // Input_EtatPret
            // 
            this.Input_EtatPret.Location = new System.Drawing.Point(264, 312);
            this.Input_EtatPret.Name = "Input_EtatPret";
            this.Input_EtatPret.Size = new System.Drawing.Size(200, 26);
            this.Input_EtatPret.TabIndex = 7;
            this.Input_EtatPret.TextChanged += new System.EventHandler(this.Input_EtatPret_TextChanged);
            // 
            // Input_CodeMateriel
            // 
            this.Input_CodeMateriel.Location = new System.Drawing.Point(264, 190);
            this.Input_CodeMateriel.Name = "Input_CodeMateriel";
            this.Input_CodeMateriel.Size = new System.Drawing.Size(200, 26);
            this.Input_CodeMateriel.TabIndex = 8;
            this.Input_CodeMateriel.TextChanged += new System.EventHandler(this.Input_CodeMateriel_TextChanged);
            // 
            // Input_NumeroNageur
            // 
            this.Input_NumeroNageur.Location = new System.Drawing.Point(264, 126);
            this.Input_NumeroNageur.Name = "Input_NumeroNageur";
            this.Input_NumeroNageur.Size = new System.Drawing.Size(200, 26);
            this.Input_NumeroNageur.TabIndex = 9;
            this.Input_NumeroNageur.TextChanged += new System.EventHandler(this.Input_NumeroNageur_TextChanged);
            // 
            // Input_CodePret
            // 
            this.Input_CodePret.Location = new System.Drawing.Point(264, 62);
            this.Input_CodePret.Name = "Input_CodePret";
            this.Input_CodePret.Size = new System.Drawing.Size(200, 26);
            this.Input_CodePret.TabIndex = 10;
            this.Input_CodePret.TextChanged += new System.EventHandler(this.Input_CodePret_TextChanged);
            // 
            // dStock
            // 
            this.dStock.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IDMat});
            this.dStock.HideSelection = false;
            this.dStock.Location = new System.Drawing.Point(547, 62);
            this.dStock.Name = "dStock";
            this.dStock.Size = new System.Drawing.Size(207, 118);
            this.dStock.TabIndex = 11;
            this.dStock.UseCompatibleStateImageBehavior = false;
            this.dStock.View = System.Windows.Forms.View.Details;
            this.dStock.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // IDMat
            // 
            this.IDMat.Text = "Dernier ID utilisé";
            this.IDMat.Width = 211;
            // 
            // F_AjouterPret
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dStock);
            this.Controls.Add(this.Input_CodePret);
            this.Controls.Add(this.Input_NumeroNageur);
            this.Controls.Add(this.Input_CodeMateriel);
            this.Controls.Add(this.Input_EtatPret);
            this.Controls.Add(this.DateTime);
            this.Controls.Add(this.EnvoiePret);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "F_AjouterPret";
            this.Text = "F_Pret";
            this.Load += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button EnvoiePret;
        private System.Windows.Forms.DateTimePicker DateTime;
        private System.Windows.Forms.TextBox Input_EtatPret;
        private System.Windows.Forms.TextBox Input_CodeMateriel;
        private System.Windows.Forms.TextBox Input_NumeroNageur;
        private System.Windows.Forms.TextBox Input_CodePret;
        private System.Windows.Forms.ListView dStock;
        private System.Windows.Forms.ColumnHeader IDMat;
    }
}