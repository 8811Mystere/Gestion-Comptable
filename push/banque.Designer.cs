namespace push
{
    partial class banque
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbxrecherchemoisannee = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.idbq = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbdevisebq = new System.Windows.Forms.ComboBox();
            this.cbcomptebq = new System.Windows.Forms.ComboBox();
            this.cbidtypeopbq = new System.Windows.Forms.ComboBox();
            this.cbmatstructbq = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ttxtmontantbq = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxmoisAnnee = new System.Windows.Forms.ComboBox();
            this.txtdatebq = new System.Windows.Forms.DateTimePicker();
            this.rechercheStructure = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(424, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Opérations de Banque";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 322);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1079, 307);
            this.dataGridView1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkKhaki;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1081, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(147, 629);
            this.panel1.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(1, 300);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 40);
            this.button3.TabIndex = 0;
            this.button3.Text = "Supprimer";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(1, 196);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 40);
            this.button2.TabIndex = 0;
            this.button2.Text = "Modifier";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Enregistrer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkKhaki;
            this.panel2.Controls.Add(this.rechercheStructure);
            this.panel2.Controls.Add(this.cbxrecherchemoisannee);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(0, 265);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1079, 57);
            this.panel2.TabIndex = 3;
            // 
            // cbxrecherchemoisannee
            // 
            this.cbxrecherchemoisannee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxrecherchemoisannee.FormattingEnabled = true;
            this.cbxrecherchemoisannee.Items.AddRange(new object[] {
            "Janvier/2019",
            "Fevrier/2019",
            "Mars/2019",
            "Avril/2019",
            "Mai/2019",
            "Juin/2019",
            "Juillet/2019",
            "Aout/2019",
            "Septembre/2019",
            "Octobre/2019",
            "Novembre/2019",
            "Decembre/2019",
            "Janvier/2020",
            "Fevrier/2020",
            "Mars/2020",
            "Avril/2020",
            "Mai/2020",
            "Juin/2020",
            "Juillet/2020",
            "Aout/2020",
            "Septembre/2020",
            "Octobre/2020",
            "Novembre/2020",
            "Decembre/2020",
            "Janvier/2021",
            "Fevrier/2021",
            "Mars/2021",
            "Avril/2021",
            "Mai/2021",
            "Juin/2021",
            "Juillet/2021",
            "Aout/2021",
            "Septembre/2021",
            "Octobre/2021",
            "Novembre/2021",
            "Decembre/2021",
            "Janvier/2022",
            "Fevrier/2022",
            "Mars/2022",
            "Avril/2022",
            "Mai/2022",
            "Juin/2022",
            "Juillet/2022",
            "Aout/2022",
            "Septembre/2022",
            "Octobre/2022",
            "Novembre/2022",
            "Decembre/2022",
            "Janvier/2023",
            "Fevrier/2023",
            "Mars/2023",
            "Avril/2023",
            "Mai/2023",
            "Juin/2023",
            "Juillet/2023",
            "Aout/2023",
            "Septembre/2023",
            "Octobre/2023",
            "Novembre/2023",
            "Decembre/2023",
            "Janvier/2024",
            "Fevrier/2024",
            "Mars/2024",
            "Avril/2024",
            "Mai/2024",
            "Juin/2024",
            "Juillet/2024",
            "Aout/2024",
            "Septembre/2024",
            "Octobre/2024",
            "Novembre/2024",
            "Decembre/2024",
            "Janvier/2025",
            "Fevrier/2025",
            "Mars/2025",
            "Avril/2025",
            "Mai/2025",
            "Juin/2025",
            "Juillet/2025",
            "Aout/2025",
            "Septembre/2025",
            "Octobre/2025",
            "Novembre/2025",
            "Decembre/2025",
            "Janvier/2026",
            "Fevrier/2026",
            "Mars/2026",
            "Avril/2026",
            "Mai/2026",
            "Juin/2026",
            "Juillet/2026",
            "Aout/2026",
            "Septembre/2026",
            "Octobre/2026",
            "Novembre/2026",
            "Decembre/2026",
            "Janvier/2027",
            "Fevrier/2027",
            "Mars/2027",
            "Avril/2027",
            "Mai/2027",
            "Juin/2027",
            "Juillet/2027",
            "Aout/2027",
            "Septembre/2027",
            "Octobre/2027",
            "Novembre/2027",
            "Decembre/2027",
            "Janvier/2028",
            "Fevrier/2028",
            "Mars/2028",
            "Avril/2028",
            "Mai/2028",
            "Juin/2028",
            "Juillet/2028",
            "Aout/2028",
            "Septembre/2028",
            "Octobre/2028",
            "Novembre/2028",
            "Decembre/2028",
            "Janvier/2029",
            "Fevrier/2029",
            "Mars/2029",
            "Avril/2029",
            "Mai/2029",
            "Juin/2029",
            "Juillet/2029",
            "Aout/2029",
            "Septembre/2029",
            "Octobre/2029",
            "Novembre/2029",
            "Decembre/2029",
            "Janvier/2030",
            "Fevrier/2030",
            "Mars/2030",
            "Avril/2030",
            "Mai/2030",
            "Juin/2030",
            "Juillet/2030",
            "Aout/2030",
            "Septembre/2030",
            "Octobre/2030",
            "Novembre/2030",
            "Decembre/2030",
            "Janvier/2031",
            "Fevrier/2031",
            "Mars/2031",
            "Avril/2031",
            "Mai/2031",
            "Juin/2031",
            "Juillet/2031",
            "Aout/2031",
            "Septembre/2031",
            "Octobre/2031",
            "Novembre/2031",
            "Decembre/2031",
            "Janvier/2032",
            "Fevrier/2032",
            "Mars/2032",
            "Avril/2032",
            "Mai/2032",
            "Juin/2032",
            "Juillet/2032",
            "Aout/2032",
            "Septembre/2032",
            "Octobre/2032",
            "Novembre/2032",
            "Decembre/2032",
            "Janvier/2033",
            "Fevrier/2033",
            "Avril/2033",
            "Mai/2033",
            "Juin/2033",
            "Juillet/2033",
            "Aout/2033",
            "Septembre/2033",
            "Octobre/2033",
            "Novembre/2033",
            "Decembre/2033",
            "Janvier/2034",
            "Fevrier/2034",
            "Mars/2034",
            "Avril/2034",
            "Mai/2034",
            "Juin/2034",
            "Juillet/2034",
            "Aout/2034",
            "Septembre/2034",
            "Octobre/2034",
            "Novembre/2034",
            "Decembre/2034",
            "Janvier/2035",
            "Fevrier/2035",
            "Mars/2035",
            "Avril/2035",
            "Mai/2035",
            "Juin/2035",
            "Juillet/2035",
            "Aout/2035",
            "Septembre/2035",
            "Octobre/2035",
            "Novembre/2035",
            "Decembre/2035",
            "Janvier/2036",
            "Fevrier/2036",
            "Mars/2036",
            "Avril/2036",
            "Mai/2036",
            "Juin/2036",
            "Juillet/2036",
            "Aout/2036",
            "Septembre/2036",
            "Octobre/2036",
            "Novembre/2036",
            "Decembre/2036",
            "Janvier/2037",
            "Fevrier/2037",
            "Mars/2037",
            "Avril/2037",
            "Mai/2037",
            "Juin/2037",
            "Juillet/2037",
            "Aout/2037",
            "Septembre/2037",
            "Octobre/2037",
            "Novembre/2037",
            "Decembre/2037",
            "Janvier/2038",
            "Fevrier/2038",
            "Mars/2038",
            "Avril/2038",
            "Mai/2038",
            "Juin/2038",
            "Juillet/2038",
            "Aout/2038",
            "Septembre/2038",
            "Octobre/2038",
            "Novembre/2038",
            "Decembre/2038",
            "Janvier/2039",
            "Fevrier/2039",
            "Mars/2039",
            "Avril/2039",
            "Mai/2039",
            "Juin/2039",
            "Juillet/2039",
            "Aout/2039",
            "Septembre/2039",
            "Octobre/2039",
            "Novembre/2039",
            "Decembre/2039",
            "Janvier/2040",
            "Fevrier/2040",
            "Mars/2040",
            "Avril/2040",
            "Mai/2040",
            "Juin/2040",
            "Juillet/2040",
            "Aout/2040",
            "Septembre/2040",
            "Octobre/2040",
            "Novembre/2040",
            "Decembre/2040"});
            this.cbxrecherchemoisannee.Location = new System.Drawing.Point(918, 22);
            this.cbxrecherchemoisannee.Name = "cbxrecherchemoisannee";
            this.cbxrecherchemoisannee.Size = new System.Drawing.Size(136, 21);
            this.cbxrecherchemoisannee.TabIndex = 85;
            this.cbxrecherchemoisannee.SelectedIndexChanged += new System.EventHandler(this.cbxrecherchemoisannee_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(789, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 24);
            this.label3.TabIndex = 83;
            this.label3.Text = "Mois et Année";
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(3, 11);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(143, 40);
            this.button4.TabIndex = 0;
            this.button4.Text = "UPDATE";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(448, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 24);
            this.label2.TabIndex = 83;
            this.label2.Text = "Structure";
            // 
            // idbq
            // 
            this.idbq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idbq.Location = new System.Drawing.Point(29, 90);
            this.idbq.Multiline = true;
            this.idbq.Name = "idbq";
            this.idbq.Size = new System.Drawing.Size(54, 38);
            this.idbq.TabIndex = 93;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(561, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 25);
            this.label8.TabIndex = 91;
            this.label8.Text = "MONTANT";
            // 
            // cbdevisebq
            // 
            this.cbdevisebq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbdevisebq.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbdevisebq.FormattingEnabled = true;
            this.cbdevisebq.Items.AddRange(new object[] {
            "FC",
            "$"});
            this.cbdevisebq.Location = new System.Drawing.Point(272, 201);
            this.cbdevisebq.Name = "cbdevisebq";
            this.cbdevisebq.Size = new System.Drawing.Size(233, 33);
            this.cbdevisebq.TabIndex = 90;
            // 
            // cbcomptebq
            // 
            this.cbcomptebq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbcomptebq.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbcomptebq.FormattingEnabled = true;
            this.cbcomptebq.Location = new System.Drawing.Point(852, 201);
            this.cbcomptebq.Name = "cbcomptebq";
            this.cbcomptebq.Size = new System.Drawing.Size(223, 33);
            this.cbcomptebq.TabIndex = 89;
            // 
            // cbidtypeopbq
            // 
            this.cbidtypeopbq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbidtypeopbq.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbidtypeopbq.FormattingEnabled = true;
            this.cbidtypeopbq.Location = new System.Drawing.Point(852, 116);
            this.cbidtypeopbq.Name = "cbidtypeopbq";
            this.cbidtypeopbq.Size = new System.Drawing.Size(223, 33);
            this.cbidtypeopbq.TabIndex = 88;
            // 
            // cbmatstructbq
            // 
            this.cbmatstructbq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmatstructbq.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbmatstructbq.FormattingEnabled = true;
            this.cbmatstructbq.Location = new System.Drawing.Point(566, 201);
            this.cbmatstructbq.Name = "cbmatstructbq";
            this.cbmatstructbq.Size = new System.Drawing.Size(223, 33);
            this.cbmatstructbq.TabIndex = 87;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 25);
            this.label5.TabIndex = 84;
            this.label5.Text = "DATE OPERATION";
            // 
            // ttxtmontantbq
            // 
            this.ttxtmontantbq.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttxtmontantbq.Location = new System.Drawing.Point(566, 116);
            this.ttxtmontantbq.Name = "ttxtmontantbq";
            this.ttxtmontantbq.Size = new System.Drawing.Size(223, 31);
            this.ttxtmontantbq.TabIndex = 86;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(267, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 25);
            this.label7.TabIndex = 83;
            this.label7.Text = "DEVISE";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(847, 173);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(138, 25);
            this.label11.TabIndex = 82;
            this.label11.Text = "ID du compte";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(847, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(232, 25);
            this.label10.TabIndex = 81;
            this.label10.Text = "ID du Type d\'Opération";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(561, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(223, 25);
            this.label9.TabIndex = 80;
            this.label9.Text = "Matricule du Structure";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(268, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(254, 25);
            this.label6.TabIndex = 79;
            this.label6.Text = "Mois/Annee OPERATION";
            // 
            // cbxmoisAnnee
            // 
            this.cbxmoisAnnee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxmoisAnnee.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxmoisAnnee.FormattingEnabled = true;
            this.cbxmoisAnnee.Items.AddRange(new object[] {
            "Janvier/2019",
            "Fevrier/2019",
            "Mars/2019",
            "Avril/2019",
            "Mai/2019",
            "Juin/2019",
            "Juillet/2019",
            "Aout/2019",
            "Septembre/2019",
            "Octobre/2019",
            "Novembre/2019",
            "Decembre/2019",
            "Janvier/2020",
            "Fevrier/2020",
            "Mars/2020",
            "Avril/2020",
            "Mai/2020",
            "Juin/2020",
            "Juillet/2020",
            "Aout/2020",
            "Septembre/2020",
            "Octobre/2020",
            "Novembre/2020",
            "Decembre/2020",
            "Janvier/2021",
            "Fevrier/2021",
            "Mars/2021",
            "Avril/2021",
            "Mai/2021",
            "Juin/2021",
            "Juillet/2021",
            "Aout/2021",
            "Septembre/2021",
            "Octobre/2021",
            "Novembre/2021",
            "Decembre/2021",
            "Janvier/2022",
            "Fevrier/2022",
            "Mars/2022",
            "Avril/2022",
            "Mai/2022",
            "Juin/2022",
            "Juillet/2022",
            "Aout/2022",
            "Septembre/2022",
            "Octobre/2022",
            "Novembre/2022",
            "Decembre/2022",
            "Janvier/2023",
            "Fevrier/2023",
            "Mars/2023",
            "Avril/2023",
            "Mai/2023",
            "Juin/2023",
            "Juillet/2023",
            "Aout/2023",
            "Septembre/2023",
            "Octobre/2023",
            "Novembre/2023",
            "Decembre/2023",
            "Janvier/2024",
            "Fevrier/2024",
            "Mars/2024",
            "Avril/2024",
            "Mai/2024",
            "Juin/2024",
            "Juillet/2024",
            "Aout/2024",
            "Septembre/2024",
            "Octobre/2024",
            "Novembre/2024",
            "Decembre/2024",
            "Janvier/2025",
            "Fevrier/2025",
            "Mars/2025",
            "Avril/2025",
            "Mai/2025",
            "Juin/2025",
            "Juillet/2025",
            "Aout/2025",
            "Septembre/2025",
            "Octobre/2025",
            "Novembre/2025",
            "Decembre/2025",
            "Janvier/2026",
            "Fevrier/2026",
            "Mars/2026",
            "Avril/2026",
            "Mai/2026",
            "Juin/2026",
            "Juillet/2026",
            "Aout/2026",
            "Septembre/2026",
            "Octobre/2026",
            "Novembre/2026",
            "Decembre/2026",
            "Janvier/2027",
            "Fevrier/2027",
            "Mars/2027",
            "Avril/2027",
            "Mai/2027",
            "Juin/2027",
            "Juillet/2027",
            "Aout/2027",
            "Septembre/2027",
            "Octobre/2027",
            "Novembre/2027",
            "Decembre/2027",
            "Janvier/2028",
            "Fevrier/2028",
            "Mars/2028",
            "Avril/2028",
            "Mai/2028",
            "Juin/2028",
            "Juillet/2028",
            "Aout/2028",
            "Septembre/2028",
            "Octobre/2028",
            "Novembre/2028",
            "Decembre/2028",
            "Janvier/2029",
            "Fevrier/2029",
            "Mars/2029",
            "Avril/2029",
            "Mai/2029",
            "Juin/2029",
            "Juillet/2029",
            "Aout/2029",
            "Septembre/2029",
            "Octobre/2029",
            "Novembre/2029",
            "Decembre/2029",
            "Janvier/2030",
            "Fevrier/2030",
            "Mars/2030",
            "Avril/2030",
            "Mai/2030",
            "Juin/2030",
            "Juillet/2030",
            "Aout/2030",
            "Septembre/2030",
            "Octobre/2030",
            "Novembre/2030",
            "Decembre/2030",
            "Janvier/2031",
            "Fevrier/2031",
            "Mars/2031",
            "Avril/2031",
            "Mai/2031",
            "Juin/2031",
            "Juillet/2031",
            "Aout/2031",
            "Septembre/2031",
            "Octobre/2031",
            "Novembre/2031",
            "Decembre/2031",
            "Janvier/2032",
            "Fevrier/2032",
            "Mars/2032",
            "Avril/2032",
            "Mai/2032",
            "Juin/2032",
            "Juillet/2032",
            "Aout/2032",
            "Septembre/2032",
            "Octobre/2032",
            "Novembre/2032",
            "Decembre/2032",
            "Janvier/2033",
            "Fevrier/2033",
            "Avril/2033",
            "Mai/2033",
            "Juin/2033",
            "Juillet/2033",
            "Aout/2033",
            "Septembre/2033",
            "Octobre/2033",
            "Novembre/2033",
            "Decembre/2033",
            "Janvier/2034",
            "Fevrier/2034",
            "Mars/2034",
            "Avril/2034",
            "Mai/2034",
            "Juin/2034",
            "Juillet/2034",
            "Aout/2034",
            "Septembre/2034",
            "Octobre/2034",
            "Novembre/2034",
            "Decembre/2034",
            "Janvier/2035",
            "Fevrier/2035",
            "Mars/2035",
            "Avril/2035",
            "Mai/2035",
            "Juin/2035",
            "Juillet/2035",
            "Aout/2035",
            "Septembre/2035",
            "Octobre/2035",
            "Novembre/2035",
            "Decembre/2035",
            "Janvier/2036",
            "Fevrier/2036",
            "Mars/2036",
            "Avril/2036",
            "Mai/2036",
            "Juin/2036",
            "Juillet/2036",
            "Aout/2036",
            "Septembre/2036",
            "Octobre/2036",
            "Novembre/2036",
            "Decembre/2036",
            "Janvier/2037",
            "Fevrier/2037",
            "Mars/2037",
            "Avril/2037",
            "Mai/2037",
            "Juin/2037",
            "Juillet/2037",
            "Aout/2037",
            "Septembre/2037",
            "Octobre/2037",
            "Novembre/2037",
            "Decembre/2037",
            "Janvier/2038",
            "Fevrier/2038",
            "Mars/2038",
            "Avril/2038",
            "Mai/2038",
            "Juin/2038",
            "Juillet/2038",
            "Aout/2038",
            "Septembre/2038",
            "Octobre/2038",
            "Novembre/2038",
            "Decembre/2038",
            "Janvier/2039",
            "Fevrier/2039",
            "Mars/2039",
            "Avril/2039",
            "Mai/2039",
            "Juin/2039",
            "Juillet/2039",
            "Aout/2039",
            "Septembre/2039",
            "Octobre/2039",
            "Novembre/2039",
            "Decembre/2039",
            "Janvier/2040",
            "Fevrier/2040",
            "Mars/2040",
            "Avril/2040",
            "Mai/2040",
            "Juin/2040",
            "Juillet/2040",
            "Aout/2040",
            "Septembre/2040",
            "Octobre/2040",
            "Novembre/2040",
            "Decembre/2040"});
            this.cbxmoisAnnee.Location = new System.Drawing.Point(273, 116);
            this.cbxmoisAnnee.Name = "cbxmoisAnnee";
            this.cbxmoisAnnee.Size = new System.Drawing.Size(233, 33);
            this.cbxmoisAnnee.TabIndex = 90;
            // 
            // txtdatebq
            // 
            this.txtdatebq.Location = new System.Drawing.Point(25, 207);
            this.txtdatebq.Name = "txtdatebq";
            this.txtdatebq.Size = new System.Drawing.Size(210, 20);
            this.txtdatebq.TabIndex = 94;
            // 
            // rechercheStructure
            // 
            this.rechercheStructure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rechercheStructure.FormattingEnabled = true;
            this.rechercheStructure.Items.AddRange(new object[] {
            "Bureau Central",
            "HGR Kyondo",
            "CSR Kyavinyonge",
            "CSR Kyalumba",
            "CSR Burusi",
            "CS Ngitse",
            "CS Katiri",
            "CS Kalivuli",
            "CS Kivuwe",
            "CSR Museya",
            "CS Kasongwere",
            "CS Vyakuno",
            "CS Kasisi",
            "CS Kitolu",
            "CS Kalengehya",
            "CS Vayana",
            "CS Kirindera",
            "CS Vusorongi",
            "CS Mbungwe",
            "CS Kyangendi",
            "CS Vutumbi",
            "CS Kyondo",
            "CS Vulambayiri",
            "CS Vuhesi"});
            this.rechercheStructure.Location = new System.Drawing.Point(540, 21);
            this.rechercheStructure.Name = "rechercheStructure";
            this.rechercheStructure.Size = new System.Drawing.Size(196, 21);
            this.rechercheStructure.TabIndex = 86;
            this.rechercheStructure.SelectedIndexChanged += new System.EventHandler(this.rechercheStructure_SelectedIndexChanged);
            // 
            // banque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.Controls.Add(this.txtdatebq);
            this.Controls.Add(this.idbq);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbxmoisAnnee);
            this.Controls.Add(this.cbdevisebq);
            this.Controls.Add(this.cbcomptebq);
            this.Controls.Add(this.cbidtypeopbq);
            this.Controls.Add(this.cbmatstructbq);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ttxtmontantbq);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "banque";
            this.Size = new System.Drawing.Size(1228, 629);
            this.Load += new System.EventHandler(this.banque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idbq;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbdevisebq;
        private System.Windows.Forms.ComboBox cbcomptebq;
        private System.Windows.Forms.ComboBox cbidtypeopbq;
        private System.Windows.Forms.ComboBox cbmatstructbq;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ttxtmontantbq;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxmoisAnnee;
        private System.Windows.Forms.DateTimePicker txtdatebq;
        private System.Windows.Forms.ComboBox cbxrecherchemoisannee;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox rechercheStructure;
    }
}
