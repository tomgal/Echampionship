using ECampionshipMVVM.Class;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EChampionshipMVVM.Class
{
    public class Equipe
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _nom;

        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        private string _urlProfil;

        public string UrlProfil
        {
            get { return _urlProfil; }
            set { _urlProfil = value; }
        }

        private string _urlBackground;

        public string UrlBackground
        {
            get { return _urlBackground; }
            set { _urlBackground = value; }
        }

        private List<Utilisateur> _membre;

        public List<Utilisateur> Membre
        {
            get { return _membre; }
            set { _membre = value; }
        }

        public Equipe(int id)
        {
            Id = id;
            initTeam();
            initMembre();
        }

        public void initTeam()
        {
            BDD _maCo = new BDD("localhost", "root", "", "echampionship");
            String requete = "select * from equipe  where IdEquipe = " + Id;

            MySqlDataReader _reader = _maCo.ExecuteRequeteSelect(requete);

            while (_reader.Read())
            {
                Id = _reader.GetInt16(0);
                Nom = _reader.GetString(1);
                UrlProfil = _reader.GetString(2);
                UrlBackground = _reader.GetString(3);
            }

            _reader.Close();
        }

        public void initMembre()
        {
            List<Utilisateur> membre = new List<Utilisateur>();
            BDD _maCo = new BDD("localhost", "root", "", "echampionship");
            String requete = "select * from user, contenir where contenir.idUser = user.IdUser and contenir.IdEquipe ="+Id;

            MySqlDataReader _reader = _maCo.ExecuteRequeteSelect(requete);

            while (_reader.Read())
            {
                membre.Add(new Utilisateur(_reader.GetInt16(0)));
            }

            Membre = membre;

        }

    }
}
