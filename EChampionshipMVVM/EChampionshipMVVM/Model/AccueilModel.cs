using ECampionshipMVVM.Class;
using EChampionshipMVVM.Class;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EChampionshipMVVM.Model
{
    public class AccueilModel
    {
        public List<String> setMenuItem()
        {
            List<String> menuItem = new List<string>();
            menuItem.Add("Accueil");
            menuItem.Add("Mon Compte");
            menuItem.Add("Team");
            menuItem.Add("Paris");
            menuItem.Add("Tournois");
            menuItem.Add("Championnat");
            menuItem.Add("Parametres");
            menuItem.Add("Deconnexion");

            return menuItem;
        }

        public List<Pari> getLastPari()
        {
            List<Pari> lastPari = new List<Pari>();
            BDD maCo = new BDD("localhost", "root", "", "echampionship");
            string requete = "select * from pari, jeux, professionnel p1, professionnel p2 where pari.id_equipe1 = p1.Id_equipe_pro and pari.id_equipe2 = p2.Id_equipe_pro and pari.id_jeux = jeux.IdJeux LIMIT 5";
            MySqlDataReader reader = maCo.ExecuteRequeteSelect(requete);

            while(reader.Read())
            {
                Pari unPari = new Pari();
                unPari.CoteEquipe1 = reader.GetDouble(4);
                unPari.CoteEquipe2 = reader.GetDouble(5);
                unPari.NomEquipe1 = reader.GetString(11);
                unPari.NomEquipe2 = reader.GetString(16);
                unPari.NomJeux = reader.GetString(7);
                unPari.UrlJeux = reader.GetString(8);
                unPari.UrlLogoEq1 = reader.GetString(12);
                unPari.UrlLogoEq2 = reader.GetString(17);
                lastPari.Add(unPari);
            }
            return lastPari;
        }

        public List<Tournois> getLastTournament()
        {
            List<Tournois> lastTournament = new List<Tournois>();
            BDD maCo = new BDD("localhost", "root", "", "echampionship");
            string Requete = "select * from tournois, jeux where tournois.id_jeu = jeux.IdJeux";
            MySqlDataReader reader = maCo.ExecuteRequeteSelect(Requete);
            while(reader.Read())
            {
                Tournois unTournois = new Tournois();
                unTournois.NombreMaxPlace = reader.GetInt16(5);
                unTournois.NombrePlacePrise = getPlacePriseTournois(reader.GetInt16(0));
                unTournois.JeuConcerne = reader.GetString(8);
                unTournois.Level = reader.GetString(3);
                unTournois.UrlJeu = "../"+reader.GetString(9);
                unTournois.Createur = reader.GetString(6);
                unTournois.NomTournois = reader.GetString(1);
                unTournois.DateTournois = reader.GetDateTime(2);
                lastTournament.Add(unTournois);
            }
            reader.Close();
            return lastTournament;
        }

        public int getPlacePriseTournois(int id)
        {
            int placePrise = 0;
            BDD maCo = new BDD("localhost", "root", "", "echampionship");
            string requetePlacePrise = "select count(*) from tournois, participer where tournois.idtournois = participer.idtournois and tournois.idtournois = " + id + ";";
            MySqlDataReader reader2 = maCo.ExecuteRequeteSelect(requetePlacePrise);
            while (reader2.Read())
            {
                placePrise = reader2.GetInt16(0);
            }
            reader2.Close();
            return placePrise;
        }

        public List<Championnat> getLastChampionship()
        {
            List<Championnat> lastChamp = new List<Championnat>();
            BDD maCo = new BDD("localhost", "root", "", "echampionship");
            string Requete = "select * from championnat, jeux where championnat.id_jeux = jeux.IdJeux";
            MySqlDataReader reader = maCo.ExecuteRequeteSelect(Requete);
            while (reader.Read())
            {
                Championnat unChampionnat = new Championnat();
                unChampionnat.NombreMaxPlace = reader.GetInt16(2);
                unChampionnat.NombrePlacePrise = getNbPlacePriseChampionnat(reader.GetInt16(0));
                unChampionnat.JeuConcerne = reader.GetString(7);
                unChampionnat.Level = reader.GetString(4);
                unChampionnat.UrlJeu = "../" + reader.GetString(8);
                unChampionnat.Createur = reader.GetString(5);
                unChampionnat.NomChampionnat = reader.GetString(3);
                lastChamp.Add(unChampionnat);
            }

            return lastChamp;
        }

        public int getNbPlacePriseChampionnat(int id)
        {
            int placePrise = 0;
            BDD maCo = new BDD("localhost", "root", "", "echampionship");
            string requetePlacePrise = "select count(*) from championnat, participation where championnat.id_championnat = participation.id_championnat and championnat.id_championnat = " + id + ";";
            MySqlDataReader reader2 = maCo.ExecuteRequeteSelect(requetePlacePrise);
            while (reader2.Read())
            {
                placePrise = reader2.GetInt16(0);
            }
            reader2.Close();
            return placePrise;
        }
        
    }
}
