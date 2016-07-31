using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoredGames
{
    /// <summary>
    /// Represents a person's preferences for each game available
    /// </summary>
    public class Player
    {
        public string Name { get; private set; }

        private Dictionary<Game, int> _GameScores;

        public Player(string name)
        {
            this.Name = name;
            _GameScores = null;
        }

        /// <summary>
        /// Change the rating of a game, or add a new game if it isn't already listed
        /// </summary>
        /// <param name="game"></param>
        /// <param name="rating"></param>
        void UpdateRating(Game game, int rating)
        {
            _GameScores[game] = rating;
        }
    }
}
