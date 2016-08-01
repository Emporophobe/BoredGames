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
        PlayerList _PlayerList;
        GameList _GameList;

        private Game _LastSelection;

        public MainWindow()
        {
            InitializeComponent();

            _PlayerList = (PlayerList)lvPlayers.DataContext;
            _GameList = (GameList)lvGames.DataContext;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _PlayerList.Players.Add(new Player("foo"));
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
            if (_LastSelection != null)
            {
                var editWindow = new GameWindow(_LastSelection);
                editWindow.ShowDialog();
            }
        }

        private void btnNewGame_Click(object sender, RoutedEventArgs e)
        {
            Game newGame = new Game("New Game", 2, 4, 1);
            var newGameWindow = new GameWindow(newGame);
            newGameWindow.ShowDialog();

            _GameList.Games.Add(newGame);
        }

        private void lvGames_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count == 1)
            {
                _LastSelection = _GameList.Games.First(g => g.Equals((Game)e.AddedItems[0]));
            }
        }
    }
}
