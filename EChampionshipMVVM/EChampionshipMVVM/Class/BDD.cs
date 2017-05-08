using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ECampionshipMVVM.Class
{
    class BDD
    {
        private string nameServer;
        private string idUser;
        private string passBdd;
        private string nameDb;
        private string cs;
        MySqlConnection conn = null;
        MySqlDataReader lecteur;


        public BDD(string name, string id, string mdp, string db)
        {
                nameServer = name;
                idUser = id;
                passBdd = mdp;
                nameDb = db;
                cs = @"server=" + nameServer + ";userid=" + idUser + ";password=" +
                passBdd + ";database=" + nameDb;
        }

        public Boolean Connexion(string mail, string mdp)
        {
            Boolean reussie = false;
            try
            {
                conn = new MySqlConnection(cs);
                conn.Open();

                string stm = "Select Mail, Password from user";
                MySqlCommand cmd = new MySqlCommand(stm, conn);
                lecteur = cmd.ExecuteReader();

                while (lecteur.Read())
                {
                    if (lecteur.GetString(0) == mail)
                    {
                        if (lecteur.GetString(1) == mdp)
                        {
                            reussie = true;
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
            }
            finally
            {
                if (lecteur != null)
                {
                    lecteur.Close();
                }

                if (conn != null)
                {
                    conn.Close();
                }
            }

            return reussie;
        }

        public void ExecuteRequete(string requete)
        {
            try
            {
                conn = new MySqlConnection(cs);
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(requete, conn);
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
            }
            finally
            {
                //if (lecteur != null)
                //{
                //    lecteur.Close();
                //}

                //if (conn != null)
                //{
                //    conn.Close();
                //}
            }
        }

        public MySqlDataReader ExecuteRequeteSelect(string requete)
        {
            conn = new MySqlConnection(cs);
            conn.Open();

            MySqlCommand cmd = new MySqlCommand(requete, conn);
            lecteur = cmd.ExecuteReader();

            return lecteur;
        }
    }
}
