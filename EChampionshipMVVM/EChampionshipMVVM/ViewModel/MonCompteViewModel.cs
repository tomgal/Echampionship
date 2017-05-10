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
    public class MonCompteViewModel : ViewModelBase
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

        private MonCompteViewModel _mCVM;

        public MonCompteViewModel MCVM
        {
            get { return _mCVM; }
            set
            {
                _mCVM = value;
                RaisePropertyChanged();
            }
        }

        public MonCompteViewModel()
        {
            AM = new AccueilModel();
            MenuItem = AM.setMenuItem();
        }
    }
}
