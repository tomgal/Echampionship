using ECampionshipMVVM.Class;
using EChampionshipMVVM.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace EChampionshipMVVM.Model
{
    public class InscriptionModel
    {
        private BDD _maCo;
        private MySqlDataReader _reader;

        public InscriptionModel()
        {
            _maCo = new BDD("localhost", "root", "", "echampionship");
        }

        public List<Jeux> RecupJeux()
        {
            List<Jeux> _jeux = new List<Jeux>();
            String requete = "select NomJeux, Image_Url, IdJeux from jeux";
            _reader = _maCo.ExecuteRequeteSelect(requete);

            Jeux _jeu;

            while (_reader.Read())
            {
                _jeu = new Jeux(_reader.GetString(0), "../" + _reader.GetString(1));
                _jeu.Id = _reader.GetInt16(2);
                _jeux.Add(_jeu);
            }

            return _jeux;
        }

        public void FinaliserInscription(String pren, String nom, String pseu, String lol, String battlenet, String origin, String steam, List<Jeux> _myGame, int id)
        {
            String requete = "Update user set Prenom = '" + pren + "', NomUser = '" + nom + "', Pseudo = '" + pseu + "', PseudoLol = '" + lol + "', PseudoSteam = '" + steam + "', PseudoBattleNet ='" + battlenet + "' where IdUser = " + id;
            _maCo.ExecuteRequete(requete);

            foreach (Jeux j in _myGame)
            {
                requete = "insert into jouer values (" + id + "," + j.Id + ")";
                _maCo.ExecuteRequete(requete);
            }
        }

        public int recupId(String pseudo)
        {
            int id = -1;
            String requete = "select IdUser from user where Pseudo = '" + pseudo + "'";
            MySqlDataReader _reader = _maCo.ExecuteRequeteSelect(requete);
            while (_reader.Read())
            {
                id = _reader.GetInt16(0);
            }
            return id;
        }
    }
}
