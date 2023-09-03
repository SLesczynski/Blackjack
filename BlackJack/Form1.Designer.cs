namespace Blackjack
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.hitButton = new System.Windows.Forms.Button();
            this.playerCardCountTextBox = new System.Windows.Forms.TextBox();
            this.startGameButton = new System.Windows.Forms.Button();
            this.dealerCardCountTextBox = new System.Windows.Forms.TextBox();
            this.quitGameButton = new System.Windows.Forms.Button();
            this.standButton = new System.Windows.Forms.Button();
            this.playerHandCountLabel = new System.Windows.Forms.Label();
            this.dealerHandCountLabel = new System.Windows.Forms.Label();
            this.recordLabel = new System.Windows.Forms.Label();
            this.recordInfoLabel = new System.Windows.Forms.Label();
            this.playerCards = new System.Windows.Forms.Label();
            this.dealerCards = new System.Windows.Forms.Label();
            this.currentMoneyTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hitButton
            // 
            this.hitButton.Location = new System.Drawing.Point(202, 382);
            this.hitButton.Name = "hitButton";
            this.hitButton.Size = new System.Drawing.Size(115, 56);
            this.hitButton.TabIndex = 0;
            this.hitButton.Text = "Hit";
            this.hitButton.UseVisualStyleBackColor = true;
            this.hitButton.Click += new System.EventHandler(this.hitButton_Click);
            // 
            // playerCardCountTextBox
            // 
            this.playerCardCountTextBox.Location = new System.Drawing.Point(323, 332);
            this.playerCardCountTextBox.Name = "playerCardCountTextBox";
            this.playerCardCountTextBox.Size = new System.Drawing.Size(115, 20);
            this.playerCardCountTextBox.TabIndex = 1;
            // 
            // startGameButton
            // 
            this.startGameButton.Location = new System.Drawing.Point(12, 382);
            this.startGameButton.Name = "startGameButton";
            this.startGameButton.Size = new System.Drawing.Size(115, 56);
            this.startGameButton.TabIndex = 2;
            this.startGameButton.Text = "Start Game";
            this.startGameButton.UseVisualStyleBackColor = true;
            this.startGameButton.Click += new System.EventHandler(this.startGameButton_Click);
            // 
            // dealerCardCountTextBox
            // 
            this.dealerCardCountTextBox.Location = new System.Drawing.Point(323, 33);
            this.dealerCardCountTextBox.Name = "dealerCardCountTextBox";
            this.dealerCardCountTextBox.Size = new System.Drawing.Size(115, 20);
            this.dealerCardCountTextBox.TabIndex = 3;
            // 
            // quitGameButton
            // 
            this.quitGameButton.Location = new System.Drawing.Point(673, 382);
            this.quitGameButton.Name = "quitGameButton";
            this.quitGameButton.Size = new System.Drawing.Size(115, 56);
            this.quitGameButton.TabIndex = 4;
            this.quitGameButton.Text = "Quit Game";
            this.quitGameButton.UseVisualStyleBackColor = true;
            this.quitGameButton.Click += new System.EventHandler(this.quitGameButton_Click);
            // 
            // standButton
            // 
            this.standButton.Location = new System.Drawing.Point(444, 382);
            this.standButton.Name = "standButton";
            this.standButton.Size = new System.Drawing.Size(115, 56);
            this.standButton.TabIndex = 5;
            this.standButton.Text = "Stand";
            this.standButton.UseVisualStyleBackColor = true;
            this.standButton.Click += new System.EventHandler(this.standButton_Click);
            // 
            // playerHandCountLabel
            // 
            this.playerHandCountLabel.AutoSize = true;
            this.playerHandCountLabel.Location = new System.Drawing.Point(331, 316);
            this.playerHandCountLabel.Name = "playerHandCountLabel";
            this.playerHandCountLabel.Size = new System.Drawing.Size(96, 13);
            this.playerHandCountLabel.TabIndex = 6;
            this.playerHandCountLabel.Text = "Player Hand Count";
            this.playerHandCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dealerHandCountLabel
            // 
            this.dealerHandCountLabel.AutoSize = true;
            this.dealerHandCountLabel.Location = new System.Drawing.Point(331, 56);
            this.dealerHandCountLabel.Name = "dealerHandCountLabel";
            this.dealerHandCountLabel.Size = new System.Drawing.Size(98, 13);
            this.dealerHandCountLabel.TabIndex = 7;
            this.dealerHandCountLabel.Text = "Dealer Hand Count";
            this.dealerHandCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // recordLabel
            // 
            this.recordLabel.AutoSize = true;
            this.recordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.recordLabel.Location = new System.Drawing.Point(12, 33);
            this.recordLabel.Name = "recordLabel";
            this.recordLabel.Size = new System.Drawing.Size(94, 29);
            this.recordLabel.TabIndex = 8;
            this.recordLabel.Text = "Record";
            // 
            // recordInfoLabel
            // 
            this.recordInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.recordInfoLabel.Location = new System.Drawing.Point(13, 62);
            this.recordInfoLabel.Name = "recordInfoLabel";
            this.recordInfoLabel.Size = new System.Drawing.Size(94, 29);
            this.recordInfoLabel.TabIndex = 9;
            this.recordInfoLabel.Text = "0 - 0";
            this.recordInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playerCards
            // 
            this.playerCards.Location = new System.Drawing.Point(130, 296);
            this.playerCards.Name = "playerCards";
            this.playerCards.Size = new System.Drawing.Size(500, 20);
            this.playerCards.TabIndex = 10;
            this.playerCards.Text = "Player Cards";
            this.playerCards.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dealerCards
            // 
            this.dealerCards.Location = new System.Drawing.Point(130, 71);
            this.dealerCards.Name = "dealerCards";
            this.dealerCards.Size = new System.Drawing.Size(500, 20);
            this.dealerCards.TabIndex = 11;
            this.dealerCards.Text = "Dealer Cards";
            this.dealerCards.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currentMoneyTextBox
            // 
            this.currentMoneyTextBox.Location = new System.Drawing.Point(17, 10);
            this.currentMoneyTextBox.Name = "currentMoneyTextBox";
            this.currentMoneyTextBox.Size = new System.Drawing.Size(115, 20);
            this.currentMoneyTextBox.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 346);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Bet";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.currentMoneyTextBox);
            this.Controls.Add(this.dealerCards);
            this.Controls.Add(this.playerCards);
            this.Controls.Add(this.recordInfoLabel);
            this.Controls.Add(this.recordLabel);
            this.Controls.Add(this.dealerHandCountLabel);
            this.Controls.Add(this.playerHandCountLabel);
            this.Controls.Add(this.standButton);
            this.Controls.Add(this.quitGameButton);
            this.Controls.Add(this.dealerCardCountTextBox);
            this.Controls.Add(this.startGameButton);
            this.Controls.Add(this.playerCardCountTextBox);
            this.Controls.Add(this.hitButton);
            this.Name = "Form1";
            this.Text = "BlackJack";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hitButton;
        private System.Windows.Forms.TextBox playerCardCountTextBox;
        private System.Windows.Forms.Button startGameButton;
        private System.Windows.Forms.TextBox dealerCardCountTextBox;
        private System.Windows.Forms.Button quitGameButton;
        private System.Windows.Forms.Button standButton;
        private System.Windows.Forms.Label playerHandCountLabel;
        private System.Windows.Forms.Label dealerHandCountLabel;
        private System.Windows.Forms.Label recordLabel;
        private System.Windows.Forms.Label recordInfoLabel;
        private System.Windows.Forms.Label playerCards;
        private System.Windows.Forms.Label dealerCards;
        private System.Windows.Forms.TextBox currentMoneyTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}

