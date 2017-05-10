using EChampionshipMVVM.Class;
using EChampionshipMVVM.Model;
using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EChampionshipMVVM.ViewModel
{
    public class AccueilViewModel : ViewModelBase
    {
        private List<String> menuItem;

        public List<String> MenuItem
        {
            get { return menuItem; }
            set
            {
                menuItem = value;
                RaisePropertyChanged();
            }
        }

        private List<Pari> listPari;

        public List<Pari> ListPari
        {
            get { return listPari; }
            set
            {
                listPari = value;
                RaisePropertyChanged();
            }
        }

        private List<Tournois> listTournois;

        public List<Tournois> ListTournois
        {
            get { return listTournois; }
            set
            {
                listTournois = value;
                RaisePropertyChanged();
            }
        }

        private List<Championnat> listChampionnat;

        public List<Championnat> ListChampionnat
        {
            get { return listChampionnat; }
            set
            {
                listChampionnat = value;
                RaisePropertyChanged();
            }
        }


        private AccueilModel _aM;

        public AccueilModel AM
        {
            get { return _aM; }
            set
            {
                _aM = value;
                RaisePropertyChanged();
            }
        }

        private Utilisateur _user;

        public Utilisateur User
        {
            get { return _user; }
            set
            {
                _user = value;
                RaisePropertyChanged();
            }
        }

        public AccueilViewModel()
        {
            AM = new AccueilModel();
            MenuItem = AM.setMenuItem();
            ListPari = AM.getLastPari();
            ListTournois = AM.getLastTournament();
            ListChampionnat = AM.getLastChampionship();
        }



    }
}
