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

namespace BlackJack
{
    public partial class Form1 : Form
    {
        int wins = 0;
        int loses = 0;

        Random rnd = new Random();

        int dealerCount = 0;
        int dealerHiddenCard = 0;
        int playerCount = 0;

        Stack<card> cards = new Stack<card>();
        public void createDeck()
        {
            //Creates 4 decks of cards.
            for (int numberOfDecks = 0; numberOfDecks <= 4; numberOfDecks++)
            {
                for (int i = 2; i <= 13; i++)
                {
                    cards.Push(new card("H", i));
                    cards.Push(new card("D", i));
                    cards.Push(new card("S", i));
                    cards.Push(new card("C", i));
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

        }
        public void startGame()
        {
            createDeck();
            playerCards.Text = "";
            dealerCards.Text = "";

            recordInfoLabel.Text = wins.ToString() + " - " + loses.ToString();

            dealerCount = 0;
            playerCount = 0;
            playerCount+= addCard(playerCards);
            playerCardCountTextBox.Text = playerCount.ToString();

            dealerCount+= addCard(dealerCards);
            dealerCardCountTextBox.Text = playerCount.ToString();

            playerCount += addCard(playerCards);
            playerCardCountTextBox.Text = playerCount.ToString();

            dealerHiddenCard += addCard(dealerCards);

            if (dealerCount + dealerHiddenCard == 21)
            {
                dealerCount += dealerHiddenCard;
                dealerCardCountTextBox.Text = playerCount.ToString();
            }
        }

        public int addCard(Label hand)
        {
            card temp = cards.Pop();
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
                loses++;
                startGame();
            }

            playerCardCountTextBox.Text = playerCount.ToString();
        }

        public void stand()
        {
            dealerCount += dealerHiddenCard;
            while(dealerCount < 17)
            {
                dealerCount += addCard(dealerCards);
            }

            if(dealerCount > 21)
            {
                wins++;
            } else if(dealerCount > playerCount)
            {
                loses++;
            } else
            {
                wins++;
            }
            startGame();
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
