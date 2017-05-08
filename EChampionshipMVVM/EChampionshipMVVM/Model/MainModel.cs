using ECampionshipMVVM.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Collections.ObjectModel;

namespace EChampionshipMVVM.Model
{
    public class MainModel
    {
        BDD _maConnexion;
        MySqlDataReader _lecteur;

        public MainModel()
        {
            _maConnexion = new BDD("localhost", "root", "", "echampionship");
        }


        public ObservableCollection<string> GetAllImagesSlider()
        {
            ObservableCollection<string> _images = new ObservableCollection<string>();

            string request = "select Image_Url from jeux";

            _lecteur = _maConnexion.ExecuteRequeteSelect(request);

            while(_lecteur.Read())
            {
                _images.Add("../"+_lecteur.GetString(0));
            }

            return _images;
        }

        public int Connexion (string _mailOrPseudo, string _mdp)
        {
            string request = "select IdUser from user where Pseudo ='" + _mailOrPseudo + "' OR Mail ='" + _mailOrPseudo + "' AND Password='" + _mdp + "'";
            _lecteur = _maConnexion.ExecuteRequeteSelect(request);

            if(_lecteur == null)
            {
                return -1;
            }
            else
            {
                int _id = -1;
                while(_lecteur.Read())
                {
                    _id = _lecteur.GetInt16(0);
                }
                return _id;
            }
        }

        public bool Inscription(string _mail, string mdp)
        {
            bool _isPossible = false;
            string requete = "select count(*) from user where Mail = '" + _mail + "'";
            _lecteur = _maConnexion.ExecuteRequeteSelect(requete);

                while(_lecteur.Read())
                {
                    if(_lecteur.GetInt16(0) == 0)
                    {
                        string insert = "Insert into user(Mail, Password) VALUES ('" + _mail + "','" + mdp + "')";
                        _maConnexion.ExecuteRequete(insert);
                        _isPossible = true;
                    }
                    else
                    {
                        _isPossible = false;
                    }
                }
            return _isPossible;
        }
 
    }
}
