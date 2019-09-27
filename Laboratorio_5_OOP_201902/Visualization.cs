using System;
using System.Collections.Generic;
using System.Text;
using Laboratorio_5_OOP_201902.Cards;

namespace Laboratorio_5_OOP_201902
{
    public static class Visualization
    {
        public static void ShowHand(Hand hand)
        {
            for (int i = 0; i < hand.Cards.Count; i++)
            {
                if (hand.Cards[i].Type == Enums.EnumType.melee || hand.Cards[i].Type == Enums.EnumType.range || hand.Cards[i].Type == Enums.EnumType.range)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Carta " + hand.Cards[i]);
                    Console.WriteLine("Id carta " + i);
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Carta " + hand.Cards[i]);
                    Console.WriteLine("Id carta " + i);
                    Console.ResetColor();
                }

            }
        }

        public static void ShowDecks(List<Deck> decks)
        {
            Console.WriteLine("Select one Deck:");
            for (int i = 0; i < decks.Count; i++)
            {
                Console.WriteLine($"({i}) {decks[i]}");
            }
        }

        public static void ShowCapatins(List<SpecialCard> captains)
        {
            Console.WriteLine("Select one Deck:");
            for (int i = 0; i < captains.Count; i++)
            {
                Console.WriteLine($"({i}) {captains[i].Name} {captains[i].Effect}");
            }
        }

        public static void ConsoleError(string message)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Beep();
            Console.WriteLine(message);
            Console.ResetColor();
        }
        public static int GetUserInput()
        {
            string option = Console.ReadLine();
            int optionNumber;
            while (!int.TryParse(option, out optionNumber))
            {
                ConsoleError("Input must be a number");
                option = Console.ReadLine();
            }
            return optionNumber;
        }
        public static void ConsoleOutput(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        public static void ShowListOptions(string title, List<String> options)
        {
            ConsoleOutput(title);
            for (int i = 0; i < options.Count; i++)
            {
                Console.WriteLine($"({i}) {options[i]}");
            }
        }


    }
}
