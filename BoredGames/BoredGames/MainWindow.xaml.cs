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

namespace BoredGames
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       // public List<Player> Players { get; private set; }
        PlayerList _playerViewModel;

        public List<Game> Games { get; private set; }

        //public List<string> test { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            //Players = new List<Player>();
            _playerViewModel = (PlayerList)lvPlayers.DataContext;
            Games = new List<Game>();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _playerViewModel.Players.Add(new Player("foo"));
        }

        private void btnSelectAllPlayers_Click(object sender, RoutedEventArgs e)
        {
            lvPlayers.SelectAll();
        }

        private void btnUnselectAllPlayers_Click(object sender, RoutedEventArgs e)
        {
            lvPlayers.SelectedItem = null;
        }

        private void btnSelectAllGames_Click(object sender, RoutedEventArgs e)
        {
            lvGames.SelectAll();
        }

        private void btnUnselectAllGames_Click(object sender, RoutedEventArgs e)
        {
            lvGames.SelectedItem = null;
        }

        private void btnEditPlayer_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnEditGame_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnNewGame_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
