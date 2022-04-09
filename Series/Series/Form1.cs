using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;
public struct series

{
    public int numero;
    public string nom;//la variable de type series a pour valeur nom,saison,épisode
    public int nbSaison;
    public int nbEpisode;
    public int saisonEnCour;
    public int episodeEnCour;
}

public struct episode
{
    public int numero;
    public int numSaisons;
    public int note;
    public int numeroSerie;
    public int commentaires;
}

namespace Series
{
    public partial class Form1 : Form

    {
        public string user;
        public Form1(string u)
        {
            this.user = u;
            InitializeComponent();
            lb_pseudo.Text = u;
            panel1.Visible = false;
            affichageCB();

        }
        //public series[] serie = new series[500];
        public string connexionbase;
        public MySqlConnection conn;
        public void connexion()
        {
            string connectionbase;
            connectionbase = "server=172.19.0.79;uid=phpmyadmin;pwd=0550002D;database=series;";
            conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = connectionbase;
            conn.Open();
        }

        public void affichagelistbox()
        {
            nomSerie.Items.Clear();
            connexion();
            string affichage = "";
            if (CB_donnee.Text == "")
            {
                MessageBox.Show("Veuillez sélectionner une série dans la liste déroulante");
            }
            else
            {
                affichage = "SELECT * FROM serie INNER JOIN rajouter ON serie.id = rajouter.idSerie WHERE nom='" + CB_donnee.Text + "';";
            }
            MySqlCommand cmd = new MySqlCommand(affichage, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                for (int i = 0; i < 8; i++)
                {
                    nomSerie.Items.Add(rdr[i]);
                }

            }
            conn.Close();
            affichageCB();



        }

        /*public void nvlserie()
        {
            string nvl = TB_nouvelle.Text;
            string commande = "INSERT INTO serie";
        }*/

        private void BT_enregistrer_Click(object sender, EventArgs e)
        {
            /*using (StreamWriter fichierSortie = File.AppendText(chemin))
            { // On ajoute du texte a ce qui est déjà écrit dans serie.txt
                fichierSortie.Write("1/"+TB_nouvelle.Text+"/0/0/0/0/0");
                fichierSortie.WriteLine("");
                fichierSortie.Close();
            }
            StreamReader fichierEntree = File.OpenText(chemin);
            CB_donnee.Items.Clear();
            String ligne;
            string[] donnee = new string[6];
            while (fichierEntree.Peek() > 0)
            {
                
                ligne = fichierEntree.ReadLine();
                
                
                 donnee= ligne.Split('/');
                
                CB_donnee.Items.Add(donnee[1]);//split

            }
            fichierEntree.Close();*/
        }
        public void affichageCB()
        {
            string requete = "select nom from serie";
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


        private void BT_rechercher_Click(object sender, EventArgs e)
        { CB_donnee.Items.Clear();
           
            affichagelistbox();

        }
        public void nvlserie()
        {
            string nom = tb_nomserie.Text;
            string nbresaison = tb_nbresaison.Text;
            string nbreepisode = tb_nbrepisode.Text;
            string enregistrer = "INSERT INTO serie";
        }

        private void BT_saveterminer_Click(object sender, EventArgs e)
        {
            /*series s;
            s.saisonEnCour = Convert.ToInt32(numericUpDown2.Text);
            s.episodeEnCour = Convert.ToInt32(numericUpDown1.Text);
            s.numero =Convert.ToInt32(0);
            s.nom = CB_donnee.Text;
            s.nbSaison = Convert.ToInt32(0);
            s.nbEpisode = Convert.ToInt32(0);
           

            leseries[nbr] = s;
            nbr++;

            nomSerie.Items.Add("serie");    //nom de la serie
            nomSerie.Items.Add(s.saisonEnCour);  // numero de saison
            nomSerie.Items.Add(s.episodeEnCour); //numero d'episode

            if (nbr > 100)
            {
                Console.WriteLine("stockage plein supprimer les series fini");
            }*/
        }

        private void bt_valider_Click(object sender, EventArgs e)
        {

        }

        private void bt_new_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void nomSerie_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void PN_search_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void PN_saveterminer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void CB_donnee_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
