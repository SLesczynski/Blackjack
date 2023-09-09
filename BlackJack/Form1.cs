using BlackJack;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blackjack
{
    public partial class Form1 : Form
    {
        int currentMoney = 100;
        int bet = 10;
        int wins = 0;
        int loses = 0;

        Hand playerHand = new Hand();
        Hand dealerHand = new Hand();
        Card dealerHiddenCard;

        Stack<Card> cards = new Stack<Card>();
        public void CreateDeck()
        {
            //Creates 4 decks of cards.
            for (int numberOfDecks = 0; numberOfDecks <= 4; numberOfDecks++)
            {
                for (int i = 2; i <= 14; i++)
                {
                    cards.Push(new Card("H", i));
                    cards.Push(new Card("D", i));
                    cards.Push(new Card("S", i));
                    cards.Push(new Card("C", i));
                }
            }

            //Shuffles the deck 10 times.
            for(int i = 0; i < 10; i++)
            {
                ShuffleDeck();
            }
        }

        public void ShuffleDeck()
        {
            List<Card> tempList = cards.ToList();
            Random rng = new Random();
            int n = cards.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Card value = tempList[k];
                tempList[k] = tempList[n];
                tempList[n] = value;
            }
            cards = new Stack<Card>(tempList);
        }
        public void StartGame()
        {
            currentMoneyTextBox.Text = currentMoney.ToString();
            CreateDeck();
            playerCards.Text = "";
            dealerCards.Text = "";
            BetInputBox.Text = "1";

            recordInfoLabel.Text = wins.ToString() + " - " + loses.ToString();

            bet = Int32.Parse(BetInputBox.Text);
            dealerHand = new Hand();
            playerHand = new Hand();

            playerHand.AddCard(GetNextCard());
            playerHandCount.Text = playerHand.GetLightCount().ToString();

            dealerHand.AddCard(GetNextCard());
            dealerHandCount.Text = dealerHand.GetLightCount().ToString();

            playerHand.AddCard(GetNextCard());
            playerHandCount.Text = playerHand.GetLightCount().ToString();

            playerCards.Text = playerHand.GetCardsInHand();
            dealerCards.Text = dealerHand.GetCardsInHand();

            dealerHiddenCard = GetNextCard();

            if (dealerHand.GetHeavyCount() + dealerHiddenCard.GetValue() == 21)
            {
                dealerHand.AddCard(dealerHiddenCard);
                dealerHandCount.Text = dealerHand.GetLightCount().ToString();
            }
        }

        public Card GetNextCard()
        {
            Card temp = cards.Pop();
            return temp;
        }

        public void Hit()
        {
            playerHand.AddCard(GetNextCard());
            if (playerHand.GetLightCount() > 21)
            {
                LostGame();
                StartGame();
            }

            if(playerHand.GetLightCount() == 21)
            {
                Stand();
            }

            playerHandCount.Text = playerHand.GetLightCount().ToString();
            playerCards.Text = playerHand.GetCardsInHand();
        }

        public void Stand()
        {
            dealerHand.AddCard(dealerHiddenCard);
            while(dealerHand.GetLightCount() < 17)
            {
                dealerHand.AddCard(GetNextCard());
            }

            if(dealerHand.GetLightCount() > 21)
            {
                WonGame();
            } else if(dealerHand.GetLightCount() > playerHand.GetLightCount())
            {
                LostGame();
            } else
            {
                WonGame();
            }
            StartGame();
        }

        public void WonGame()
        {
            wins++;
            currentMoney += (int)(bet * 1.5);
            EndGame();
        }

        public void LostGame()
        {
            loses++;
            currentMoney -= bet;
            EndGame();
        }

        public void EndGame()
        {
            PastGames.Text = PastGames.Text + "----Game----\nDealer Hand: " + dealerHand.GetLightCount() + "\nPlayer Hand: " + playerHand.GetLightCount() + "\n";
        }
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void StartGameButton_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void HitButton_Click(object sender, EventArgs e)
        {
            Hit();
        }

        private void StandButton_Click(object sender, EventArgs e)
        {
            Stand();
        }

        private void QuitGameButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
