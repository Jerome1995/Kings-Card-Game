namespace Kings_Card_Game
{
    partial class Game_Details
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
            this.Heading = new System.Windows.Forms.TextBox();
            this.excludeCardsButton = new System.Windows.Forms.Button();
            this.setDecksButton = new System.Windows.Forms.Button();
            this.addPlayerButton = new System.Windows.Forms.Button();
            this.enterDetails = new System.Windows.Forms.TextBox();
            this.grdPlayer = new System.Windows.Forms.DataGridView();
            this.grdExcludedCards = new System.Windows.Forms.DataGridView();
            this.grdDecks = new System.Windows.Forms.DataGridView();
            this.startGameButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdExcludedCards)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDecks)).BeginInit();
            this.SuspendLayout();
            // 
            // Heading
            // 
            this.Heading.BackColor = System.Drawing.Color.Silver;
            this.Heading.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Heading.Font = new System.Drawing.Font("Century", 15.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Heading.Location = new System.Drawing.Point(317, 64);
            this.Heading.Multiline = true;
            this.Heading.Name = "Heading";
            this.Heading.Size = new System.Drawing.Size(265, 40);
            this.Heading.TabIndex = 2;
            this.Heading.Text = "Kings Card Game";
            // 
            // excludeCardsButton
            // 
            this.excludeCardsButton.Font = new System.Drawing.Font("Century", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excludeCardsButton.Location = new System.Drawing.Point(640, 144);
            this.excludeCardsButton.Name = "excludeCardsButton";
            this.excludeCardsButton.Size = new System.Drawing.Size(160, 45);
            this.excludeCardsButton.TabIndex = 9;
            this.excludeCardsButton.Text = "Exclude Cards";
            this.excludeCardsButton.UseVisualStyleBackColor = true;
            // 
            // setDecksButton
            // 
            this.setDecksButton.Font = new System.Drawing.Font("Century", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setDecksButton.Location = new System.Drawing.Point(370, 144);
            this.setDecksButton.Name = "setDecksButton";
            this.setDecksButton.Size = new System.Drawing.Size(160, 45);
            this.setDecksButton.TabIndex = 10;
            this.setDecksButton.Text = "Set Decks";
            this.setDecksButton.UseVisualStyleBackColor = true;
            // 
            // addPlayerButton
            // 
            this.addPlayerButton.Font = new System.Drawing.Font("Century", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPlayerButton.Location = new System.Drawing.Point(100, 144);
            this.addPlayerButton.Name = "addPlayerButton";
            this.addPlayerButton.Size = new System.Drawing.Size(160, 45);
            this.addPlayerButton.TabIndex = 11;
            this.addPlayerButton.Text = "Add Player";
            this.addPlayerButton.UseVisualStyleBackColor = true;
            // 
            // enterDetails
            // 
            this.enterDetails.BackColor = System.Drawing.Color.Silver;
            this.enterDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.enterDetails.Font = new System.Drawing.Font("Century", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterDetails.Location = new System.Drawing.Point(273, 98);
            this.enterDetails.Multiline = true;
            this.enterDetails.Name = "enterDetails";
            this.enterDetails.Size = new System.Drawing.Size(353, 32);
            this.enterDetails.TabIndex = 12;
            this.enterDetails.Text = "Please enter your details here";
            // 
            // grdPlayer
            // 
            this.grdPlayer.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.grdPlayer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPlayer.Location = new System.Drawing.Point(100, 220);
            this.grdPlayer.Name = "grdPlayer";
            this.grdPlayer.Size = new System.Drawing.Size(159, 209);
            this.grdPlayer.TabIndex = 13;
            // 
            // grdExcludedCards
            // 
            this.grdExcludedCards.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.grdExcludedCards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdExcludedCards.Location = new System.Drawing.Point(641, 220);
            this.grdExcludedCards.Name = "grdExcludedCards";
            this.grdExcludedCards.Size = new System.Drawing.Size(159, 209);
            this.grdExcludedCards.TabIndex = 14;
            // 
            // grdDecks
            // 
            this.grdDecks.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.grdDecks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDecks.Location = new System.Drawing.Point(420, 220);
            this.grdDecks.Name = "grdDecks";
            this.grdDecks.Size = new System.Drawing.Size(55, 40);
            this.grdDecks.TabIndex = 15;
            // 
            // startGameButton
            // 
            this.startGameButton.Font = new System.Drawing.Font("Century", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startGameButton.Location = new System.Drawing.Point(370, 437);
            this.startGameButton.Name = "startGameButton";
            this.startGameButton.Size = new System.Drawing.Size(160, 45);
            this.startGameButton.TabIndex = 16;
            this.startGameButton.Text = "Start Game";
            this.startGameButton.UseVisualStyleBackColor = true;
            // 
            // Game_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.startGameButton);
            this.Controls.Add(this.grdDecks);
            this.Controls.Add(this.grdExcludedCards);
            this.Controls.Add(this.grdPlayer);
            this.Controls.Add(this.enterDetails);
            this.Controls.Add(this.addPlayerButton);
            this.Controls.Add(this.setDecksButton);
            this.Controls.Add(this.excludeCardsButton);
            this.Controls.Add(this.Heading);
            this.Name = "Game_Details";
            this.Text = "Game_Details";
            ((System.ComponentModel.ISupportInitialize)(this.grdPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdExcludedCards)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDecks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Heading;
        private System.Windows.Forms.Button excludeCardsButton;
        private System.Windows.Forms.Button setDecksButton;
        private System.Windows.Forms.Button addPlayerButton;
        private System.Windows.Forms.TextBox enterDetails;
        private System.Windows.Forms.DataGridView grdPlayer;
        private System.Windows.Forms.DataGridView grdExcludedCards;
        private System.Windows.Forms.DataGridView grdDecks;
        private System.Windows.Forms.Button startGameButton;
    }
}