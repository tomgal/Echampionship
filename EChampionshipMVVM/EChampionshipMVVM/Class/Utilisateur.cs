using ECampionshipMVVM.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace EChampionshipMVVM.Class
{
    public class Utilisateur
    {
        private String _urlImage;

        public String UrlImage
        {
            get { return _urlImage; }
            set { _urlImage = value; }
        }

        private String _prenom;

        public String Prenom
        {
            get { return _prenom; }
            set { _prenom = value; }
        }

        private String _nom;

        public String Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        private String _pseudo;

        public String Pseudo
        {
            get { return _pseudo; }
            set { _pseudo = value; }
        }

        private String _pseudoLol;

        public String PseudoLol
        {
            get { return _pseudoLol; }
            set { _pseudoLol = value; }
        }

        private String _pseudoSteam;

        public String PseudoSteam
        {
            get { return _pseudoSteam; }
            set { _pseudoSteam = value; }
        }

        private string _backgroundProfile;

        public string BackgroundProfile
        {
            get { return _backgroundProfile; }
            set { _backgroundProfile = value; }
        }

        private List<int> _idequipes;

        public List<int> IdEquipes
        {
            get { return _idequipes; }
            set { _idequipes = value; }
        }


        private String _pseudoBattleNet;

        public String PseudoBattleNet
        {
            get { return _pseudoBattleNet; }
            set { _pseudoBattleNet = value; }
        }

        private String _pseudoOrigin;

        public String PseudoOrigin
        {
            get { return _pseudoOrigin; }
            set { _pseudoOrigin = value; }
        }

        private String _mail;

        public String Mail
        {
            get { return _mail; }
            set { _mail = value; }
        }

        private int _credit;

        public int Credit
        {
            get { return _credit; }
            set { _credit = value; }
        }


        private List<Jeux> _myGames;

        public  List<Jeux> MyGames
        {
            get
            {
                return _myGames;
            }
            set
            {
                _myGames = value;
            }
        }
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public Utilisateur(int _idUser)
        {
            Id = _idUser;
            MyGames = recupAllGames(Id);
            initUser();
            MyTeam();
        }

        public List<Jeux> recupAllGames(int id)
        {
            List<Jeux> _jeux = new List<Jeux>();
            BDD _maCo = new BDD("localhost", "root", "", "echampionship");
            String requete = "select jouer.IdJeux, NomJeux, Image_Url, level from jeux, jouer where jouer.IdJeux = jeux.IdJeux and IdUser = " + id;

            MySqlDataReader _reader = _maCo.ExecuteRequeteSelect(requete);

            while(_reader.Read())
            {
                Jeux j = new Jeux(_reader.GetString(1), _reader.GetString(2));
                j.Id = _reader.GetInt16(0);
                j.Level = _reader.GetString(3);
                _jeux.Add(j);
            }
            return _jeux;
        }

        public void initUser()
        {
            BDD _maCo = new BDD("localhost", "root", "", "echampionship");
            String requete = "select * from user where IdUser = " + Id;

            MySqlDataReader _reader = _maCo.ExecuteRequeteSelect(requete);

            while(_reader.Read())
            {
                UrlImage = _reader.GetString(12);
                Prenom = _reader.GetString(5);
                Nom = _reader.GetString(4);
                Pseudo = _reader.GetString(1);
                PseudoBattleNet = _reader.GetString(8);
                PseudoLol = _reader.GetString(7);
                PseudoSteam = _reader.GetString(6);
                PseudoOrigin = _reader.GetString(11);
                Mail = _reader.GetString(3);
                Credit = _reader.GetInt16(9);
                Id = _reader.GetInt16(0);
                BackgroundProfile = _reader.GetString(13);
            }

            _reader.Close();
        }

        public void MyTeam()
        {
            List<int> teams = new List<int>();
            BDD _maCo = new BDD("localhost", "root", "", "echampionship");
            String requete = "select contenir.idEquipe from contenir, user where user.idUser = contenir.idUser and User.idUser = " + Id;

            MySqlDataReader _reader = _maCo.ExecuteRequeteSelect(requete);

            while (_reader.Read())
            {
                teams.Add(_reader.GetInt16(0));
            }
            _reader.Close();

            IdEquipes = teams;
        }
    }
}
