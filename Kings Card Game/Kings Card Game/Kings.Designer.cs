﻿using System.ComponentModel;
using System.Windows.Forms;

namespace Kings_Card_Game
{
    partial class Kings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.cardBox = new System.Windows.Forms.PictureBox();
            this.txtCardName = new System.Windows.Forms.RichTextBox();
            this.txtCardRule = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbCardRule = new System.Windows.Forms.Label();
            this.lcCardName = new System.Windows.Forms.Label();
            this.nextCardButton = new System.Windows.Forms.Button();
            this.txtCardsLeft = new System.Windows.Forms.RichTextBox();
            this.txtDecksLeft = new System.Windows.Forms.RichTextBox();
            this.lbDecksLeft = new System.Windows.Forms.Label();
            this.lbCardsLeft = new System.Windows.Forms.Label();
            this.menuKings = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.welcomeScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPlayerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.removePlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePlayerNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDeckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.halfDeckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oneDeckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.twoDeckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excludeCardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chooseCardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoExclusionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbPlayerName = new System.Windows.Forms.Label();
            this.txtPlayerName = new System.Windows.Forms.RichTextBox();
            this.lbPlayerAmount = new System.Windows.Forms.Label();
            this.txtPlayerAmount = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.cardBox)).BeginInit();
            this.menuKings.SuspendLayout();
            this.SuspendLayout();
            // 
            // cardBox
            // 
            this.cardBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cardBox.Location = new System.Drawing.Point(317, 97);
            this.cardBox.Name = "cardBox";
            this.cardBox.Size = new System.Drawing.Size(201, 248);
            this.cardBox.TabIndex = 4;
            this.cardBox.TabStop = false;
            // 
            // txtCardName
            // 
            this.txtCardName.Location = new System.Drawing.Point(317, 373);
            this.txtCardName.Name = "txtCardName";
            this.txtCardName.ReadOnly = true;
            this.txtCardName.Size = new System.Drawing.Size(265, 20);
            this.txtCardName.TabIndex = 5;
            this.txtCardName.Text = "";
            // 
            // txtCardRule
            // 
            this.txtCardRule.Location = new System.Drawing.Point(317, 425);
            this.txtCardRule.Name = "txtCardRule";
            this.txtCardRule.ReadOnly = true;
            this.txtCardRule.Size = new System.Drawing.Size(407, 54);
            this.txtCardRule.TabIndex = 6;
            this.txtCardRule.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 15.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(317, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Kings Card Game";
            // 
            // lbCardRule
            // 
            this.lbCardRule.AutoSize = true;
            this.lbCardRule.Font = new System.Drawing.Font("Century", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCardRule.Location = new System.Drawing.Point(212, 459);
            this.lbCardRule.Name = "lbCardRule";
            this.lbCardRule.Size = new System.Drawing.Size(99, 20);
            this.lbCardRule.TabIndex = 19;
            this.lbCardRule.Text = "Card Rule:";
            // 
            // lcCardName
            // 
            this.lcCardName.AutoSize = true;
            this.lcCardName.Font = new System.Drawing.Font("Century", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcCardName.Location = new System.Drawing.Point(203, 373);
            this.lcCardName.Name = "lcCardName";
            this.lcCardName.Size = new System.Drawing.Size(108, 20);
            this.lcCardName.TabIndex = 20;
            this.lcCardName.Text = "Card Name:";
            // 
            // nextCardButton
            // 
            this.nextCardButton.Font = new System.Drawing.Font("Century", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextCardButton.Location = new System.Drawing.Point(677, 267);
            this.nextCardButton.Name = "nextCardButton";
            this.nextCardButton.Size = new System.Drawing.Size(160, 45);
            this.nextCardButton.TabIndex = 21;
            this.nextCardButton.Text = "Next Card";
            this.nextCardButton.UseVisualStyleBackColor = true;
            this.nextCardButton.Click += new System.EventHandler(this.nextCardButton_Click);
            // 
            // txtCardsLeft
            // 
            this.txtCardsLeft.Location = new System.Drawing.Point(238, 182);
            this.txtCardsLeft.Name = "txtCardsLeft";
            this.txtCardsLeft.ReadOnly = true;
            this.txtCardsLeft.Size = new System.Drawing.Size(39, 20);
            this.txtCardsLeft.TabIndex = 23;
            this.txtCardsLeft.Text = "";
            // 
            // txtDecksLeft
            // 
            this.txtDecksLeft.Location = new System.Drawing.Point(238, 222);
            this.txtDecksLeft.Name = "txtDecksLeft";
            this.txtDecksLeft.ReadOnly = true;
            this.txtDecksLeft.Size = new System.Drawing.Size(39, 23);
            this.txtDecksLeft.TabIndex = 24;
            this.txtDecksLeft.Text = "";
            // 
            // lbDecksLeft
            // 
            this.lbDecksLeft.AutoSize = true;
            this.lbDecksLeft.Font = new System.Drawing.Font("Century", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDecksLeft.Location = new System.Drawing.Point(131, 222);
            this.lbDecksLeft.Name = "lbDecksLeft";
            this.lbDecksLeft.Size = new System.Drawing.Size(101, 20);
            this.lbDecksLeft.TabIndex = 25;
            this.lbDecksLeft.Text = "Decks Left:";
            // 
            // lbCardsLeft
            // 
            this.lbCardsLeft.AutoSize = true;
            this.lbCardsLeft.Font = new System.Drawing.Font("Century", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCardsLeft.Location = new System.Drawing.Point(130, 182);
            this.lbCardsLeft.Name = "lbCardsLeft";
            this.lbCardsLeft.Size = new System.Drawing.Size(102, 20);
            this.lbCardsLeft.TabIndex = 26;
            this.lbCardsLeft.Text = "Cards Left:";
            // 
            // menuKings
            // 
            this.menuKings.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuKings.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.addMemberToolStripMenuItem,
            this.addDeckToolStripMenuItem,
            this.excludeCardToolStripMenuItem,
            this.restartToolStripMenuItem});
            this.menuKings.Location = new System.Drawing.Point(0, 0);
            this.menuKings.Name = "menuKings";
            this.menuKings.Size = new System.Drawing.Size(884, 24);
            this.menuKings.TabIndex = 27;
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
            this.welcomeScreenToolStripMenuItem.Click += new System.EventHandler(this.welcomeScreenToolStripMenuItem_Click);
            // 
            // gameDetailsToolStripMenuItem
            // 
            this.gameDetailsToolStripMenuItem.Name = "gameDetailsToolStripMenuItem";
            this.gameDetailsToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.gameDetailsToolStripMenuItem.Text = "Game Details";
            this.gameDetailsToolStripMenuItem.Click += new System.EventHandler(this.gameDetailsToolStripMenuItem_Click);
            // 
            // addMemberToolStripMenuItem
            // 
            this.addMemberToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPlayerToolStripMenuItem1,
            this.removePlayerToolStripMenuItem,
            this.changePlayerNameToolStripMenuItem});
            this.addMemberToolStripMenuItem.Name = "addMemberToolStripMenuItem";
            this.addMemberToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.addMemberToolStripMenuItem.Text = "Player";
            // 
            // addPlayerToolStripMenuItem1
            // 
            this.addPlayerToolStripMenuItem1.Name = "addPlayerToolStripMenuItem1";
            this.addPlayerToolStripMenuItem1.Size = new System.Drawing.Size(204, 22);
            this.addPlayerToolStripMenuItem1.Text = "Add Player";
            this.addPlayerToolStripMenuItem1.Click += new System.EventHandler(this.addPlayerToolStripMenuItem1_Click);
            // 
            // removePlayerToolStripMenuItem
            // 
            this.removePlayerToolStripMenuItem.Name = "removePlayerToolStripMenuItem";
            this.removePlayerToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.removePlayerToolStripMenuItem.Text = "Remove Player";
            this.removePlayerToolStripMenuItem.Click += new System.EventHandler(this.removePlayerToolStripMenuItem_Click);
            // 
            // changePlayerNameToolStripMenuItem
            // 
            this.changePlayerNameToolStripMenuItem.Name = "changePlayerNameToolStripMenuItem";
            this.changePlayerNameToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.changePlayerNameToolStripMenuItem.Text = "Change Player Name";
            this.changePlayerNameToolStripMenuItem.Click += new System.EventHandler(this.changePlayerNameToolStripMenuItem_Click);
            // 
            // addDeckToolStripMenuItem
            // 
            this.addDeckToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.halfDeckToolStripMenuItem,
            this.oneDeckToolStripMenuItem,
            this.twoDeckToolStripMenuItem});
            this.addDeckToolStripMenuItem.Name = "addDeckToolStripMenuItem";
            this.addDeckToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.addDeckToolStripMenuItem.Text = "Add Deck";
            // 
            // halfDeckToolStripMenuItem
            // 
            this.halfDeckToolStripMenuItem.Name = "halfDeckToolStripMenuItem";
            this.halfDeckToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.halfDeckToolStripMenuItem.Text = "1/2 Deck";
            this.halfDeckToolStripMenuItem.Click += new System.EventHandler(this.halfDeckToolStripMenuItem_Click);
            // 
            // oneDeckToolStripMenuItem
            // 
            this.oneDeckToolStripMenuItem.Name = "oneDeckToolStripMenuItem";
            this.oneDeckToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.oneDeckToolStripMenuItem.Text = "1 Deck";
            this.oneDeckToolStripMenuItem.Click += new System.EventHandler(this.oneDeckToolStripMenuItem_Click);
            // 
            // twoDeckToolStripMenuItem
            // 
            this.twoDeckToolStripMenuItem.Name = "twoDeckToolStripMenuItem";
            this.twoDeckToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.twoDeckToolStripMenuItem.Text = "2 Deck";
            this.twoDeckToolStripMenuItem.Click += new System.EventHandler(this.twoDeckToolStripMenuItem_Click);
            // 
            // excludeCardToolStripMenuItem
            // 
            this.excludeCardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chooseCardToolStripMenuItem,
            this.undoExclusionToolStripMenuItem});
            this.excludeCardToolStripMenuItem.Name = "excludeCardToolStripMenuItem";
            this.excludeCardToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.excludeCardToolStripMenuItem.Text = "Exclude Card";
            // 
            // chooseCardToolStripMenuItem
            // 
            this.chooseCardToolStripMenuItem.Name = "chooseCardToolStripMenuItem";
            this.chooseCardToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.chooseCardToolStripMenuItem.Text = "Choose Card";
            this.chooseCardToolStripMenuItem.Click += new System.EventHandler(this.chooseCardToolStripMenuItem_Click);
            // 
            // undoExclusionToolStripMenuItem
            // 
            this.undoExclusionToolStripMenuItem.Name = "undoExclusionToolStripMenuItem";
            this.undoExclusionToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.undoExclusionToolStripMenuItem.Text = "Undo Exclusion";
            this.undoExclusionToolStripMenuItem.Click += new System.EventHandler(this.undoExclusionToolStripMenuItem_Click);
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restartGameToolStripMenuItem});
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.restartToolStripMenuItem.Text = "Restart";
            // 
            // restartGameToolStripMenuItem
            // 
            this.restartGameToolStripMenuItem.Name = "restartGameToolStripMenuItem";
            this.restartGameToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.restartGameToolStripMenuItem.Text = "Restart Game";
            this.restartGameToolStripMenuItem.Click += new System.EventHandler(this.restartGameToolStripMenuItem_Click);
            // 
            // lbPlayerName
            // 
            this.lbPlayerName.AutoSize = true;
            this.lbPlayerName.Font = new System.Drawing.Font("Century", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlayerName.Location = new System.Drawing.Point(532, 163);
            this.lbPlayerName.Name = "lbPlayerName";
            this.lbPlayerName.Size = new System.Drawing.Size(122, 20);
            this.lbPlayerName.TabIndex = 29;
            this.lbPlayerName.Text = "Player Name:";
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayerName.Location = new System.Drawing.Point(660, 155);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.ReadOnly = true;
            this.txtPlayerName.Size = new System.Drawing.Size(177, 28);
            this.txtPlayerName.TabIndex = 28;
            this.txtPlayerName.Text = "";
            // 
            // lbPlayerAmount
            // 
            this.lbPlayerAmount.AutoSize = true;
            this.lbPlayerAmount.Font = new System.Drawing.Font("Century", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlayerAmount.Location = new System.Drawing.Point(619, 113);
            this.lbPlayerAmount.Name = "lbPlayerAmount";
            this.lbPlayerAmount.Size = new System.Drawing.Size(173, 20);
            this.lbPlayerAmount.TabIndex = 31;
            this.lbPlayerAmount.Text = "Number Of Players:";
            // 
            // txtPlayerAmount
            // 
            this.txtPlayerAmount.Location = new System.Drawing.Point(798, 113);
            this.txtPlayerAmount.Name = "txtPlayerAmount";
            this.txtPlayerAmount.ReadOnly = true;
            this.txtPlayerAmount.Size = new System.Drawing.Size(39, 20);
            this.txtPlayerAmount.TabIndex = 30;
            this.txtPlayerAmount.Text = "";
            // 
            // Kings
            // 
            this.AcceptButton = this.nextCardButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.lbPlayerAmount);
            this.Controls.Add(this.txtPlayerAmount);
            this.Controls.Add(this.lbPlayerName);
            this.Controls.Add(this.txtPlayerName);
            this.Controls.Add(this.lbCardsLeft);
            this.Controls.Add(this.lbDecksLeft);
            this.Controls.Add(this.txtDecksLeft);
            this.Controls.Add(this.txtCardsLeft);
            this.Controls.Add(this.nextCardButton);
            this.Controls.Add(this.lcCardName);
            this.Controls.Add(this.lbCardRule);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCardRule);
            this.Controls.Add(this.txtCardName);
            this.Controls.Add(this.cardBox);
            this.Controls.Add(this.menuKings);
            this.MainMenuStrip = this.menuKings;
            this.Name = "Kings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kings";
            this.Load += new System.EventHandler(this.Kings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cardBox)).EndInit();
            this.menuKings.ResumeLayout(false);
            this.menuKings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox cardBox;
        private RichTextBox txtCardName;
        private RichTextBox txtCardRule;
        private Label label1;
        private Label lbCardRule;
        private Label lcCardName;
        private Button nextCardButton;
        private RichTextBox txtCardsLeft;
        private RichTextBox txtDecksLeft;
        private Label lbDecksLeft;
        private Label lbCardsLeft;
        private MenuStrip menuKings;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem addMemberToolStripMenuItem;
        private ToolStripMenuItem addPlayerToolStripMenuItem1;
        private ToolStripMenuItem removePlayerToolStripMenuItem;
        private ToolStripMenuItem addDeckToolStripMenuItem;
        private ToolStripMenuItem excludeCardToolStripMenuItem;
        private ToolStripMenuItem restartToolStripMenuItem;
        private ToolStripMenuItem welcomeScreenToolStripMenuItem;
        private ToolStripMenuItem gameDetailsToolStripMenuItem;
        private ToolStripMenuItem halfDeckToolStripMenuItem;
        private ToolStripMenuItem oneDeckToolStripMenuItem;
        private ToolStripMenuItem twoDeckToolStripMenuItem;
        private ToolStripMenuItem chooseCardToolStripMenuItem;
        private ToolStripMenuItem restartGameToolStripMenuItem;
        private ToolStripMenuItem changePlayerNameToolStripMenuItem;
        private Label lbPlayerName;
        private RichTextBox txtPlayerName;
        private Label lbPlayerAmount;
        private RichTextBox txtPlayerAmount;
        private ToolStripMenuItem undoExclusionToolStripMenuItem;
    }
}