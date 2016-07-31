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
