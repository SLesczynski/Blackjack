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

        Random rnd = new Random();

        int dealerCount = 0;
        int dealerHiddenCard = 0;
        int playerCount = 0;

        Stack<Card> cards = new Stack<Card>();
        public void createDeck()
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
                shuffleDeck();
            }
        }

        public void shuffleDeck()
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
        public void startGame()
        {
            Console.WriteLine("--------New Game-------");
            currentMoneyTextBox.Text = currentMoney.ToString();
            createDeck();
            playerCards.Text = "";
            dealerCards.Text = "";

            recordInfoLabel.Text = wins.ToString() + " - " + loses.ToString();

            dealerCount = 0;
            playerCount = 0;

            playerCount+= addCard(playerCards);
            playerHandCount.Text = playerCount.ToString();

            dealerCount+= addCard(dealerCards);
            dealerHandCount.Text = dealerCount.ToString();
            Console.WriteLine(dealerCount);

            playerCount += addCard(playerCards);
            playerHandCount.Text = playerCount.ToString();

            dealerHiddenCard += addCard(dealerCards);

            if (dealerCount + dealerHiddenCard == 21)
            {
                dealerCount += dealerHiddenCard;
                dealerHandCount.Text = playerCount.ToString();
            }
        }

        public int addCard(Label hand)
        {
            Card temp = cards.Pop();
            int cardValue = temp.getValue();
            int cardNumber = temp.getNumber();
            hand.Text = hand.Text + "{" + temp.getSuit() + "," + cardNumber.ToString() + ","+ cardValue.ToString() + "}";
            return temp.getValue();
        }

        public void hit()
        {
            playerCount += addCard(playerCards);
            if (playerCount > 21)
            {
                lostGame();
                startGame();
            }

            if(playerCount == 21)
            {
                stand();
            }

            playerHandCount.Text = playerCount.ToString();
        }

        public void stand()
        {
            dealerCount += dealerHiddenCard;
            while(dealerCount < 17)
            {
                dealerCount += addCard(dealerCards);
                Console.WriteLine(dealerCount.ToString());
            }

            if(dealerCount > 21)
            {
                wonGame();
            } else if(dealerCount > playerCount)
            {
                lostGame();
            } else
            {
                wonGame();
            }
            startGame();
        }

        public void wonGame()
        {
            wins++;
            currentMoney += (int)(bet * 1.5);
        }

        public void lostGame()
        {
            loses++;
            currentMoney -= bet;
        }
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void startGameButton_Click(object sender, EventArgs e)
        {
            startGame();
        }

        private void hitButton_Click(object sender, EventArgs e)
        {
            hit();
        }

        private void standButton_Click(object sender, EventArgs e)
        {
            stand();
        }

        private void quitGameButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
