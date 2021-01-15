using System;
using System.Collections.Generic;
using System.Text;

namespace DeckShuffler
{
    public enum Faces
    {
        Ace,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King
    }    
    public enum Suits
    {
        Hearts,
        Clubs,
        Diamonds,
        Spades
    }
    class Deck
    {
        public static List<Card> CreateDeck()
        {
            var deck = new List<Card>();
            var facesSize = Enum.GetNames(typeof(Faces)).Length;
            var suitsSize = Enum.GetNames(typeof(Suits)).Length;
            for (int i = 0; i < suitsSize; i++)
                for (int j = 0; j < facesSize; j++)
                    deck.Add(new Card(Enum.GetName(typeof(Faces), j), Enum.GetName(typeof(Suits), i)));
            return deck;
        }
    }
}
