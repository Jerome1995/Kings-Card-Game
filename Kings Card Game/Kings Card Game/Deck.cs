using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Kings_Card_Game.Properties;

// ReSharper disable CompareOfFloatsByEqualityOperator

namespace Kings_Card_Game
{
    public abstract class Deck : Card
    {
        //Variables
        private double _numberOfDecks;
        private double _orignalNumberOfDecks;
        private int _cardsLeft;
        private int _cardsUsed;
        private List<string> _excludedCards = new List<string>();
        private readonly List<string> _deckOfCards = new List<string>();
        private readonly List<string> _usedCards = new List<string>();
        private int _index;
        private readonly Random _random = new Random();
        private readonly List<String> _orignalDeckOfCards = new List<string>
        {
            "Ace Of Spades","Two Of Spades","Three Of Spades","Four Of Spades","Five Of Spades","Six Of Spades","Seven Of Spades",
            "Eight Of Spades","Nine Of Spades","Ten Of Spades","Ace Of Hearts","Two Of Hearts","Three Of Hearts","Four Of Hearts",
            "Five Of Hearts","Six Of Hearts","Seven Of Hearts","Eight Of Hearts","Nine Of Hearts","Ten Of Hearts","Ace Of Diamonds",
            "Two Of Diamonds","Three Of Diamonds","Four Of Diamonds","Five Of Diamonds","Six Of Diamonds","Seven Of Diamonds",
            "Eight Of Diamonds","Nine Of Diamonds","Ten Of Diamonds","Ace Of Clubs","Two Of Clubs","Three Of Clubs","Four Of Clubs",
            "Five Of Clubs","Six Of Clubs","Seven Of Clubs","Eight Of Clubs","Nine Of Clubs","Ten Of Clubs","Jack Of Spades",
            "Jack Of Hearts","Jack Of Diamonds","Jack Of Clubs","Queen Of Spades","Queen Of Hearts","Queen Of Diamonds",
            "Queen Of Clubs","King Of Spades","King Of Hearts","King Of Diamonds","King Of Clubs"
        };

