﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kings_Card_Game
{
    internal class Game
    {
        private Players player;
        private Deck deck;

        public Game()
        {
            this.player = new Players();
            this.deck = new Deck();
        }

        public Game(Deck newDeck, Players newPlayer)
        {
            this.player = newPlayer;
            this.deck = newDeck;
        }

        public Card NextCard()
        {
            return deck.getNextCard();
        }
        public void SetDecks(double num)
        {
            deck.setDecks(num);
        }
        public void AddDeck(double num)
        {
            deck.addDeck(num);
            MessageBox.Show("Deck Added",num + " Decks have been added.");
        }
        public void RemoveDeck(double num)
        {
            Boolean result = deck.removeDeck(num);
            if (result) 
            {
                MessageBox.Show("Deck Removed", num + " Decks have been removed.");
            }
            else
            {
                MessageBox.Show("Error!"," Decks could not be removed as the number of decks to be removed was greater than the number of decks available.");
            }
        }
        public double NumberOfDecks()
        {
            return deck.getNumberOfDecks();
        }
        public int CardsLeft()
        {
            return deck.getCardsLeft();
        }
        public void ExcludeCard(string card)
        {
            Boolean result = deck.excludeCard(card);
            if (result)
            {
                MessageBox.Show("Card Excluded", "All occurences of " + card + " have been removed.");
            }
            else
            {
                MessageBox.Show("Error!","The card " + card + "could not be removed.");
            }
        }
        public string ResetGame()
        {
            Boolean result = deck.resetGame();
            if (result)
            {
                MessageBox.Show("Game Reset", "The game and the decks have been reset");
                return FirstPlayer();
            }
            else
            {
                MessageBox.Show("Error!","The game has not been reset");
                return "Unknown";
            }
        }
        public void AddPlayer(string name)
        {
            player.addPlayer(name);
            MessageBox.Show("Player Added", "The player " + name + " has been added.");
        }
        public void SetPlayers(DataGridView grid)
        {
            foreach (string x in grid.Rows)
            {
                player.addPlayer(x);
            }
        }
        public void SetExcludedCards(DataGridView grid)
        {
            Boolean result;
            foreach (string x in grid.Rows)
            {
                result = deck.excludeCard(x);
            }
        }
        public string FirstPlayer()
        {
            return player.getPlayer();
        }
        public string NextPlayer(string name)
        {
            return player.nextPlayer(name);
        }
        public void RemovePlayer(string name)
        {
            if (player.removePlayer(name))
            {
                MessageBox.Show("Player Removed", "The player " + name + " has been removed from the game");
            }
            else
            {
                MessageBox.Show("Error!", "The player " + name + " could not be removed.");
            }
        }
        public void ChangePlayerName(string oldName, string newName)
        {
            if (player.changePlayerName(oldName, newName))
            {
                MessageBox.Show("Player Name Changed!", "The player name " + oldName + " has been changed to " + newName);
            }
            else
            {
                MessageBox.Show("Error!", "The name of player " + oldName + "could not be changed.");
            }
        }
    }
}