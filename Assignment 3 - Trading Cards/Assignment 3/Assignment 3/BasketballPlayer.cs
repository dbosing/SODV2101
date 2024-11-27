using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    // Represents a basketball player with relevant properties for the trading card.
    public class BasketballPlayer
    {
        public string Name { get; set; }
        public string Team { get; set; }
        public string PhotoPath { get; set; }
        public double PointsPerGame { get; set; }
        public double AssistsPerGame { get; set; }
        public double ReboundsPerGame { get; set; }
        public double StealsPerGame { get; set; }

        // Generates a summary of the player's stats
        public string StatsSummary =>
            $"PPG: {PointsPerGame}, APG: {AssistsPerGame}, RPG: {ReboundsPerGame}, SPG: {StealsPerGame}";
    }
}