        readonly Dictionary<string, string> _cardRule = new Dictionary<string, string>
        {
            {"Ace Of Spades","WATERFALL: All players drink until player on their right stops drinking. Current player starts!"},
            {"Two Of Spades","FOR YOU: Current player picks another player to drink for two seconds!"},
            {"Three Of Spades","FOR ME: Current player drinks for two seconds!"},
            {"Four Of Spades","GIRLS: All girls drink for two seconds!"},
            {"Five Of Spades","NEVER HAVE I EVER: Current player names something they have not done and other players must drink if"},
            {"Six Of Spades","GUYS: Boys drink for two seconds!"},
            {"Seven Of Spades","HEAVAN: All players reach for the sky, last player to raise his hand drinks for 2 seconds!"},
            {"Eight Of Spades","PICK A MATE: Current player picks another player to drink everytime they drink for the rest of the game!"},
            {"Nine Of Spades","RHYME: Current player says a word, in clockwise rotation other players must name words that rhyme, first" +
                                "to make mistake must drink for two seconds!"},
            {"Ten Of Spades","CATEGORY: Current player picks a category, in a clockwise rotation other players will name things related" +
                                "to this category. First player to make a mistake will drink for 2 seconds!"},
            {"Ace Of Clubs","WATERFALL: All players drink until player on their right stops drinking. Current player starts!"},
            {"Two Of Clubs","FOR YOU: Current player picks another player to drink for two seconds!"},
            {"Three Of Clubs","FOR ME: Current player drinks for two seconds!"},
            {"Four Of Clubs","GIRLS: All girls drink for two seconds!"},
            {"Five Of Clubs","NEVER HAVE I EVER: Current player names something they have not done and other players must drink if" +
                            "they have done it!"},
            {"Six Of Clubs","GUYS: Boys drink for two seconds!"},
            {"Seven Of Clubs","HEAVAN: All players reach for the sky, last player to raise his hand drinks for 2 seconds!"},
            {"Eight Of Clubs","PICK A MATE: Current player picks another player to drink everytime they drink for the rest of the game!"},
            {"Nine Of Clubs","RHYME: Current player says a word, in clockwise rotation other players must name words that rhyme, first" +
                            "to make mistake must drink for two seconds!"},
            {"Ten Of Clubs","CATEGORY: Current player picks a category, in a clockwise rotation other players will name things related" +
                            "to this category. First player to make a mistake will drink for 2 seconds!"},
            {"Ace Of Hearts","WATERFALL: All players drink until player on their right stops drinking. Current player starts!"},
            {"Two Of Hearts","FOR YOU: Current player picks another player to drink for two seconds!"},
            {"Three Of Hearts","FOR ME: Current player drinks for two seconds!"},
            {"Four Of Hearts","GIRLS: All girls drink for two seconds!"},
            {"Five Of Hearts","NEVER HAVE I EVER: Current player names something they have not done and other players must drink if" +
                            "they have done it!"},
            {"Six Of Hearts","GUYS: Boys drink for two seconds!"},
            {"Seven Of Hearts","HEAVAN: All players reach for the sky, last player to raise his hand drinks for 2 seconds!"},
            {"Eight Of Hearts","PICK A MATE: Current player picks another player to drink everytime they drink for the rest of the game!"},
            {"Nine Of Hearts","RHYME: Current player says a word, in clockwise rotation other players must name words that rhyme, first" +
                            "to make mistake must drink for two seconds!"},
            {"Ten Of Hearts","CATEGORY: Current player picks a category, in a clockwise rotation other players will name things related" +
                            "to this category. First player to make a mistake will drink for 2 seconds!"},
            {"Ace Of Diamonds","WATERFALL: All players drink until player on their right stops drinking. Current player starts!"},
            {"Two Of Diamonds","FOR YOU: Current player picks another player to drink for two seconds!"},
            {"Three Of Diamonds","FOR ME: Current player drinks for two seconds!"},
            {"Four Of Diamonds","GIRLS: All girls drink for two seconds!"},
            {"Five Of Diamonds","NEVER HAVE I EVER: Current player names something they have not done and other players must drink if" +
                            "they have done it!"},
            {"Six Of Diamonds","GUYS: Boys drink for two seconds!"},
            {"Seven Of Diamonds","HEAVAN: All players reach for the sky, last player to raise his hand drinks for 2 seconds!"},
            {"Eight Of Diamonds","PICK A MATE: Current player picks another player to drink everytime they drink for the rest of the game!"},
            {"Nine Of Diamonds","RHYME: Current player says a word, in clockwise rotation other players must name words that rhyme, first" +
                            "to make mistake must drink for two seconds!"},
            {"Ten Of Diamonds","CATEGORY: Current player picks a category, in a clockwise rotation other players will name things related" +
                            "to this category. First player to make a mistake will drink for 2 seconds!"},
            {"Jack Of Clubs","MAKE A RULE: Current player is allowed to make a rule that all other players must follow!"},
            {"Queen Of Clubs","QUESTION MASTER: Current player becomes the question master, any player that answers his/her question" +
                                "must drink for 2 seconds!"},
            {"King Of Clubs","CHALICE: Current player puts a bit of his/her drink in an empty glass, player with last king must drink from the glass!"},
            {"Jack Of Spades","MAKE A RULE: Current player is allowed to make a rule that all other players must follow!"},
            {"Queen Of Spades","QUESTION MASTER: Current player becomes the question master, any player that answers his/her question" +
                                "must drink for 2 seconds!"},
            {"King Of Spades","CHALICE: Current player puts a bit of his/her drink in an empty glass, player with last king must drink from the glass!"},
            {"Jack Of Hearts","MAKE A RULE: Current player is allowed to make a rule that all other players must follow!"},
            {"Queen Of Hearts","QUESTION MASTER: Current player becomes the question master, any player that answers his/her question" +
                                "must drink for 2 seconds!"},
            {"King Of Hearts","CHALICE: Current player puts a bit of his/her drink in an empty glass, player with last king must drink from the glass!"},
            {"Jack Of Diamonds","MAKE A RULE: Current player is allowed to make a rule that all other players must follow!"},
            {"Queen Of Diamonds","QUESTION MASTER: Current player becomes the question master, any player that answers his/her question" +
                                "must drink for 2 seconds!"},
            {"King Of Diamonds","CHALICE: Current player puts a bit of his/her drink in an empty glass, player with last king must drink from the glass!"}                                    
        };


