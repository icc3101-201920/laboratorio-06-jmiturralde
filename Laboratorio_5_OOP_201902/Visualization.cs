﻿using System;
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
                    Console.WriteLine("Id carta: " + i);
                    Console.WriteLine("Nombre Carta: " + hand.Cards[i].Name);
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Id carta: " + i);
                    Console.WriteLine("Nombre Carta: " + hand.Cards[i].Name);
                    Console.ResetColor();
                }

            }
        }

        public static void ShowDecks(List<Deck> decks)
        {
            Console.WriteLine("Select one Deck:");
            for (int i = 0; i < decks.Count; i++)
            {
                Console.WriteLine($"({i}) Deck {i + 1}");
            }
        }

        public static void ShowCapatains(List<SpecialCard> captains)
        {
            Console.WriteLine("Select one Deck:");
            for (int i = 0; i < captains.Count; i++)
            {
                Console.WriteLine($"({i}) {captains[i].Name} : {captains[i].Effect}");
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
        public static void ShowProgramMessage (string message)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        public static void ShowListOptions(string title, List<String> options)
        {
            ShowProgramMessage(title);
            for (int i = 0; i < options.Count; i++)
            {
                Console.WriteLine($"({i}) {options[i]}");
            }
        }

        public static void ClearConsole()
        {
            Console.Clear();
        }

        public static void Play(Player player, Deck deck, SpecialCard captain, Hand hand)
        {

            Visualization.ShowHand(hand);

        }


    }
}
