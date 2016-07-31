using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace BoredGames
{
    class PlayerList //: INotifyPropertyChanged
    {
        public ObservableCollection<Player> Players { get; set; }

        private List<string> _PlayerCount = new List<string> { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "Many" };
        public List<string> PlayerCount { get {return _PlayerCount;} }



        public PlayerList()
        {
            Players = new ObservableCollection<Player>() { new Player("foo"), new Player("bar") };
        }

        //public event PropertyChangedEventHandler PropertyChanged;

        //private void RaisePropertyChanged(string propertyName)
        //{
        //    PropertyChangedEventHandler handler = PropertyChanged;
        //    if (handler != null)
        //    {
        //        handler(this, new PropertyChangedEventArgs(propertyName));
        //    }
        //}
    }
}
