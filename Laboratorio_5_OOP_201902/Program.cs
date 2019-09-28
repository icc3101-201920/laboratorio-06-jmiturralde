using Laboratorio_5_OOP_201902.Cards;
using System;
using System.Collections.Generic;

namespace Laboratorio_5_OOP_201902
{
    class Program
    {
        
        static void Main(string[] args)
        {
            List<String> opcionesj = new List<string>();
            opcionesj.Add("Change Card");
            opcionesj.Add("Pass");

            Game game = new Game();
            game.AddDecks();
            game.AddCaptains();

            //Lista players
            string[] players = new string[2];
            players[0] = "Player 1";
            players[1] = "Player 2";

            Player player = new Player();
            Player player1 = new Player();
            List<Player> playerS = new List<Player>();
            playerS.Add(player);
            playerS.Add(player1);

            Random rand = new Random();
            int index = rand.Next(players.Length);
            int index2 = 0;
            if (index == 0)
            {
                index2 = 1;
            }
            else

            Console.WriteLine($"Randomly selected player is {players[index]}");
            Visualization.ShowProgramMessage($"{players[index]} select Deck and Captain");

            List<Deck> decks = new List<Deck>();
            decks.Add(game.Decks[0]);
            decks.Add(game.Decks[1]);
            Visualization.ShowDecks(decks);
            int deckDecition = Visualization.GetUserInput();

            if (deckDecition == 0 && index ==0)
            {
                playerS[0].Deck = decks[0];
                playerS[1].Deck = decks[1];
                Visualization.ShowProgramMessage($"Deck Selected by {players[0]} was: deck 1");
                Visualization.ShowProgramMessage($"Deck given to {players[1]} was: deck 2");
            }
            else if (deckDecition == 0 && index == 1)
            {
                playerS[1].Deck = decks[0];
                playerS[0].Deck = decks[1];
                Visualization.ShowProgramMessage($"Deck Selected by {players[1]} was: deck 1");
                Visualization.ShowProgramMessage($"Deck given to {players[0]} was: deck 2");
            }
            else if (deckDecition == 1 && index == 0)
            {
                playerS[0].Deck = decks[1];
                playerS[1].Deck = decks[0];
                Visualization.ShowProgramMessage($"Deck Selected by {players[0]} was: deck 2");
                Visualization.ShowProgramMessage($"Deck given to {players[1]} was: deck 1");
            }
            else
            {
                playerS[1].Deck = decks[1];
                playerS[0].Deck = decks[0];
                Visualization.ShowProgramMessage($"Deck Selected by {players[1]} was: deck 2");
                Visualization.ShowProgramMessage($"Deck given to {players[0]} was: deck 1");
            }

            
            Visualization.ShowCapatains(game.Captains);
            int captainDecition = Visualization.GetUserInput();
            
            if(captainDecition == 0 && index == 0)
            {
                playerS[0].ChooseCaptainCard(game.Captains[0]);
                playerS[1].ChooseCaptainCard(game.Captains[1]);
                Visualization.ShowProgramMessage($"Captain Selected by {players[0]} was: {playerS[0].Captain.Name}\n");
                Visualization.ShowProgramMessage($"Captain given to {players[1]} was: {playerS[1].Captain.Name}\n");
            }

            else if(captainDecition == 0 && index == 1)
            {
                playerS[1].ChooseCaptainCard(game.Captains[0]);
                playerS[0].ChooseCaptainCard(game.Captains[1]);
                Visualization.ShowProgramMessage($"Captain Selected by {players[1]} was: {playerS[1].Captain.Name}\n");
                Visualization.ShowProgramMessage($"Captain given to {players[0]} was: {playerS[0].Captain.Name}\n");
            }
            else if(captainDecition == 1 && index == 0)
            {
                playerS[0].ChooseCaptainCard(game.Captains[1]);
                playerS[1].ChooseCaptainCard(game.Captains[0]);
                Visualization.ShowProgramMessage($"Captain Selected by {players[0]} was: {playerS[0].Captain.Name}\n");
                Visualization.ShowProgramMessage($"Captain given to {players[1]} was: {playerS[1].Captain.Name}\n");
            }
            else
            {
                playerS[1].ChooseCaptainCard(game.Captains[1]);
                playerS[0].ChooseCaptainCard(game.Captains[0]);
                Visualization.ShowProgramMessage($"Captain Selected by {players[1]} was: {playerS[1].Captain.Name}\n");
                Visualization.ShowProgramMessage($"Captain given to {players[0]} was: {playerS[0].Captain.Name}\n");
            }


            Board board = new Board();
            player.Board = board;
            player1.Board = board;

            player.Deck.Shuffle();
            player1.Deck.Shuffle();

            player.FirstHand();
            player1.FirstHand();

            bool chekeo = game.CheckIfEndGame(player, player1);

            Console.WriteLine($"Turn of {players[index]}\n");
            Visualization.ShowHand(playerS[index].Hand);
            Visualization.ShowListOptions("Change 3 Cards or ready to play", opcionesj);

            int cardDesition = Visualization.GetUserInput();
            Console.WriteLine($"Turn of {players[index2]}\n");
            Visualization.ShowHand(playerS[index2].Hand);
            Visualization.ShowListOptions("Change 3 Cards or ready to play", opcionesj);


            //Cmabio de Cartas
            /*
            int counter = 0;

            if (cardDesition == 0)
            {
                while (cardDesition == -1 || counter >= 3)
                {
                    counter += 1;
                }
            }
            else
            {
                Visualization.ShowHand(playerS[index2].Hand);
                Visualization.ShowListOptions("Change 3 Cards or ready to play", opcionesj);
            }
            */





            /*
            int counter = 1;
            Console.WriteLine("Player Hand:");
            foreach (Card card in player.Hand.Cards)
            {
                Console.WriteLine($"{counter++}: {card.Name}");
            }
            counter = 1;
            Console.WriteLine("\nPlayer Deck:");
            foreach (Card card in player.Deck.Cards)
            {
                Console.WriteLine($"{counter++}: {card.Name}");
            }
            */
            //Test Change Card

            //player.ChangeCard(3);
            //counter = 1;
            //Console.WriteLine("\n New Player Hand:");
            //foreach (Card card in player.Hand.Cards)
            //{
            //    Console.WriteLine($"{counter++}: {card.Name}");
            //}
            //counter = 1;
            //Console.WriteLine("\n New Player Deck:");
            //foreach (Card card in player.Deck.Cards)
            //{
            //    Console.WriteLine($"{counter++}: {card.Name}");
            //}


            //Test draw card

            //player.DrawCard();
            //counter = 1;
            //Console.WriteLine("\n New Player Hand:");
            //foreach (Card card in player.Hand.Cards)
            //{
            //    Console.WriteLine($"{counter++}: {card.Name}");
            //}
            //counter = 1;
            //Console.WriteLine("\n New Player Deck:");
            //foreach (Card card in player.Deck.Cards)
            //{
            //    Console.WriteLine($"{counter++}: {card.Name}");
            //}


            //Test play card

            //player.PlayCard(6);
            //counter = 1;
            //Console.WriteLine("\n New Player Hand:");
            //foreach (Card card in player.Hand.Cards)
            //{
            //    Console.WriteLine($"{counter++}: {card.Name}");
            //}
            //Console.WriteLine(String.Join(", ", board.GetMeleeAttackPoints()));
            //Console.WriteLine(String.Join(", ", board.GetRangeAttackPoints()));
            //Console.WriteLine(String.Join(", ", board.GetLongRangeAttackPoints()));


        }
    }
}
