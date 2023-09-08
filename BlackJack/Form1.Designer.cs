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
            this.startGameButton = new System.Windows.Forms.Button();
            this.quitGameButton = new System.Windows.Forms.Button();
            this.standButton = new System.Windows.Forms.Button();
            this.playerHandCountLabel = new System.Windows.Forms.Label();
            this.dealerHandCountLabel = new System.Windows.Forms.Label();
            this.recordLabel = new System.Windows.Forms.Label();
            this.recordInfoLabel = new System.Windows.Forms.Label();
            this.playerCards = new System.Windows.Forms.Label();
            this.dealerCards = new System.Windows.Forms.Label();
            this.currentMoneyTextBox = new System.Windows.Forms.TextBox();
            this.BetInputBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.playerHandCount = new System.Windows.Forms.Label();
            this.dealerHandCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hitButton
            // 
            this.hitButton.Location = new System.Drawing.Point(269, 470);
            this.hitButton.Margin = new System.Windows.Forms.Padding(4);
            this.hitButton.Name = "hitButton";
            this.hitButton.Size = new System.Drawing.Size(153, 69);
            this.hitButton.TabIndex = 0;
            this.hitButton.Text = "Hit";
            this.hitButton.UseVisualStyleBackColor = true;
            this.hitButton.Click += new System.EventHandler(this.HitButton_Click);
            // 
            // startGameButton
            // 
            this.startGameButton.Location = new System.Drawing.Point(16, 470);
            this.startGameButton.Margin = new System.Windows.Forms.Padding(4);
            this.startGameButton.Name = "startGameButton";
            this.startGameButton.Size = new System.Drawing.Size(153, 69);
            this.startGameButton.TabIndex = 2;
            this.startGameButton.Text = "Start Game";
            this.startGameButton.UseVisualStyleBackColor = true;
            this.startGameButton.Click += new System.EventHandler(this.StartGameButton_Click);
            // 
            // quitGameButton
            // 
            this.quitGameButton.Location = new System.Drawing.Point(897, 470);
            this.quitGameButton.Margin = new System.Windows.Forms.Padding(4);
            this.quitGameButton.Name = "quitGameButton";
            this.quitGameButton.Size = new System.Drawing.Size(153, 69);
            this.quitGameButton.TabIndex = 4;
            this.quitGameButton.Text = "Quit Game";
            this.quitGameButton.UseVisualStyleBackColor = true;
            this.quitGameButton.Click += new System.EventHandler(this.QuitGameButton_Click);
            // 
            // standButton
            // 
            this.standButton.Location = new System.Drawing.Point(592, 470);
            this.standButton.Margin = new System.Windows.Forms.Padding(4);
            this.standButton.Name = "standButton";
            this.standButton.Size = new System.Drawing.Size(153, 69);
            this.standButton.TabIndex = 5;
            this.standButton.Text = "Stand";
            this.standButton.UseVisualStyleBackColor = true;
            this.standButton.Click += new System.EventHandler(this.StandButton_Click);
            // 
            // playerHandCountLabel
            // 
            this.playerHandCountLabel.AutoSize = true;
            this.playerHandCountLabel.Location = new System.Drawing.Point(441, 389);
            this.playerHandCountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.playerHandCountLabel.Name = "playerHandCountLabel";
            this.playerHandCountLabel.Size = new System.Drawing.Size(119, 16);
            this.playerHandCountLabel.TabIndex = 6;
            this.playerHandCountLabel.Text = "Player Hand Count";
            this.playerHandCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dealerHandCountLabel
            // 
            this.dealerHandCountLabel.AutoSize = true;
            this.dealerHandCountLabel.Location = new System.Drawing.Point(441, 69);
            this.dealerHandCountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dealerHandCountLabel.Name = "dealerHandCountLabel";
            this.dealerHandCountLabel.Size = new System.Drawing.Size(121, 16);
            this.dealerHandCountLabel.TabIndex = 7;
            this.dealerHandCountLabel.Text = "Dealer Hand Count";
            this.dealerHandCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // recordLabel
            // 
            this.recordLabel.AutoSize = true;
            this.recordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.recordLabel.Location = new System.Drawing.Point(16, 41);
            this.recordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.recordLabel.Name = "recordLabel";
            this.recordLabel.Size = new System.Drawing.Size(114, 35);
            this.recordLabel.TabIndex = 8;
            this.recordLabel.Text = "Record";
            // 
            // recordInfoLabel
            // 
            this.recordInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.recordInfoLabel.Location = new System.Drawing.Point(17, 76);
            this.recordInfoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.recordInfoLabel.Name = "recordInfoLabel";
            this.recordInfoLabel.Size = new System.Drawing.Size(125, 36);
            this.recordInfoLabel.TabIndex = 9;
            this.recordInfoLabel.Text = "0 - 0";
            this.recordInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playerCards
            // 
            this.playerCards.Location = new System.Drawing.Point(173, 364);
            this.playerCards.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.playerCards.Name = "playerCards";
            this.playerCards.Size = new System.Drawing.Size(667, 25);
            this.playerCards.TabIndex = 10;
            this.playerCards.Text = "Player Cards";
            this.playerCards.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dealerCards
            // 
            this.dealerCards.Location = new System.Drawing.Point(173, 87);
            this.dealerCards.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dealerCards.Name = "dealerCards";
            this.dealerCards.Size = new System.Drawing.Size(667, 25);
            this.dealerCards.TabIndex = 11;
            this.dealerCards.Text = "Dealer Cards";
            this.dealerCards.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currentMoneyTextBox
            // 
            this.currentMoneyTextBox.Location = new System.Drawing.Point(23, 12);
            this.currentMoneyTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.currentMoneyTextBox.Name = "currentMoneyTextBox";
            this.currentMoneyTextBox.Size = new System.Drawing.Size(152, 22);
            this.currentMoneyTextBox.TabIndex = 12;
            // 
            // BetInputBox
            // 
            this.BetInputBox.Location = new System.Drawing.Point(16, 426);
            this.BetInputBox.Margin = new System.Windows.Forms.Padding(4);
            this.BetInputBox.Name = "BetInputBox";
            this.BetInputBox.Size = new System.Drawing.Size(132, 22);
            this.BetInputBox.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 389);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Bet";
            // 
            // playerHandCount
            // 
            this.playerHandCount.BackColor = System.Drawing.Color.WhiteSmoke;
            this.playerHandCount.Location = new System.Drawing.Point(431, 409);
            this.playerHandCount.Name = "playerHandCount";
            this.playerHandCount.Size = new System.Drawing.Size(152, 22);
            this.playerHandCount.TabIndex = 15;
            this.playerHandCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dealerHandCount
            // 
            this.dealerHandCount.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dealerHandCount.Location = new System.Drawing.Point(431, 41);
            this.dealerHandCount.Name = "dealerHandCount";
            this.dealerHandCount.Size = new System.Drawing.Size(152, 22);
            this.dealerHandCount.TabIndex = 16;
            this.dealerHandCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dealerHandCount);
            this.Controls.Add(this.playerHandCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BetInputBox);
            this.Controls.Add(this.currentMoneyTextBox);
            this.Controls.Add(this.dealerCards);
            this.Controls.Add(this.playerCards);
            this.Controls.Add(this.recordInfoLabel);
            this.Controls.Add(this.recordLabel);
            this.Controls.Add(this.dealerHandCountLabel);
            this.Controls.Add(this.playerHandCountLabel);
            this.Controls.Add(this.standButton);
            this.Controls.Add(this.quitGameButton);
            this.Controls.Add(this.startGameButton);
            this.Controls.Add(this.hitButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "BlackJack";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hitButton;
        private System.Windows.Forms.Button startGameButton;
        private System.Windows.Forms.Button quitGameButton;
        private System.Windows.Forms.Button standButton;
        private System.Windows.Forms.Label playerHandCountLabel;
        private System.Windows.Forms.Label dealerHandCountLabel;
        private System.Windows.Forms.Label recordLabel;
        private System.Windows.Forms.Label recordInfoLabel;
        private System.Windows.Forms.Label playerCards;
        private System.Windows.Forms.Label dealerCards;
        private System.Windows.Forms.TextBox currentMoneyTextBox;
        private System.Windows.Forms.TextBox BetInputBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label playerHandCount;
        private System.Windows.Forms.Label dealerHandCount;
    }
}

