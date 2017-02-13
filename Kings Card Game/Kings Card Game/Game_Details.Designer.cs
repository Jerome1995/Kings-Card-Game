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
            this.excludeCardsButton = new System.Windows.Forms.Button();
            this.setDecksButton = new System.Windows.Forms.Button();
            this.addPlayerButton = new System.Windows.Forms.Button();
            this.grdPlayer = new System.Windows.Forms.DataGridView();
            this.grdExcludedCards = new System.Windows.Forms.DataGridView();
            this.grdDecks = new System.Windows.Forms.DataGridView();
            this.startGameButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuKings = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.welcomeScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.grdPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdExcludedCards)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDecks)).BeginInit();
            this.menuKings.SuspendLayout();
            this.SuspendLayout();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 15.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(317, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Kings Card Game";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(273, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(338, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Please enter your details here\r\n";
            // 
            // menuKings
            // 
            this.menuKings.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuKings.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem});
            this.menuKings.Location = new System.Drawing.Point(0, 0);
            this.menuKings.Name = "menuKings";
            this.menuKings.Size = new System.Drawing.Size(884, 24);
            this.menuKings.TabIndex = 28;
            this.menuKings.Text = "menuKings";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.welcomeScreenToolStripMenuItem,
            this.gameDetailsToolStripMenuItem});
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // welcomeScreenToolStripMenuItem
            // 
            this.welcomeScreenToolStripMenuItem.Name = "welcomeScreenToolStripMenuItem";
            this.welcomeScreenToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.welcomeScreenToolStripMenuItem.Text = "Welcome Screen";
            // 
            // gameDetailsToolStripMenuItem
            // 
            this.gameDetailsToolStripMenuItem.Name = "gameDetailsToolStripMenuItem";
            this.gameDetailsToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.gameDetailsToolStripMenuItem.Text = "Game Details";
            // 
            // Game_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.menuKings);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startGameButton);
            this.Controls.Add(this.grdDecks);
            this.Controls.Add(this.grdExcludedCards);
            this.Controls.Add(this.grdPlayer);
            this.Controls.Add(this.addPlayerButton);
            this.Controls.Add(this.setDecksButton);
            this.Controls.Add(this.excludeCardsButton);
            this.Name = "Game_Details";
            this.Text = "Kings";
            ((System.ComponentModel.ISupportInitialize)(this.grdPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdExcludedCards)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDecks)).EndInit();
            this.menuKings.ResumeLayout(false);
            this.menuKings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button excludeCardsButton;
        private System.Windows.Forms.Button setDecksButton;
        private System.Windows.Forms.Button addPlayerButton;
        private System.Windows.Forms.DataGridView grdPlayer;
        private System.Windows.Forms.DataGridView grdExcludedCards;
        private System.Windows.Forms.DataGridView grdDecks;
        private System.Windows.Forms.Button startGameButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuKings;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem welcomeScreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameDetailsToolStripMenuItem;
    }
}