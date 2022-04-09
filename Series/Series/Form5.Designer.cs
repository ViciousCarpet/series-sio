namespace Series
{
    partial class Form5
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_valider = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_nbrepisode = new System.Windows.Forms.TextBox();
            this.tb_nbresaison = new System.Windows.Forms.TextBox();
            this.tb_nomserie = new System.Windows.Forms.TextBox();
            this.button = new System.Windows.Forms.Button();
            this.XX = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.panel1.Location = new System.Drawing.Point(33, 65);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(691, 175);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // bt_valider
            // 
            this.bt_valider.Location = new System.Drawing.Point(319, 63);
            this.bt_valider.Margin = new System.Windows.Forms.Padding(4);
            this.bt_valider.Name = "bt_valider";
            this.bt_valider.Size = new System.Drawing.Size(133, 28);
            this.bt_valider.TabIndex = 10;
            this.bt_valider.Text = "Valider";
            this.bt_valider.UseVisualStyleBackColor = true;
            this.bt_valider.Click += new System.EventHandler(this.bt_valider_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(23, 101);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(145, 17);
            this.label14.TabIndex = 14;
            this.label14.Text = "Nombres d\'épisodes :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(33, 69);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(133, 17);
            this.label13.TabIndex = 14;
            this.label13.Text = "Nombre de Saison :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(84, 37);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 17);
            this.label12.TabIndex = 14;
            this.label12.Text = "Nom Série :";
            // 
            // tb_nbrepisode
            // 
            this.tb_nbrepisode.Location = new System.Drawing.Point(175, 97);
            this.tb_nbrepisode.Margin = new System.Windows.Forms.Padding(4);
            this.tb_nbrepisode.Name = "tb_nbrepisode";
            this.tb_nbrepisode.Size = new System.Drawing.Size(132, 22);
            this.tb_nbrepisode.TabIndex = 17;
            // 
            // tb_nbresaison
            // 
            this.tb_nbresaison.Location = new System.Drawing.Point(175, 65);
            this.tb_nbresaison.Margin = new System.Windows.Forms.Padding(4);
            this.tb_nbresaison.Name = "tb_nbresaison";
            this.tb_nbresaison.Size = new System.Drawing.Size(132, 22);
            this.tb_nbresaison.TabIndex = 16;
            // 
            // tb_nomserie
            // 
            this.tb_nomserie.Location = new System.Drawing.Point(175, 33);
            this.tb_nomserie.Margin = new System.Windows.Forms.Padding(4);
            this.tb_nomserie.Name = "tb_nomserie";
            this.tb_nomserie.Size = new System.Drawing.Size(132, 22);
            this.tb_nomserie.TabIndex = 15;
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(33, 30);
            this.button.Margin = new System.Windows.Forms.Padding(4);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(133, 28);
            this.button.TabIndex = 18;
            this.button.Text = "accueil";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // XX
            // 
            this.XX.AutoSize = true;
            this.XX.Location = new System.Drawing.Point(184, 36);
            this.XX.Name = "XX";
            this.XX.Size = new System.Drawing.Size(26, 17);
            this.XX.TabIndex = 19;
            this.XX.Text = "XX";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.XX);
            this.Controls.Add(this.button);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form5";
            this.Text = "Ajout d\'une série";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_valider;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_nbrepisode;
        private System.Windows.Forms.TextBox tb_nbresaison;
        private System.Windows.Forms.TextBox tb_nomserie;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Label XX;
    }
}