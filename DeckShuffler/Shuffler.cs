using System;
using System.Collections.Generic;

namespace DeckShuffler
{
    class Shuffler
    {
        public static void SimpleShuffler(List<Card> deckToShuffle)
        {
            Random random = new Random();
            for (var i = deckToShuffle.Count - 1; i > 1; i--)
            {
                var rnd = random.Next(i + 1);
                var tmp = deckToShuffle[rnd];
                deckToShuffle[rnd] = deckToShuffle[i];
                deckToShuffle[i] = tmp;
            }
        }
    }
}
