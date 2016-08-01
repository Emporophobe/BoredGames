using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace BoredGames
{
    /// <summary>
    /// Contains basic information about a game
    /// </summary>
    public class Game : INotifyPropertyChanged
    {
        private string _Name;
        /// <summary>
        /// The name of the game
        /// </summary>
        public string Name 
        {
            get { return _Name; }
            set 
            {
                _Name = value;
                RaisePropertyChanged("Name");
            }
        }
        /// <summary>
        /// The minimum number of players
        /// </summary>
        public int MinNumPlayers { get; set; }
        /// <summary>
        /// The maximum number of players
        /// </summary>
        public int MaxNumPlayers { get; set; }
        /// <summary>
        /// The approximate time for one game (in hours)
        /// </summary>
        public double PlayTime { get; set; }

        /// <summary>
        /// Create a new game with the given parameters
        /// </summary>
        /// <param name="Name">The name of the game</param>
        /// <param name="MinNumPlayers">The minimum number of players to play</param>
        /// <param name="MaxNumPlayers">THe maximum number of players to play</param>
        /// <param name="PlayTime">How many hours the game takes</param>
        public Game(string Name, int MinNumPlayers, int MaxNumPlayers, double PlayTime)
        {
            this.Name = Name;
            this.MinNumPlayers = MinNumPlayers;
            this.MaxNumPlayers = MaxNumPlayers;
            this.PlayTime = PlayTime;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
