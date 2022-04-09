namespace Series
{
    partial class Form4
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
            this.PN_afficher = new System.Windows.Forms.Panel();
            this.button = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nomSerie = new System.Windows.Forms.ListBox();
            this.PN_search = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.bt_new = new System.Windows.Forms.Button();
            this.BT_rechercher = new System.Windows.Forms.Button();
            this.CB_donnee = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PN_saveterminer = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.BT_saveterminer = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.XX = new System.Windows.Forms.Label();
            this.noter = new System.Windows.Forms.Button();
            this.PN_afficher.SuspendLayout();
            this.PN_search.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.PN_saveterminer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.SuspendLayout();
            // 
            // PN_afficher
            // 
            this.PN_afficher.Controls.Add(this.button);
            this.PN_afficher.Controls.Add(this.label10);
            this.PN_afficher.Controls.Add(this.label9);
            this.PN_afficher.Controls.Add(this.label3);
            this.PN_afficher.Controls.Add(this.label2);
            this.PN_afficher.Controls.Add(this.label1);
            this.PN_afficher.Controls.Add(this.nomSerie);
            this.PN_afficher.Location = new System.Drawing.Point(72, 90);
            this.PN_afficher.Margin = new System.Windows.Forms.Padding(4);
            this.PN_afficher.Name = "PN_afficher";
            this.PN_afficher.Size = new System.Drawing.Size(448, 112);
            this.PN_afficher.TabIndex = 7;
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(-81, -36);
            this.button.Margin = new System.Windows.Forms.Padding(4);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(133, 28);
            this.button.TabIndex = 19;
            this.button.Text = "acceuil";
            this.button.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(46, 73);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 17);
            this.label10.TabIndex = 13;
            this.label10.Text = "Saison en cours :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 90);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 17);
            this.label9.TabIndex = 12;
            this.label9.Text = "Épisode en cours :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nombres d\'épisodes :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre de Saison :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nom Série :";
            // 
            // nomSerie
            // 
            this.nomSerie.FormattingEnabled = true;
            this.nomSerie.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.nomSerie.ItemHeight = 16;
            this.nomSerie.Location = new System.Drawing.Point(172, 20);
            this.nomSerie.Margin = new System.Windows.Forms.Padding(4);
            this.nomSerie.Name = "nomSerie";
            this.nomSerie.Size = new System.Drawing.Size(263, 84);
            this.nomSerie.TabIndex = 3;
            // 
            // PN_search
            // 
            this.PN_search.Controls.Add(this.button2);
            this.PN_search.Controls.Add(this.bt_new);
            this.PN_search.Controls.Add(this.BT_rechercher);
            this.PN_search.Controls.Add(this.CB_donnee);
            this.PN_search.Location = new System.Drawing.Point(528, 90);
            this.PN_search.Margin = new System.Windows.Forms.Padding(4);
            this.PN_search.Name = "PN_search";
            this.PN_search.Size = new System.Drawing.Size(235, 297);
            this.PN_search.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(51, 120);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Noter/Commenter";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bt_new
            // 
            this.bt_new.Location = new System.Drawing.Point(51, 84);
            this.bt_new.Margin = new System.Windows.Forms.Padding(4);
            this.bt_new.Name = "bt_new";
            this.bt_new.Size = new System.Drawing.Size(133, 28);
            this.bt_new.TabIndex = 9;
            this.bt_new.Text = "Nouvelle Serie";
            this.bt_new.UseVisualStyleBackColor = true;
            this.bt_new.Click += new System.EventHandler(this.bt_new_Click);
            // 
            // BT_rechercher
            // 
            this.BT_rechercher.Location = new System.Drawing.Point(51, 48);
            this.BT_rechercher.Margin = new System.Windows.Forms.Padding(4);
            this.BT_rechercher.Name = "BT_rechercher";
            this.BT_rechercher.Size = new System.Drawing.Size(133, 28);
            this.BT_rechercher.TabIndex = 3;
            this.BT_rechercher.Text = "Rechercher";
            this.BT_rechercher.UseVisualStyleBackColor = true;
            this.BT_rechercher.Click += new System.EventHandler(this.BT_rechercher_Click);
            // 
            // CB_donnee
            // 
            this.CB_donnee.FormattingEnabled = true;
            this.CB_donnee.Location = new System.Drawing.Point(51, 15);
            this.CB_donnee.Margin = new System.Windows.Forms.Padding(4);
            this.CB_donnee.Name = "CB_donnee";
            this.CB_donnee.Size = new System.Drawing.Size(132, 24);
            this.CB_donnee.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.noter);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(72, 341);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(448, 97);
            this.panel1.TabIndex = 15;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(131, 43);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(133, 22);
            this.numericUpDown1.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 43);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Note :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 13);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Commentaire :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(131, 13);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 0;
            // 
            // PN_saveterminer
            // 
            this.PN_saveterminer.Controls.Add(this.label6);
            this.PN_saveterminer.Controls.Add(this.BT_saveterminer);
            this.PN_saveterminer.Controls.Add(this.label11);
            this.PN_saveterminer.Controls.Add(this.label12);
            this.PN_saveterminer.Controls.Add(this.numericUpDown2);
            this.PN_saveterminer.Controls.Add(this.numericUpDown3);
            this.PN_saveterminer.Location = new System.Drawing.Point(72, 210);
            this.PN_saveterminer.Margin = new System.Windows.Forms.Padding(4);
            this.PN_saveterminer.Name = "PN_saveterminer";
            this.PN_saveterminer.Size = new System.Drawing.Size(448, 123);
            this.PN_saveterminer.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(88, 14);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ou vous en êtes vous arrété ?";
            // 
            // BT_saveterminer
            // 
            this.BT_saveterminer.Location = new System.Drawing.Point(127, 76);
            this.BT_saveterminer.Margin = new System.Windows.Forms.Padding(4);
            this.BT_saveterminer.Name = "BT_saveterminer";
            this.BT_saveterminer.Size = new System.Drawing.Size(133, 28);
            this.BT_saveterminer.TabIndex = 8;
            this.BT_saveterminer.Text = "Enregistrer";
            this.BT_saveterminer.UseVisualStyleBackColor = true;
            this.BT_saveterminer.Click += new System.EventHandler(this.BT_saveterminer_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(192, 47);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 17);
            this.label11.TabIndex = 9;
            this.label11.Text = "Episode :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 47);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 17);
            this.label12.TabIndex = 8;
            this.label12.Text = "Saison :";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(92, 44);
            this.numericUpDown2.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(67, 22);
            this.numericUpDown2.TabIndex = 5;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(268, 44);
            this.numericUpDown3.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(67, 22);
            this.numericUpDown3.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 28);
            this.button1.TabIndex = 19;
            this.button1.Text = "accueil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // XX
            // 
            this.XX.AutoSize = true;
            this.XX.Location = new System.Drawing.Point(177, 21);
            this.XX.Name = "XX";
            this.XX.Size = new System.Drawing.Size(26, 17);
            this.XX.TabIndex = 20;
            this.XX.Text = "XX";
            // 
            // noter
            // 
            this.noter.Location = new System.Drawing.Point(270, 12);
            this.noter.Name = "noter";
            this.noter.Size = new System.Drawing.Size(75, 23);
            this.noter.TabIndex = 4;
            this.noter.Text = "Envoyer";
            this.noter.UseVisualStyleBackColor = true;
            this.noter.Click += new System.EventHandler(this.noter_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.XX);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PN_saveterminer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PN_search);
            this.Controls.Add(this.PN_afficher);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form4";
            this.Text = "Modification et Charactéristiques";
            this.PN_afficher.ResumeLayout(false);
            this.PN_afficher.PerformLayout();
            this.PN_search.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.PN_saveterminer.ResumeLayout(false);
            this.PN_saveterminer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PN_afficher;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox nomSerie;
        private System.Windows.Forms.Panel PN_search;
        private System.Windows.Forms.Button bt_new;
        private System.Windows.Forms.Button BT_rechercher;
        private System.Windows.Forms.ComboBox CB_donnee;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel PN_saveterminer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BT_saveterminer;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label XX;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button noter;
    }
}