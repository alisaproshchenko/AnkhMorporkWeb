using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Auxiliary
{
    public class EventsGenerator
    {
        private static readonly double Probability = 1.0 / Enum.GetNames(typeof(NPCs)).Length;
        public static Dictionary<NPCs, double> Variety { get; } = new Dictionary<NPCs, double>
        {
            {NPCs.Assassin, Probability},
            {NPCs.ThievesGuild, Probability},
            {NPCs.Beggar, Probability},
            {NPCs.Fool, Probability}
        };
        public static readonly Random Random = new Random();

        public NPCs GenerateEvent() //choosing a next character to meet
        {
            var key = Random.NextDouble();
            var intervalEnds = 0.0;
            var chosen = NPCs.Assassin;

            for (var i = 0; i < Variety.Count; i++)
            {
                intervalEnds += Variety[(NPCs)i];
                if (key > intervalEnds) continue;

                chosen = (NPCs)i;
                break;
            }

            return chosen;
        }
    }
}