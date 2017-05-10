using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Forms;
using EChampionshipMVVM.ViewModel;

namespace EChampionshipMVVM.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int IdUser = -1;
        Timer _timerSlider;
        Timer _timerPopUp;
        public MainWindow()
        {
            InitializeComponent();
            _timerSlider = new Timer();
            _timerSlider.Tick += new EventHandler(ChangementImage);
            _timerSlider.Interval = 3000;
            _timerSlider.Start();
            _timerPopUp = new Timer();
        }

        public void ChangementImage(Object obj, EventArgs args)
        {
            MainViewModel _mVM = (MainViewModel)DataContext;
            _mVM._compteurImage++;
            _timerSlider.Stop();

            if (_mVM._compteurImage + 1 > _mVM.ImageSlider.Count)
            {
                _mVM._compteurImage = 0;
            }

            _mVM.UrlImageEnCours = _mVM.ImageSlider[_mVM._compteurImage];

            _timerSlider.Enabled = true;
        }

        public void CacherPopUp(Object obj, EventArgs args)
        {
            _timerSlider.Enabled = false;
            PopUpInfo.Visibility = Visibility.Collapsed;
            rectan.Visibility = Visibility.Collapsed;
        }

        private void ResetChamps(object sender, MouseButtonEventArgs e)
        {
            System.Windows.Controls.TextBox _sender = sender as System.Windows.Controls.TextBox;
            _sender.Text = "";
        }

        private void EnterLabel(object sender, System.Windows.Input.MouseEventArgs e)
        {
            System.Windows.Controls.TextBlock _sender = sender as System.Windows.Controls.TextBlock;
            _sender.FontWeight = FontWeights.Bold;

        }

        private void LeaveLabel(object sender, System.Windows.Input.MouseEventArgs e)
        {
            TextBlock _sender = sender as TextBlock;
            _sender.FontWeight = FontWeights.Regular;
        }

        private void Connexion(object sender, RoutedEventArgs e)
        {
            MainViewModel _mVM = (MainViewModel)DataContext;
            IdUser = _mVM.MM.Connexion(tBPseudo.Text, tBMdp.Password);
            if (IdUser != -1)
            {
                AccueilView _aV = new AccueilView(IdUser);
                _aV.Show();
                this.Close();
            }
            else
            {
                _mVM.ErrMessage = "Problème lors de la connexion. \n Vérifier vos Identifiants";
                PopUpInfo.Visibility = Visibility.Visible;
                rectan.Visibility = Visibility.Visible;
                
                _timerPopUp.Tick += new EventHandler(CacherPopUp);
                _timerPopUp.Interval = 2000;
                _timerPopUp.Start();
            }
        }

        private void ResetPassword(object sender, MouseButtonEventArgs e)
        {
            PasswordBox _sender = sender as PasswordBox;
            _sender.Password = "";
        }

        private void Inscription(object sender, RoutedEventArgs e)
        {
            MainViewModel _mVM = (MainViewModel)DataContext;
            if (tBMdpInscrip.Password == tBMdpInscrip2.Password)
            {
                bool _isPossible = _mVM.MM.Inscription(tBMailInscrip.Text, tBMdpInscrip.Password);
                if(_isPossible == false)
                {
                    _mVM.ErrMessage = "Ce mail est déjà pris. \n Veuillez saisir un nouveau mail.";
                    PopUpInfo.Visibility = Visibility.Visible;
                    rectan.Visibility = Visibility.Visible;
                    _timerPopUp.Tick += new EventHandler(CacherPopUp);
                    _timerPopUp.Interval = 2000;
                    _timerPopUp.Start();
                }
                else
                {
                    _mVM.ErrMessage = "Inscription Réussie.";
                    PopUpInfo.Visibility = Visibility.Visible;
                    rectan.Visibility = Visibility.Visible;
                    _timerPopUp.Tick += new EventHandler(CacherPopUp);
                    _timerPopUp.Interval = 2000;
                    _timerPopUp.Start();

                    //Passage de l'Id User inscrit dans la suite de l'inscription
                    IdUser = _mVM.MM.Connexion(tBMailInscrip.Text, tBMdpInscrip.Password);

                    InscriptionView _inscrip = new InscriptionView(IdUser);
                    _inscrip.Show();
                    this.Close();
                }
            }
            else
            {
                _mVM.ErrMessage = "Les Mots de passe ne correspondent pas. \n Veuillez à nouveau essayer.";
                PopUpInfo.Visibility = Visibility.Visible;
                rectan.Visibility = Visibility.Visible;
                Timer _timerPopUp;
                _timerSlider.Tick += new EventHandler(CacherPopUp);
                _timerSlider.Interval = 2000;
                _timerSlider.Start();    
            }
        }
    }
}
