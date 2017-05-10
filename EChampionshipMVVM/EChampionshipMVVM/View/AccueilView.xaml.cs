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

namespace EChampionshipMVVM.View
{
    /// <summary>
    /// Interaction logic for AccueilView.xaml
    /// </summary>
    public partial class AccueilView : Window
    {
        int IdUser;
        AccueilViewModel _aVM;
        public AccueilView(int _id)
        {
            InitializeComponent();
            IdUser = _id;
            AccueilViewModel _aVM = (AccueilViewModel)DataContext;
            Utilisateur _user = new Utilisateur(IdUser);
            _aVM.User = _user;
        }

        private void ChangeMenu(object sender, SelectionChangedEventArgs e)
        {
            ListView lV = sender as ListView;

            switch((String)lV.SelectedItem)
            {
                case "Accueil":
                    AccueilView _aV = new AccueilView(IdUser);
                    _aV.Show();
                    this.Close();
                    break;
                case "Mon Compte":
                    MonCompteView _mCV = new MonCompteView(IdUser);
                    _mCV.Show();
                    this.Close();
                    break;
                case "Team":
                    TeamView _tM = new TeamView(IdUser);
                    _tM.Show();
                    this.Close();
                    break;
            }
        }
    }
}
