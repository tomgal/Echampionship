using EChampionshipMVVM.Class;
using EChampionshipMVVM.ViewModel;
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
using System.Windows.Shapes;
using System.Windows.Forms;

namespace EChampionshipMVVM.View
{
    /// <summary>
    /// Interaction logic for InscriptionView.xaml
    /// </summary>
    public partial class InscriptionView : Window
    {
        private int IdUser;
        InscriptionViewModel _iVM;
        Timer _timerPopUp;

        public InscriptionView(int Id)
        {
            InitializeComponent();
            IdUser = Id;
            _timerPopUp = new Timer();
        }

        private void listView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void AjoutJeux(object sender, RoutedEventArgs e)
        {
            _iVM = (InscriptionViewModel)DataContext;
            Jeux _game = (Jeux)lesJeux.SelectedItem;
            bool test = true;

            foreach(Jeux j in _iVM.MyGame)
            {
                if(j.Nom == _game.Nom)
                {
                    test = false;
                }
            }

            if (test)
            {
                ComboBoxItem cBI = (ComboBoxItem)cBLevel.SelectedItem;
                _game.Level = (String)cBI.Content;
                List<Jeux> _Refresh = _iVM.MyGame;
                _Refresh.Add(_game);
                _iVM.MyGame = _Refresh;
                mesJeux.Items.Refresh();
            }

        }

        private void FinaliserInscrip(object sender, RoutedEventArgs e)
        {
            if(condition.IsChecked == true)
            {
                if (tBPrenom.Text != "Prénom*" && tBNom.Text != "Nom*" && tBPseudo.Text != "Pseudo*")
                {
                    _iVM = (InscriptionViewModel)DataContext;
                    if(tBPseudoBattleNet.Text == "Pseudo BattleNet")
                    {
                        tBPseudoBattleNet.Text = "";
                    }

                    if(tBPseudoLol.Text == "Pseudo League Of Legends")
                    {
                        tBPseudoLol.Text = "";
                    }

                    if(tBPseudoOrigin.Text == "Pseudo Origin")
                    {
                        tBPseudoOrigin.Text = "";
                    }

                    if(tBPseudoSteam.Text == "Pseudo Steam")
                    {
                        tBPseudoSteam.Text = "";
                    }

                    _iVM.IM.FinaliserInscription(tBPrenom.Text, tBNom.Text, tBPseudo.Text, tBPseudoLol.Text, tBPseudoBattleNet.Text, tBPseudoOrigin.Text, tBPseudoSteam.Text, _iVM.MyGame, IdUser);

                    AccueilView _aV = new AccueilView(IdUser);
                    _aV.Show();
                    this.Close();
                }
                else
                {
                    _iVM = (InscriptionViewModel)DataContext;
                    _iVM.ErrMessage = "Les champs marqués d'une '*' \n sont obligatoire";
                    PopUpInfo.Visibility = Visibility.Visible;
                    rectan.Visibility = Visibility.Visible;
                    _timerPopUp.Tick += new EventHandler(CacherPopUp);
                    _timerPopUp.Interval = 2000;
                    _timerPopUp.Start();
                }
            }
            else
            {
                _iVM = (InscriptionViewModel)DataContext;
                _iVM.ErrMessage = "Veuillez acceptez les conditions \n d'utilisation de l'application";
                PopUpInfo.Visibility = Visibility.Visible;
                rectan.Visibility = Visibility.Visible;
                _timerPopUp.Tick += new EventHandler(CacherPopUp);
                _timerPopUp.Interval = 2000;
                _timerPopUp.Start();
            }
        }

        private void CacherPopUp(object sender, EventArgs e)
        {
            _timerPopUp.Enabled = false;
            PopUpInfo.Visibility = Visibility.Collapsed;
            rectan.Visibility = Visibility.Collapsed;
        }

        private void RemoveJeux(object sender, RoutedEventArgs e)
        {
            _iVM = (InscriptionViewModel)DataContext;
            _iVM.MyGame.Remove((Jeux)mesJeux.SelectedItem);
            mesJeux.Items.Refresh();
        }

        private void ResetChamps(object sender, MouseButtonEventArgs e)
        {
            System.Windows.Controls.TextBox _sender = sender as System.Windows.Controls.TextBox;
            _sender.Text = "";
        }

    }
}
