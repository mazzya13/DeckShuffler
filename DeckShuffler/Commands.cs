using System;
using System.Collections.Generic;

namespace DeckShuffler
{
    class Commands : DecksDictionary
    {
        public static void CreateNamedDeck()
        {
            Console.WriteLine("Введите название колоды");
            string deckName = Console.ReadLine();
            var deck = Deck.CreateDeck();
            if (!decksDictionary.ContainsKey(deckName))
            {
                decksDictionary.Add(deckName, deck);
                ShowDeck(deckName);
                Console.WriteLine($"\nКолода {deckName} создана успешно");
            }
            else
            {
                Console.WriteLine("Колода с данным именем уже существует! Колода не была создана\n");
            }
        }
        public static void DeleteNamedDeck()
        {
            Console.WriteLine("Введите имя колоды");
            string deckName = Console.ReadLine();
            if (decksDictionary.ContainsKey(deckName))
            {
                decksDictionary.Remove(deckName);
                Console.WriteLine($"Колода {deckName} удалена успешно");
            }
            else
            {
                Console.WriteLine("Колоды с указанным именем не существует!");
            }
        }
        public static void GetDeckNamesList()
        {
            Console.WriteLine("Есть колоды с указанными именами: ");
            foreach (var deck in decksDictionary)
                Console.WriteLine($"\n{deck.Key}");
        }
        public static void FindNamedDeck()
        {
            Console.WriteLine("Введите имя колоды");
            string deckName = Console.ReadLine();
            if (decksDictionary.ContainsKey(deckName))
                ShowDeck(deckName);
            else
                Console.WriteLine("Колоды с указанным именем не существует!");
        }
        public static void DeckShuffle()
        {
            GetDeckNamesList();
            Console.WriteLine("\nВведите имя колоды для перетасовки:");
            string deckName = Console.ReadLine();
            var deckToShuffle = decksDictionary[deckName];
            Shuffler.SimpleShuffler(deckToShuffle);
            ShowDeck(deckName);
            Console.WriteLine("\nКолода успешно перетосована");
        }
        private static void ShowDeck(string deckName)
        {
            foreach (var card in decksDictionary[deckName])
                Console.WriteLine(card);
        }
    }
}
