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
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
            panel1.Visible = false;
            panel2.Visible = false;
            
        }
        public string connexionbase;
        public MySqlConnection conn;
        public string user;
        public void connexion()
        {
            string connectionbase;
            connectionbase = "server=localhost;uid=root;pwd=;database=series";//server=172.19.0.79;uid=phpmyadmin;pwd=0550002D;database=series;";
            conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = connectionbase;
            conn.Open();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        //public string pseudo;

        private void connecter()
        {
            string commande = "SELECT * FROM identifiant WHERE login='" + loginconn.Text + "'AND mdp='" + mdpconn.Text + "';";
            bool connexionOK = false;
            connexion();
            MySqlCommand cmd = new MySqlCommand(commande, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            connexionOK=rdr.Read();

            switch (connexionOK)
            {
                case true:

                    Form3.pseudo = loginconn.Text;
                    loginconn.ResetText();
                    mdpconn.ResetText();
                    Form3 f = new Form3();
                    f.Show();
                    break;
                case false:
                    MessageBox.Show("Connexion refusée! Veuillez recommencer.");
                    loginconn.ResetText();
                    mdpconn.ResetText();
                    break;
            }
            conn.Close();
        }

        



        private void button1_Click(object sender, EventArgs e)
        {
            connecter();

            
        }
        
        public void inscrire()
        {
            string verifPseudo = "select login from identifiant where login = '" + logininsc.Text + "'";
            string myInsertQuery = "INSERT INTO identifiant(`login`, `mdp`) VALUES('" + this.logininsc.Text + "','" + this.mdpinsc.Text + "')";

            MySqlCommand myCommand2 = new MySqlCommand(verifPseudo);
            connexion();

            myCommand2.Connection = conn;
            bool pseudoOk = false;
            MySqlDataReader rdr = myCommand2.ExecuteReader();
            pseudoOk = rdr.Read();
            if (pseudoOk == true)
            {
                MessageBox.Show("ce pseudo existe déjà, veuillez en choisir un autre ");
                logininsc.ResetText();
                mdpinsc.ResetText();
                conn.Close();
            }
            else
            {
                connexion();
                MySqlCommand myCommand = new MySqlCommand(myInsertQuery);
                myCommand.Connection = conn;
                myCommand.ExecuteNonQuery();
                MessageBox.Show("Vous etez bien inscrit, veuillez vous connecter");
                panel2.Visible = false;
            }


            conn.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            inscrire();
        }

      

        private void mdpinsc_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
