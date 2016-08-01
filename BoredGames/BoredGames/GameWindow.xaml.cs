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

namespace BoredGames
{
    /// <summary>
    /// Interaction logic for GameWindow.xaml
    /// </summary>
    public partial class GameWindow : Window
    {
        private Game _TheGame = null;

        public GameWindow()
        {
            InitializeComponent();
        }

        public GameWindow(Game g)
            :this()
        {
            _TheGame = g;

            tbName.Text = g.Name;
            cbMinPlayers.SelectedValue = g.MinNumPlayers;
            cbMaxPlayers.SelectedValue = g.MaxNumPlayers;
            cbLength.SelectedValue = g.PlayTime.ToHours();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            _TheGame.Name = tbName.Text;
            _TheGame.MinNumPlayers = (int)cbMinPlayers.SelectedItem;
            _TheGame.MaxNumPlayers = (int)cbMaxPlayers.SelectedItem;
            _TheGame.PlayTime = ((string)cbLength.SelectedValue).ToTime();

            this.Close();
        }

        // TODO: Make this actually update the list
        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            var theGameList = (GameList)this.DataContext;
            bool test = theGameList.Games.Remove(theGameList.Games.First(g => g.Name == _TheGame.Name)); // This can probably be nicer
            this.Close();
        }
    }
}
