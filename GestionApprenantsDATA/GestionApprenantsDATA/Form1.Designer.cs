namespace GestionApprenantsDATA
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.prenom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ville = new System.Windows.Forms.ComboBox();
            this.pays = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.adresse = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.specialite = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1263, 181);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // nom
            // 
            this.nom.Location = new System.Drawing.Point(173, 291);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(229, 22);
            this.nom.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(466, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Prenom :";
            // 
            // prenom
            // 
            this.prenom.Location = new System.Drawing.Point(546, 291);
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(224, 22);
            this.prenom.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(113, 364);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Email :";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(173, 359);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(375, 22);
            this.email.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(466, 435);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "Ville :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(113, 435);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Pays :";
            // 
            // ville
            // 
            this.ville.FormattingEnabled = true;
            this.ville.Location = new System.Drawing.Point(546, 428);
            this.ville.Name = "ville";
            this.ville.Size = new System.Drawing.Size(224, 24);
            this.ville.TabIndex = 20;
            // 
            // pays
            // 
            this.pays.FormattingEnabled = true;
            this.pays.Location = new System.Drawing.Point(173, 428);
            this.pays.Name = "pays";
            this.pays.Size = new System.Drawing.Size(215, 24);
            this.pays.TabIndex = 19;
            this.pays.SelectedIndexChanged += new System.EventHandler(this.pays_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(831, 435);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 17);
            this.label8.TabIndex = 26;
            this.label8.Text = "Spécialité :";
            // 
            // adresse
            // 
            this.adresse.Location = new System.Drawing.Point(838, 359);
            this.adresse.Name = "adresse";
            this.adresse.Size = new System.Drawing.Size(333, 22);
            this.adresse.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(744, 362);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 28;
            this.label5.Text = "Adresse :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(378, 491);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 52);
            this.button1.TabIndex = 29;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(599, 491);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 52);
            this.button2.TabIndex = 30;
            this.button2.Text = "Modifier";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(825, 491);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 52);
            this.button3.TabIndex = 31;
            this.button3.Text = "Supprimer";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1041, 491);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(130, 52);
            this.button4.TabIndex = 32;
            this.button4.Text = "Actualisé";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(835, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 34;
            this.label3.Text = "Téléphone :";
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(947, 291);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(224, 22);
            this.phone.TabIndex = 33;
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(623, 240);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(77, 22);
            this.ID.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(543, 245);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 17);
            this.label9.TabIndex = 36;
            this.label9.Text = "ID :";
            // 
            // specialite
            // 
            this.specialite.FormattingEnabled = true;
            this.specialite.Location = new System.Drawing.Point(947, 428);
            this.specialite.Name = "specialite";
            this.specialite.Size = new System.Drawing.Size(224, 24);
            this.specialite.TabIndex = 37;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(173, 491);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(130, 52);
            this.button5.TabIndex = 38;
            this.button5.Text = "Nombre Apprenants";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 575);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.specialite);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.adresse);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ville);
            this.Controls.Add(this.pays);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.prenom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox prenom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ville;
        private System.Windows.Forms.ComboBox pays;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox adresse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox specialite;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button button5;
    }
}

