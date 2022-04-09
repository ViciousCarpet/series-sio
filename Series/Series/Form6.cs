using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Series
{
    public partial class Form6 : Form
    {
        public static string pseudo;
        public Form6()
        {
            InitializeComponent();
            XX.Text = pseudo;
            idmoi();
            initialiser();
            panel1.Visible = false;
        }
        public MySqlConnection conn;
        public void connexion()
        {

            string connectionbase;
            connectionbase = "server=localhost;uid=root;pwd=;database=series";//server=172.19.0.79;uid=phpmyadmin;pwd=0550002D;database=series;
            conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = connectionbase;
            conn.Open();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3(/*pseudo*/);
            f.Show();
            this.Close();
        }
        public string moi;
        public void idmoi()
        {
            connexion();
            string monid = "SELECT id FROM identifiant WHERE login='" + XX.Text + "';";
            MySqlCommand cmdmonid = new MySqlCommand(monid, conn);
            MySqlDataReader rdr0 = cmdmonid.ExecuteReader();
            rdr0.Read();
            moi = rdr0[0].ToString();
            rdr0.Close();
            conn.Close();
        }
        
        private void bt_recherche_Click(object sender, EventArgs e)
        {
           
            string sonid = "SELECT id FROM identifiant WHERE login='" + textBox1.Text + "';";
            string toi;

            connexion();
            MySqlCommand cmdsonid = new MySqlCommand(sonid, conn);
            MySqlDataReader rdr1 = cmdsonid.ExecuteReader();
            rdr1.Read();
            toi = rdr1[0].ToString();
            rdr1.Close();
            conn.Close();

            connexion();
            string ami = "INSERT INTO partager(idUser,idAmis) VALUES ("+moi+","+toi+");";
            MySqlCommand cmdami = new MySqlCommand(ami, conn);
            cmdami.ExecuteNonQuery();
            conn.Close();
        }
        public void initialiser()
        {
            string series = "SELECT nom FROM serie;";
            connexion();
            MySqlCommand serie = new MySqlCommand(series, conn);
            MySqlDataReader rdrsri = serie.ExecuteReader();
            while (rdrsri.Read())
            {
                comboBox1.Items.Add(rdrsri[0]);
            }
            conn.Close();

            connexion();
            string listeamis = "SELECT login FROM identifiant INNER JOIN partager ON identifiant.id=partager.idAmis WHERE idUser='"+moi+"';";
            MySqlCommand affliste = new MySqlCommand(listeamis, conn);
            MySqlDataReader rdr = affliste.ExecuteReader();
            int i = 0;
            string[] amis = new string[100];
            while(rdr.Read()==true)
            {
                amis[i]=rdr[0].ToString();
                listBox1.Items.Add(amis[i]);
                i++;
            }
            rdr.Close();

            //---------------------------------

            conn.Close();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            listBox2.ResetText();
            string noteepi = "SELECT commentaire,note FROM evaluer INNER JOIN episodes ON evaluer.idEpisode = episodes.id INNER JOIN serie ON episodes.idSerie=serie.id WHERE nom='"+comboBox1.Text+"' AND numeroEpisodes='"+numericUpDown1.Value+"';";
            connexion();
            MySqlCommand afficher = new MySqlCommand(noteepi, conn);
            MySqlDataReader rdraff = afficher.ExecuteReader();
            while(rdraff.Read())
            {
                listBox2.Items.Add(rdraff[0]);
                listBox2.Items.Add(rdraff[1]);
            }
            conn.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("vous avez selectionné " + listBox1.SelectedItem);
            string idenami;
            string idami = "SELECT id FROM identifiant WHERE login='" + listBox1.SelectedItem + "'";
            connexion();
            MySqlCommand iami = new MySqlCommand(idami, conn);
            MySqlDataReader rdr = iami.ExecuteReader();
            rdr.Read();
            idenami = rdr[0].ToString();
            MessageBox.Show(idenami);
        }

        private void ajouter_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }
    }
}
