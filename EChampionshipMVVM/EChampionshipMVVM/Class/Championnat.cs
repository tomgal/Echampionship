using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EChampionshipMVVM.Class
{
    public class Championnat
    {
        private int _nombreMaxPlace;

        public int NombreMaxPlace
        {
            get { return _nombreMaxPlace; }
            set { _nombreMaxPlace = value; }
        }

        private int _nombrePlacePrise;

        public int NombrePlacePrise
        {
            get { return _nombrePlacePrise; }
            set { _nombrePlacePrise = value; }
        }

        private String _jeuConcerne;

        public String JeuConcerne
        {
            get { return _jeuConcerne; }
            set { _jeuConcerne = value; }
        }

        private String _level;

        public String Level
        {
            get { return _level; }
            set { _level = value; }
        }

        private String _urlJeu;

        public String UrlJeu
        {
            get { return _urlJeu; }
            set { _urlJeu = value; }
        }

        private String _createur;

        public String Createur
        {
            get { return _createur; }
            set { _createur = value; }
        }

        private String _nomChampionnat;

        public String NomChampionnat
        {
            get { return _nomChampionnat; }
            set { _nomChampionnat = value; }
        }

        private string _nbPlace;

        public string NbPlace
        {
            get { return NombrePlacePrise + " / " + NombreMaxPlace; }
        }

    }
}
