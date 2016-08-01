using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace BoredGames
{
    class GameList : INotifyPropertyChanged
    {
        private ObservableCollection<Game> _Games = new ObservableCollection<Game>();
        public ObservableCollection<Game> Games 
        {
            get { return _Games; }
            set
            {
                _Games = value;
                RaisePropertyChanged("Games");
            }
        }

        public ObservableCollection<string> Times { get; private set; }

        public readonly static Dictionary<string, double> TimeStrings = new Dictionary<string, double>()
        {
            {"<30 Min", 0.25},
            {"30 Min", 0.5},
            {"1 Hour", 1},
            {"1.5 Hours", 1.5},
            {"2 Hours", 2},
            {"3 Hours", 3},
            {"4 Hours", 4},
            {"5 Hours", 5},
            {"A Long Time", 100}
        };

        public ObservableCollection<int> Players { get; private set; }

        public GameList()
        {
            Games = new ObservableCollection<Game>() 
            {
                new Game("Monopoly", 2, 6, 2),
                new Game("Chess", 2, 2, 1),
                new Game("Diplomacy", 4, 6, 100)
            };

            Players = new ObservableCollection<int>(Enumerable.Range(1, 20));
            Times = new ObservableCollection<string>(TimeStrings.Keys.ToList());
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

    static class ExtentionMethods
    {
        /// <summary>
        /// Converts specific strings into and int for the number of hours the string represented
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static double ToTime(this string s)
        {
            double temp;
            return GameList.TimeStrings.TryGetValue(s, out temp) ? temp : -1;
        }

        public static string ToHours(this double d)
        {
            return GameList.TimeStrings.Keys.First(x => GameList.TimeStrings[x] == d);
        }
    }
}
