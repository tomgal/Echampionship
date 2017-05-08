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
    public class InscriptionViewModel : ViewModelBase
    {
        private InscriptionModel _iM;

        public InscriptionModel IM
        {
            get
            {
                return _iM;
            }
        }

        private String _errMessage;

        public String ErrMessage
        {
            get
            {
                return _errMessage;
            }
            set
            {
                _errMessage = value;
                RaisePropertyChanged();
            }
        }


        private List<Jeux> _allGame;

        public List<Jeux> AllGame
        {
            get
            {
                return _allGame;
            }
            set
            {
                _allGame = value;
                RaisePropertyChanged();
            }
        }

        private List<Jeux> _myGame;

        public List<Jeux> MyGame
        {
            get
            {
                return _myGame;
            }
            set
            {
                _myGame = value;
                RaisePropertyChanged();
            }
        }

        public InscriptionViewModel()
        {
            _iM = new InscriptionModel();
            AllGame = _iM.RecupJeux();
            MyGame = new List<Jeux>();
            
        }
    }
}