        //Getters
        public List<string> GetOrignalDeck()
        {
            return _orignalDeckOfCards;
        }
        public int CardsLeft()
        {
            return _cardsLeft;
        }
        public double NumberOfDecks()
        {
            return _numberOfDecks;
        }
        public ComboBox ShowExcludedCards(ComboBox combo)
        {
            int i = 0;
            foreach (string x in _excludedCards)
            {
                combo.Items.Insert(i, x);
                i++;
            }
            return combo;
        }
        public ComboBox ShowRemainingCards(ComboBox combo)
        {
            int i = 0;
            foreach (string x in _deckOfCards)
            {
                combo.Items.Insert(i, x);
                i++;
            }
            return combo;
        }
        public int GetCardsUsedCount()
        {
            return _cardsUsed;
        }
        public List<string> GetUsedCards()
        {
            return _usedCards;
        }

        //Setters
        public void SetNumberOfDecks(double num)
        {
            _numberOfDecks = num;
        }
        public void SetCardsLeft(int num)
        {
            _cardsLeft = num;
        }
        public void SetExcludedCards(List<string> list)
        {
            _excludedCards = list;
        }
        
        //Methods
        public void NextCard()
        {
            _index = _random.Next(_deckOfCards.Count);
            if (_cardsLeft != 0)
            {
                string randomCard = _deckOfCards[_index];
                ReduceCardsLeft(_index);
                SetCardName(randomCard);
                SetCardRule(_cardRule[randomCard]);
                SetImagePath(randomCard);               
            }

        }
        public void JoinDecks(double num)
        {
            int i = 0, j = 0;
            _cardsLeft += Convert.ToInt16(num * 52);
            while (i < num)
            {
                _deckOfCards.AddRange(_orignalDeckOfCards);
                i++;
            }
            if (0.5 == (num - i))
            {
                while (j <= 25)
                {
                    _deckOfCards.InsertRange(j, _orignalDeckOfCards);
                    j++;
                }
            }
        }
        public void SetDecks(double num)
        {
            JoinDecks(num);
            _numberOfDecks = num;
            _orignalNumberOfDecks = num;
            
        }
        public void AddDeck(double num)
        {
            JoinDecks(num);
            _numberOfDecks = num + _numberOfDecks;
            int i = 0;
            while (i < _excludedCards.Count)
            {
                if (_deckOfCards.Contains(_excludedCards[i]))
                {
                    _deckOfCards.Remove(_excludedCards[i]);
                    _cardsLeft--;
                }
                if (_deckOfCards.Contains(_excludedCards[i]) == false)
                {
                    i++;
                }
            }
            MessageBox.Show(Resources.Deck_Added, num + Resources.Deck_Added_Description);
        }
        public void RemoveDeck(double num)
        {
            Boolean result = false;
            if (_numberOfDecks > num)
            {
                _numberOfDecks = _numberOfDecks - num;
                _cardsLeft = _cardsLeft - Convert.ToInt16(num*52);
                int i = 0, j = 0;
                while (i < num)
                {
                    while (j <= 51)
                    {
                        _deckOfCards.Remove(_orignalDeckOfCards[j]);
                        j++;
                    }
                    i++;
                }
                if ((num - i) == 0.5)
                {
                    j = 0;
                    while (j <= 25)
                    {
                        _deckOfCards.Remove(_orignalDeckOfCards[j]);
                        j++;
                    }
                }
                result = true;
            }
            if (result)
            {
                MessageBox.Show(Resources.Deck_Removed_Heading, num + Resources.Deck_Removed_Confirm);
            }
            else
            {
                MessageBox.Show(Resources.Error, Resources.Deck_Removed_Fail);
            }
        }       
        public void ReduceCardsLeft(int num)
        {
            _cardsLeft--;
            _usedCards.Add(_deckOfCards[num]);
            _deckOfCards.Remove(_deckOfCards[num]);
            UpdateCardsUsed(1);
        }
        public Boolean AddToExcludeCardList(string card)
        {
            Boolean fini = false;
            while (fini == false)
            {
                if (_deckOfCards.Contains(card))
                {
                    _deckOfCards.Remove(card);
                    _usedCards.Add(card);
                    _cardsLeft--;
                    UpdateCardsUsed(1);
                }
                if (_deckOfCards.Contains(card) == false)
                {
                    fini = true;
                    _excludedCards.Add(card);
                }
            }
            // ReSharper disable once ConditionIsAlwaysTrueOrFalse
            return fini;
        }
        public Boolean ResetGameDetails()
        {
            _cardsUsed = 0;
            _cardsLeft = Convert.ToInt16(_orignalNumberOfDecks * 52);
            _numberOfDecks = _orignalNumberOfDecks;
            _deckOfCards.Clear();
            _usedCards.Clear();
            _excludedCards.Clear();
            JoinDecks(_orignalNumberOfDecks);
            return true;
        }    
        public void UndoExclusionOfCard(Form form)
        {
            Boolean result = false;
            int i = 0;
            UndoCardExclusion uCard = new UndoCardExclusion();
            uCard.comboCard = ShowExcludedCards(uCard.comboCard);
            if (uCard.ShowDialog(form) == DialogResult.OK)
            {                
                if (uCard.comboCard.SelectedItem != null)
                {
                    string card = uCard.comboCard.SelectedItem.ToString();
                    while (i <= _usedCards.Count)
                    {
                        if (_usedCards.Contains(card))
                        {
                            _deckOfCards.Add(card);
                            _usedCards.Remove(card);
                            _cardsLeft++;
                            UpdateCardsUsed(-1);
                        }
                        i++;
                    }
                    if (!_usedCards.Contains(card))
                    {
                        _excludedCards.Remove(card);
                        result = true;
                    }
                    if (result)
                    {
                        MessageBox.Show(Resources.Undo_Exclusion_Header,
                            Resources.Card_Identifier + card + Resources.Undo_Exclusion_Confirm);
                    }
                    else
                    {
                        MessageBox.Show(Resources.Error,
                            Resources.Card_Identifier + card + Resources.Undo_Exclusion_Fail);
                    }
                }
            }
            else
            {
                uCard.Dispose();
            }
        }
        public void UpdateCardsUsed(int num)
        {
            _cardsUsed = _cardsUsed + num;
            if (_cardsUsed == 26)
            {
                _numberOfDecks = _numberOfDecks - 0.5;
                _cardsUsed = 0;
            }
        }

        public void ExcludeCard(Form form)
        {
            ExcludeCards eCard = new ExcludeCards();
            eCard.comboCard = ShowRemainingCards(eCard.comboCard);
            if (eCard.ShowDialog(form) == DialogResult.OK)
            {
                if (eCard.comboCard.SelectedItem != null)
                {
                    Boolean result = AddToExcludeCardList(eCard.comboCard.SelectedItem.ToString());
                    if (result)
                    {
                        MessageBox.Show(Resources.Card_Excluded_Header, Resources.Exclude_Card_Part1 + eCard.comboCard.SelectedItem + Resources.Exclude_Card_Part2);
                    }
                    else
                    {
                        MessageBox.Show(Resources.Error, Resources.Card_Identifier + eCard.comboCard.SelectedItem + Resources.Exclude_Card_Fail);
                    }
                }
            }
            else
            {
                eCard.Dispose();
            }
        }
        public void SetExcludedCards(DataGridView grid)
        {
            int i = 0;
            while (i < grid.RowCount - 1)
            {
                AddToExcludeCardList(grid.Rows[i].Cells[0].Value.ToString());
                i++;
            }
        }
    }
}
 