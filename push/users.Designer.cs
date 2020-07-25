namespace push
{
    partial class users
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtrecherche = new System.Windows.Forms.TextBox();
            this.btnupdate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmatricule = new System.Windows.Forms.TextBox();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.txtpostnom = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txttel = new System.Windows.Forms.TextBox();
            this.cbxsexe = new System.Windows.Forms.ComboBox();
            this.cbxmatriculestricture = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnmodifier = new System.Windows.Forms.Button();
            this.btnimprimer = new System.Windows.Forms.Button();
            this.btnsupprimer = new System.Windows.Forms.Button();
            this.btnenregistrer = new System.Windows.Forms.Button();
            this.btnquitter = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(276, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(626, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "UTILISATEURS OU COMPTABLES DE LA ZONE";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 254);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(970, 369);
            this.dataGridView1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.txtrecherche);
            this.panel1.Controls.Add(this.btnupdate);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(4, 204);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(969, 51);
            this.panel1.TabIndex = 2;
            // 
            // txtrecherche
            // 
            this.txtrecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrecherche.Location = new System.Drawing.Point(725, 14);
            this.txtrecherche.Multiline = true;
            this.txtrecherche.Name = "txtrecherche";
            this.txtrecherche.Size = new System.Drawing.Size(226, 27);
            this.txtrecherche.TabIndex = 7;
            this.txtrecherche.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnupdate.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.White;
            this.btnupdate.Location = new System.Drawing.Point(3, 6);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(135, 41);
            this.btnupdate.TabIndex = 6;
            this.btnupdate.Text = "UPDATE";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(546, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Rechercher Postnom";
            // 
            // txtmatricule
            // 
            this.txtmatricule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmatricule.Location = new System.Drawing.Point(42, 92);
            this.txtmatricule.Multiline = true;
            this.txtmatricule.Name = "txtmatricule";
            this.txtmatricule.Size = new System.Drawing.Size(220, 28);
            this.txtmatricule.TabIndex = 3;
            // 
            // txtnom
            // 
            this.txtnom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnom.Location = new System.Drawing.Point(42, 163);
            this.txtnom.Multiline = true;
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(220, 28);
            this.txtnom.TabIndex = 3;
            // 
            // txtpostnom
            // 
            this.txtpostnom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpostnom.Location = new System.Drawing.Point(336, 92);
            this.txtpostnom.Multiline = true;
            this.txtpostnom.Name = "txtpostnom";
            this.txtpostnom.Size = new System.Drawing.Size(220, 28);
            this.txtpostnom.TabIndex = 3;
            // 
            // txtpassword
            // 
            this.txtpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.Location = new System.Drawing.Point(646, 92);
            this.txtpassword.Multiline = true;
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(220, 28);
            this.txtpassword.TabIndex = 3;
            // 
            // txttel
            // 
            this.txttel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttel.Location = new System.Drawing.Point(646, 156);
            this.txttel.Multiline = true;
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(220, 28);
            this.txttel.TabIndex = 3;
            // 
            // cbxsexe
            // 
            this.cbxsexe.FormattingEnabled = true;
            this.cbxsexe.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cbxsexe.Location = new System.Drawing.Point(336, 163);
            this.cbxsexe.Name = "cbxsexe";
            this.cbxsexe.Size = new System.Drawing.Size(220, 21);
            this.cbxsexe.TabIndex = 4;
            // 
            // cbxmatriculestricture
            // 
            this.cbxmatriculestricture.FormattingEnabled = true;
            this.cbxmatriculestricture.Location = new System.Drawing.Point(912, 99);
            this.cbxmatriculestricture.Name = "cbxmatriculestricture";
            this.cbxmatriculestricture.Size = new System.Drawing.Size(220, 21);
            this.cbxmatriculestricture.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(38, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Matricule";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(38, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nom";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(332, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Sexe";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(642, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(642, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Tel";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(913, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Nom de la Stricture";
            // 
            // btnmodifier
            // 
            this.btnmodifier.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnmodifier.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnmodifier.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodifier.ForeColor = System.Drawing.Color.White;
            this.btnmodifier.Location = new System.Drawing.Point(997, 294);
            this.btnmodifier.Name = "btnmodifier";
            this.btnmodifier.Size = new System.Drawing.Size(135, 41);
            this.btnmodifier.TabIndex = 6;
            this.btnmodifier.Text = "Modifier";
            this.btnmodifier.UseVisualStyleBackColor = false;
            this.btnmodifier.Click += new System.EventHandler(this.btnmodifier_Click);
            // 
            // btnimprimer
            // 
            this.btnimprimer.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnimprimer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnimprimer.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnimprimer.ForeColor = System.Drawing.Color.White;
            this.btnimprimer.Location = new System.Drawing.Point(997, 467);
            this.btnimprimer.Name = "btnimprimer";
            this.btnimprimer.Size = new System.Drawing.Size(135, 41);
            this.btnimprimer.TabIndex = 6;
            this.btnimprimer.Text = "Imprimer";
            this.btnimprimer.UseVisualStyleBackColor = false;
            this.btnimprimer.Click += new System.EventHandler(this.btnimprimer_Click);
            // 
            // btnsupprimer
            // 
            this.btnsupprimer.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnsupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsupprimer.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsupprimer.ForeColor = System.Drawing.Color.White;
            this.btnsupprimer.Location = new System.Drawing.Point(997, 380);
            this.btnsupprimer.Name = "btnsupprimer";
            this.btnsupprimer.Size = new System.Drawing.Size(135, 41);
            this.btnsupprimer.TabIndex = 6;
            this.btnsupprimer.Text = "Supprimer";
            this.btnsupprimer.UseVisualStyleBackColor = false;
            this.btnsupprimer.Click += new System.EventHandler(this.btnsupprimer_Click);
            // 
            // btnenregistrer
            // 
            this.btnenregistrer.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnenregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnenregistrer.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnenregistrer.ForeColor = System.Drawing.Color.White;
            this.btnenregistrer.Location = new System.Drawing.Point(997, 204);
            this.btnenregistrer.Name = "btnenregistrer";
            this.btnenregistrer.Size = new System.Drawing.Size(135, 41);
            this.btnenregistrer.TabIndex = 6;
            this.btnenregistrer.Text = "Enregistrer";
            this.btnenregistrer.UseVisualStyleBackColor = false;
            this.btnenregistrer.Click += new System.EventHandler(this.btnenregistrer_Click);
            // 
            // btnquitter
            // 
            this.btnquitter.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnquitter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnquitter.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnquitter.ForeColor = System.Drawing.Color.White;
            this.btnquitter.Location = new System.Drawing.Point(997, 560);
            this.btnquitter.Name = "btnquitter";
            this.btnquitter.Size = new System.Drawing.Size(135, 41);
            this.btnquitter.TabIndex = 6;
            this.btnquitter.Text = "Quitter";
            this.btnquitter.UseVisualStyleBackColor = false;
            this.btnquitter.Click += new System.EventHandler(this.btnquitter_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(332, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 20);
            this.label9.TabIndex = 5;
            this.label9.Text = "Post Nom";
            // 
            // users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.Controls.Add(this.btnsupprimer);
            this.Controls.Add(this.btnquitter);
            this.Controls.Add(this.btnimprimer);
            this.Controls.Add(this.btnenregistrer);
            this.Controls.Add(this.btnmodifier);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxmatriculestricture);
            this.Controls.Add(this.cbxsexe);
            this.Controls.Add(this.txttel);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtpostnom);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.txtmatricule);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "users";
            this.Size = new System.Drawing.Size(1147, 626);
            this.Load += new System.EventHandler(this.users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.TextBox txtmatricule;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.TextBox txtpostnom;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.ComboBox cbxsexe;
        private System.Windows.Forms.ComboBox cbxmatriculestricture;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnmodifier;
        private System.Windows.Forms.Button btnimprimer;
        private System.Windows.Forms.Button btnsupprimer;
        private System.Windows.Forms.Button btnenregistrer;
        private System.Windows.Forms.Button btnquitter;
        private System.Windows.Forms.TextBox txtrecherche;
        private System.Windows.Forms.Label label9;
    }
}
