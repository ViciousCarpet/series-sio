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
    public partial class Form4 : Form
    {
        public static string pseudo;
        public Form4()
        {
            InitializeComponent();
            XX.Text = pseudo;
            panel1.Visible = false;
            affichagecb();

        }
        
        public MySqlConnection conn;
        public void connexion()
        {
            string connexionbase;
            string connectionbase;
            connectionbase = "server=localhost;uid=root;pwd=;database=series";//server=172.19.0.79;uid=phpmyadmin;pwd=0550002D;database=series;
            conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = connectionbase;
            conn.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
            this.Close();
        }

        
        public void affichagecb()
        {
            CB_donnee.Items.Clear();
            string requete = "SELECT nom FROM serie INNER JOIN rajouter ON serie.id=rajouter.idSerie INNER JOIN identifiant ON rajouter.idUser=identifiant.id WHERE login='"+XX.Text+"' ORDER BY nom ASC;";
            connexion();
            MySqlCommand cmd = new MySqlCommand(requete, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                CB_donnee.Items.Add(rdr[0].ToString());

            }
            rdr.Close();
            conn.Close();
        }
        public void affichagelistbox()
        {
            nomSerie.Items.Clear();
            connexion();
            if(CB_donnee.Text!="")
            {
                string requete = "SELECT nom,nombreSaisons,nombreEpisodes,SaisonEnCour,episodesEnCour FROM serie INNER JOIN rajouter ON serie.id=rajouter.idSerie WHERE nom='" + CB_donnee.Text + "';";
                MySqlCommand cmd = new MySqlCommand(requete, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    for(int i=0;i<5;i++)
                    {
                        nomSerie.Items.Add(rdr[i].ToString());
                    }
                }
                rdr.Close();
                conn.Close();
                affichagecb();
            }
            else
            {
                MessageBox.Show("Veuillez insérer une série dans la liste déroulante.");
            }
            
        }
        private void BT_saveterminer_Click(object sender, EventArgs e)
        {
            connexion();
            //-------------------------------Je récupère le id user
            string moi = "SELECT id FROM identifiant WHERE login='"+XX.Text+"';";
            MySqlCommand cmdmoi = new MySqlCommand(moi, conn);
            MySqlDataReader rdr = cmdmoi.ExecuteReader();
            rdr.Read();
            string monid = rdr[0].ToString();
            rdr.Close();
            //-----------------------------Je récupère le id série
            string serie = "SELECT id FROM serie WHERE nom='"+CB_donnee.Text+"' ;";
            MySqlCommand cmdserie = new MySqlCommand(serie, conn);
            MySqlDataReader rdr0 = cmdserie.ExecuteReader();
            rdr0.Read();
            string idserie = rdr0[0].ToString();
            rdr0.Close();

            //-----------------------------Je modifie les saisons en cours et épisode en cours
            string myinsertQuery = "UPDATE rajouter SET episodesEnCour='"+numericUpDown3.Value+"',SaisonEnCour='"+numericUpDown2.Value+"' WHERE idUser='"+monid+"' AND idSerie='"+idserie+"';";
            MySqlCommand modifier = new MySqlCommand(myinsertQuery);
            modifier.Connection = conn;
            modifier.ExecuteNonQuery();
            conn.Close();
            affichagelistbox();
            

        }
        private void BT_rechercher_Click(object sender, EventArgs e)
        {
             affichagelistbox();
        }

        private void bt_new_Click(object sender, EventArgs e)
        {
            Form5.pseudo = Form4.pseudo;
            Form5 f = new Form5();
            f.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void noter_Click(object sender, EventArgs e)
        {
            connexion();
            //-------------------------------Je récupère le id user
            string moi = "SELECT id FROM identifiant WHERE login='" + XX.Text + "';";
            MySqlCommand cmdmoi = new MySqlCommand(moi, conn);
            MySqlDataReader rdr = cmdmoi.ExecuteReader();
            rdr.Read();
            string monid = rdr[0].ToString();
            rdr.Close();
            //-----------------------------Je récupère le id série
            string serie = "SELECT id FROM serie WHERE nom='" + CB_donnee.Text + "' ;";
            MySqlCommand cmdserie = new MySqlCommand(serie, conn);
            MySqlDataReader rdr0 = cmdserie.ExecuteReader();
            rdr0.Read();
            string idserie = rdr0[0].ToString();
            rdr0.Close();
            //----------------------------Je récupère l'id épisode
            string episode = "SELECT id FROM episode WHERE idSerie='" + idserie + "';";
            MySqlCommand cmdepisode = new MySqlCommand(episode, conn);
            MySqlDataReader rdr1 = cmdepisode.ExecuteReader();
            rdr1.Read();
            string idepisode = rdr1[0].ToString();
            rdr1.Close();
            string commentaire = textBox1.Text;
            int note = Convert.ToInt32(numericUpDown1.Value);
            string requete = "INSERT INTO evaluer(commentaire,note,idUser,idEpisode) VALUES ('"+commentaire+"','"+note+"','"+monid+"','"+idepisode+"')";
            MySqlCommand commenter = new MySqlCommand(requete);
            commenter.Connection = conn;
            commenter.ExecuteNonQuery();

        }
    }
}
