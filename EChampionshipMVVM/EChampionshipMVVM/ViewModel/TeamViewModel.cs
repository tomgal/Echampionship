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
    public class TeamViewModel : ViewModelBase
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

        private TeamModel _tM;

        public TeamModel TM
        {
            get { return _tM; }
            set { _tM = value; }
        }

        private List<Equipe> _myEquipes;

        public List<Equipe> MyEquipes
        {
            get { return _myEquipes; }
            set
            {
                _myEquipes = value;
                RaisePropertyChanged();
            }
        }

        private Equipe _equipeEnCours;

        public Equipe EquipeEnCours
        {
            get { return _equipeEnCours; }
            set
            {
                _equipeEnCours = value;
                RaisePropertyChanged();
            }
        }


        public TeamViewModel()
        {
            AM = new AccueilModel();
            MenuItem = AM.setMenuItem();
            TM = new TeamModel();
        }
    }
}
