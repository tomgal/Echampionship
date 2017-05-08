using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EChampionshipMVVM.Class
{
    public class Tournois
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

        private String _nomTournois;

        public String NomTournois
        {
            get { return _nomTournois; }
            set { _nomTournois = value; }
        }

        private DateTime _dateTournois;

        public DateTime DateTournois
        {
            get { return _dateTournois; }
            set { _dateTournois = value; }
        }

        private string _nbPlace;

        public string NbPlace
        {
            get { return NombrePlacePrise + " / " + NombreMaxPlace; }
        }

        private string returnDate;

        public string ReturnDate
        {
            get { return DateTournois.ToString("dd/MM/yyyy"); }
        }


    }
}
