using EChampionshipMVVM.Model;
using GalaSoft.MvvmLight;
using System.Collections.ObjectModel;

namespace EChampionshipMVVM.ViewModel
{
   
    public class MainViewModel : ViewModelBase
    {

        private string _texteAccueil = "Bienvenue sur eChampionship, le seul site proposant des tournois et championnat entre joueurs ainsi que des paris e-sportif sur les plus grandes compétitions du monde et plusieurs jeux ! ";

        public string TexteAccueil
        {
            get { return _texteAccueil; }
        }

        private string _urlImageEnCours;

        public string UrlImageEnCours
        {
            get { return _urlImageEnCours; }
            set
            {
                _urlImageEnCours = value;
                RaisePropertyChanged();
            }
        }

        private MainModel _mM;

        public MainModel MM
        {
            get { return _mM; }
            set { _mM = value; }
        }
        private string _errMessage;

        public string ErrMessage
        {
            get { return _errMessage; }
            set
            {
                _errMessage = value;
                RaisePropertyChanged();
            }
        }


        public int _compteurImage;

        private ObservableCollection<string> _imageSlider;

        public ObservableCollection<string> ImageSlider
        {
            get { return _imageSlider; }
            set
            {
                _imageSlider = value;
                RaisePropertyChanged();
            }
        }


        public MainViewModel()
        {
            _imageSlider = new ObservableCollection<string>();
            _mM = new MainModel();
            ImageSlider = _mM.GetAllImagesSlider();
            UrlImageEnCours = ImageSlider[0];
            _compteurImage = 0;
        }
    }
}