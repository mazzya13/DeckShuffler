using System;
using static DeckShuffler.Commands;

namespace DeckShuffler
{
    class ProgramUI
    {
        static void Main()
        {
            ProgramStartMessage();
            ProgramCommands();
        }
        static void ProgramCommands()
        {
            
            string command = Console.ReadLine().ToLower();
            do
            {
                switch (command)
                {
                    case "создать именованную колоду":
                        CreateNamedDeck();
                        goto default;
                    case "удалить именованную колоду":
                        DeleteNamedDeck();
                        goto default;
                    case "получить список колод":
                        GetDeckNamesList();
                        goto default;
                    case "перетасовать колоду":
                        DeckShuffle();
                        goto default;
                    case "показать колоду с именем":
                        FindNamedDeck();
                        goto default;
                    default:
                        Console.WriteLine("\nВведите команду:");
                        command = Console.ReadLine().ToLower();
                        break;
                }
            }
            while (command != "закрыть программу");
        }
        static void ProgramStartMessage() => Console.WriteLine(
                "Введите одну из предложенных комманд:" +
                "\nСоздать именованную колоду" +
                "\nУдалить именованную колоду" +
                "\nПолучить список колод" +
                "\nПеретасовать колоду" +
                "\nПоказать колоду с именем" +
                "\nЗакрыть программу" +
                "\n\nВведите команду:");
    }
}
