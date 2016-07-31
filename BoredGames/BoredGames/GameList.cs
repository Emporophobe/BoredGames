﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace BoredGames
{
    class GameList
    {
        public ObservableCollection<Game> Games { get; private set; }

        private ObservableCollection<string> _Times;

        public ObservableCollection<string> Times { get { return _Times; } }

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

        public GameList()
        {
            Games = new ObservableCollection<Game>() 
            {
                new Game("Monopoly", 2, 6, 2),
                new Game("Chess", 2, 2, 1),
                new Game("Diplomacy", 4, 6, 100)
            };

            _Times = new ObservableCollection<string>(TimeStrings.Keys.ToList());
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
