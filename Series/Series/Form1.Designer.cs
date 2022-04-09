namespace Series
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
            this.CB_donnee = new System.Windows.Forms.ComboBox();
            this.nomSerie = new System.Windows.Forms.ListBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.PN_search = new System.Windows.Forms.Panel();
            this.bt_new = new System.Windows.Forms.Button();
            this.BT_rechercher = new System.Windows.Forms.Button();
            this.PN_afficher = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lb_9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.PN_saveterminer = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.BT_saveterminer = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_valider = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_nbrepisode = new System.Windows.Forms.TextBox();
            this.tb_nbresaison = new System.Windows.Forms.TextBox();
            this.tb_nomserie = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lb_pseudo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.PN_search.SuspendLayout();
            this.PN_afficher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.PN_saveterminer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CB_donnee
            // 
            this.CB_donnee.FormattingEnabled = true;
            this.CB_donnee.Location = new System.Drawing.Point(38, 12);
            this.CB_donnee.Name = "CB_donnee";
            this.CB_donnee.Size = new System.Drawing.Size(100, 21);
            this.CB_donnee.TabIndex = 2;
            this.CB_donnee.SelectedIndexChanged += new System.EventHandler(this.CB_donnee_SelectedIndexChanged);
            // 
            // nomSerie
            // 
            this.nomSerie.FormattingEnabled = true;
            this.nomSerie.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.nomSerie.Location = new System.Drawing.Point(129, 16);
            this.nomSerie.Name = "nomSerie";
            this.nomSerie.Size = new System.Drawing.Size(198, 108);
            this.nomSerie.TabIndex = 3;
            this.nomSerie.SelectedIndexChanged += new System.EventHandler(this.nomSerie_SelectedIndexChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(201, 36);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(50, 20);
            this.numericUpDown1.TabIndex = 4;
            // 
            // PN_search
            // 
            this.PN_search.Controls.Add(this.bt_new);
            this.PN_search.Controls.Add(this.BT_rechercher);
            this.PN_search.Controls.Add(this.CB_donnee);
            this.PN_search.Location = new System.Drawing.Point(342, 24);
            this.PN_search.Name = "PN_search";
            this.PN_search.Size = new System.Drawing.Size(176, 241);
            this.PN_search.TabIndex = 5;
            this.PN_search.Paint += new System.Windows.Forms.PaintEventHandler(this.PN_search_Paint);
            // 
            // bt_new
            // 
            this.bt_new.Location = new System.Drawing.Point(38, 68);
            this.bt_new.Name = "bt_new";
            this.bt_new.Size = new System.Drawing.Size(100, 23);
            this.bt_new.TabIndex = 9;
            this.bt_new.Text = "Nouvelle Serie";
            this.bt_new.UseVisualStyleBackColor = true;
            this.bt_new.Click += new System.EventHandler(this.bt_new_Click);
            // 
            // BT_rechercher
            // 
            this.BT_rechercher.Location = new System.Drawing.Point(38, 39);
            this.BT_rechercher.Name = "BT_rechercher";
            this.BT_rechercher.Size = new System.Drawing.Size(100, 23);
            this.BT_rechercher.TabIndex = 3;
            this.BT_rechercher.Text = "Rechercher";
            this.BT_rechercher.UseVisualStyleBackColor = true;
            this.BT_rechercher.Click += new System.EventHandler(this.BT_rechercher_Click);
            // 
            // PN_afficher
            // 
            this.PN_afficher.Controls.Add(this.label10);
            this.PN_afficher.Controls.Add(this.label9);
            this.PN_afficher.Controls.Add(this.lb_9);
            this.PN_afficher.Controls.Add(this.label8);
            this.PN_afficher.Controls.Add(this.label7);
            this.PN_afficher.Controls.Add(this.label3);
            this.PN_afficher.Controls.Add(this.label2);
            this.PN_afficher.Controls.Add(this.label1);
            this.PN_afficher.Controls.Add(this.nomSerie);
            this.PN_afficher.Location = new System.Drawing.Point(0, 24);
            this.PN_afficher.Name = "PN_afficher";
            this.PN_afficher.Size = new System.Drawing.Size(336, 135);
            this.PN_afficher.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(34, 109);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Saison en cours :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Épisode en cours :";
            // 
            // lb_9
            // 
            this.lb_9.AutoSize = true;
            this.lb_9.Location = new System.Drawing.Point(73, 15);
            this.lb_9.Name = "lb_9";
            this.lb_9.Size = new System.Drawing.Size(49, 13);
            this.lb_9.TabIndex = 11;
            this.lb_9.Text = "ID série :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(51, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "ID utilisateur :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(73, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "ID série :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nombres d\'épisodes :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre de Saison :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nom Série :";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(69, 36);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(50, 20);
            this.numericUpDown2.TabIndex = 5;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // PN_saveterminer
            // 
            this.PN_saveterminer.Controls.Add(this.label6);
            this.PN_saveterminer.Controls.Add(this.BT_saveterminer);
            this.PN_saveterminer.Controls.Add(this.label5);
            this.PN_saveterminer.Controls.Add(this.label4);
            this.PN_saveterminer.Controls.Add(this.numericUpDown2);
            this.PN_saveterminer.Controls.Add(this.numericUpDown1);
            this.PN_saveterminer.Location = new System.Drawing.Point(0, 165);
            this.PN_saveterminer.Name = "PN_saveterminer";
            this.PN_saveterminer.Size = new System.Drawing.Size(336, 100);
            this.PN_saveterminer.TabIndex = 7;
            this.PN_saveterminer.Paint += new System.Windows.Forms.PaintEventHandler(this.PN_saveterminer_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ou vous en êtes vous arrété ?";
            // 
            // BT_saveterminer
            // 
            this.BT_saveterminer.Location = new System.Drawing.Point(95, 62);
            this.BT_saveterminer.Name = "BT_saveterminer";
            this.BT_saveterminer.Size = new System.Drawing.Size(100, 23);
            this.BT_saveterminer.TabIndex = 8;
            this.BT_saveterminer.Text = "Enregistrer";
            this.BT_saveterminer.UseVisualStyleBackColor = true;
            this.BT_saveterminer.Click += new System.EventHandler(this.BT_saveterminer_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(144, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Episode :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Saison :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bt_valider);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.tb_nbrepisode);
            this.panel1.Controls.Add(this.tb_nbresaison);
            this.panel1.Controls.Add(this.tb_nomserie);
            this.panel1.Location = new System.Drawing.Point(0, 271);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(518, 82);
            this.panel1.TabIndex = 8;
            // 
            // bt_valider
            // 
            this.bt_valider.Location = new System.Drawing.Point(227, 27);
            this.bt_valider.Name = "bt_valider";
            this.bt_valider.Size = new System.Drawing.Size(100, 23);
            this.bt_valider.TabIndex = 10;
            this.bt_valider.Text = "Valider";
            this.bt_valider.UseVisualStyleBackColor = true;
            this.bt_valider.Click += new System.EventHandler(this.bt_valider_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(5, 58);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(108, 13);
            this.label14.TabIndex = 14;
            this.label14.Text = "Nombres d\'épisodes :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "Nombre de Saison :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(51, 6);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Nom Série :";
            // 
            // tb_nbrepisode
            // 
            this.tb_nbrepisode.Location = new System.Drawing.Point(119, 55);
            this.tb_nbrepisode.Name = "tb_nbrepisode";
            this.tb_nbrepisode.Size = new System.Drawing.Size(100, 20);
            this.tb_nbrepisode.TabIndex = 17;
            // 
            // tb_nbresaison
            // 
            this.tb_nbresaison.Location = new System.Drawing.Point(119, 29);
            this.tb_nbresaison.Name = "tb_nbresaison";
            this.tb_nbresaison.Size = new System.Drawing.Size(100, 20);
            this.tb_nbresaison.TabIndex = 16;
            // 
            // tb_nomserie
            // 
            this.tb_nomserie.Location = new System.Drawing.Point(119, 3);
            this.tb_nomserie.Name = "tb_nomserie";
            this.tb_nomserie.Size = new System.Drawing.Size(100, 20);
            this.tb_nomserie.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(174, 5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Bienvenue :";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // lb_pseudo
            // 
            this.lb_pseudo.AutoSize = true;
            this.lb_pseudo.Location = new System.Drawing.Point(238, 5);
            this.lb_pseudo.Name = "lb_pseudo";
            this.lb_pseudo.Size = new System.Drawing.Size(0, 13);
            this.lb_pseudo.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 372);
            this.Controls.Add(this.lb_pseudo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PN_saveterminer);
            this.Controls.Add(this.PN_afficher);
            this.Controls.Add(this.PN_search);
            this.Name = "Form1";
            this.Text = "Série";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.PN_search.ResumeLayout(false);
            this.PN_afficher.ResumeLayout(false);
            this.PN_afficher.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.PN_saveterminer.ResumeLayout(false);
            this.PN_saveterminer.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox CB_donnee;
        private System.Windows.Forms.ListBox nomSerie;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Panel PN_search;
        private System.Windows.Forms.Button BT_rechercher;
        private System.Windows.Forms.Panel PN_afficher;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Panel PN_saveterminer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BT_saveterminer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bt_new;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lb_9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_valider;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_nbrepisode;
        private System.Windows.Forms.TextBox tb_nbresaison;
        private System.Windows.Forms.TextBox tb_nomserie;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lb_pseudo;
    }
}

