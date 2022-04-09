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
    public partial class Form5 : Form
    {
        public static string pseudo;
        public Form5()
        {
            InitializeComponent();
            
            XX.Text = pseudo;
        }

        private void bt_valider_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4(/*pseudo*/);
            f.Show();
            connexion();
            //---------------------------Je vérifie si la série existe déjà
            string verif = "SELECT nom FROM serie WHERE nom='"+tb_nomserie.Text+"'";
            MySqlCommand verification = new MySqlCommand(verif, conn);
            MySqlDataReader rdr00 = verification.ExecuteReader();
            rdr00.Read();
            if(rdr00.Read()==true)
            {
                rdr00.Close();
                //---------------------------Je créé une nouvelle serie dans la table série
                string ajouter = "INSERT INTO serie(nom,nombreSaisons,nombreEpisodes) VALUES ('" + tb_nomserie.Text + "'," + tb_nbresaison.Text + "," + tb_nbrepisode.Text + ");";
                MySqlCommand creation = new MySqlCommand(ajouter);
                creation.Connection = conn;
                creation.ExecuteNonQuery();
                //---------------------------Je récupère l'id user
                string moi = "SELECT id FROM identifiant WHERE login='" + XX.Text + "';";
                string monid = "SELECT id FROM identifiant WHERE login='" + XX.Text + "';";
                MySqlCommand cmdmonid = new MySqlCommand(monid, conn);
                MySqlDataReader rdr0 = cmdmonid.ExecuteReader();
                rdr0.Read();
                moi = rdr0[0].ToString();
                rdr0.Close();
                //---------------------------Je récupère l'id Série
                string serie = "SELECT id FROM serie WHERE nom='" + tb_nomserie.Text + "' ;";
                MySqlCommand cmdserie = new MySqlCommand(serie, conn);
                MySqlDataReader rdr1 = cmdserie.ExecuteReader();
                rdr1.Read();
                string idserie = rdr1[0].ToString();
                rdr1.Close();
                conn.Close();
                //---------------------------Je créé un nouveau visionnage dans la table rajouter en mettant la saison et l'épisode en cours à 1.
                connexion();
                string ajouter2 = "INSERT INTO rajouter(idUser,idSerie,episodesEnCour,SaisonEnCour) VALUES ('" + moi + "','" + idserie + "','1','1');";
                MySqlCommand macommande2 = new MySqlCommand(ajouter2);
                macommande2.Connection = conn;
                macommande2.ExecuteNonQuery();
                conn.Close();
            }
            else
            {
                rdr00.Close();
                //---------------------------Je récupère l'id user
                string moi = "SELECT id FROM identifiant WHERE login='" + XX.Text + "';";
                string monid = "SELECT id FROM identifiant WHERE login='" + XX.Text + "';";
                MySqlCommand cmdmonid = new MySqlCommand(monid, conn);
                MySqlDataReader rdr0 = cmdmonid.ExecuteReader();
                rdr0.Read();
                moi = rdr0[0].ToString();
                rdr0.Close();
                //---------------------------Je récupère l'id Série
                string serie = "SELECT id FROM serie WHERE nom='" + tb_nomserie.Text + "' ;";
                MySqlCommand cmdserie = new MySqlCommand(serie, conn);
                MySqlDataReader rdr1 = cmdserie.ExecuteReader();
                rdr1.Read();
                string idserie = rdr1[0].ToString();
                rdr1.Close();
                conn.Close();
                //---------------------------Je créé un nouveau visionnage dans la table rajouter en mettant la saison et l'épisode en cours à 1.
                connexion();
                string ajouter2 = "INSERT INTO rajouter(idUser,idSerie,episodesEnCour,SaisonEnCour) VALUES ('" + moi + "','" + idserie + "','1','1');";
                MySqlCommand macommande2 = new MySqlCommand(ajouter2);
                macommande2.Connection = conn;
                macommande2.ExecuteNonQuery();
                
            }
            
            conn.Close();
            MessageBox.Show("La série " + tb_nomserie.Text + " avec " + tb_nbresaison.Text + " saisons et " + tb_nbrepisode.Text + " épisodes a bien été créée.");
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3(/*pseudo*/);
            f.Show();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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
       
        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}

