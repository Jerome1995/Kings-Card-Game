﻿namespace Kings_Card_Game
{
    partial class Kings
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
            this.cardBox = new System.Windows.Forms.PictureBox();
            this.txtCardName = new System.Windows.Forms.RichTextBox();
            this.txtCardRule = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nextCardButton = new System.Windows.Forms.Button();
            this.txtCardsLeft = new System.Windows.Forms.RichTextBox();
            this.txtDecksLeft = new System.Windows.Forms.RichTextBox();
            this.lbDecksLeft = new System.Windows.Forms.Label();
            this.lbCardsLeft = new System.Windows.Forms.Label();
            this.menuKings = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMemberToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.removeMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDeckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excludeCardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deckToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deckToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.chooseCardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.welcomeScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.cardBox)).BeginInit();
            this.menuKings.SuspendLayout();
            this.SuspendLayout();
            // 
            // cardBox
            // 
            this.cardBox.Location = new System.Drawing.Point(317, 97);
            this.cardBox.Name = "cardBox";
            this.cardBox.Size = new System.Drawing.Size(201, 248);
            this.cardBox.TabIndex = 4;
            this.cardBox.TabStop = false;
            // 
            // txtCardName
            // 
            this.txtCardName.Location = new System.Drawing.Point(317, 361);
            this.txtCardName.Name = "txtCardName";
            this.txtCardName.ReadOnly = true;
            this.txtCardName.Size = new System.Drawing.Size(265, 32);
            this.txtCardName.TabIndex = 5;
            this.txtCardName.Text = "";
            // 
            // txtCardRule
            // 
            this.txtCardRule.Location = new System.Drawing.Point(317, 410);
            this.txtCardRule.Name = "txtCardRule";
            this.txtCardRule.ReadOnly = true;
            this.txtCardRule.Size = new System.Drawing.Size(407, 69);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(212, 459);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Card Rule:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(203, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Card Name:";
            // 
            // nextCardButton
            // 
            this.nextCardButton.Font = new System.Drawing.Font("Century", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextCardButton.Location = new System.Drawing.Point(564, 197);
            this.nextCardButton.Name = "nextCardButton";
            this.nextCardButton.Size = new System.Drawing.Size(160, 45);
            this.nextCardButton.TabIndex = 21;
            this.nextCardButton.Text = "Next Card";
            this.nextCardButton.UseVisualStyleBackColor = true;
            // 
            // txtCardsLeft
            // 
            this.txtCardsLeft.Location = new System.Drawing.Point(238, 170);
            this.txtCardsLeft.Name = "txtCardsLeft";
            this.txtCardsLeft.ReadOnly = true;
            this.txtCardsLeft.Size = new System.Drawing.Size(39, 32);
            this.txtCardsLeft.TabIndex = 23;
            this.txtCardsLeft.Text = "";
            // 
            // txtDecksLeft
            // 
            this.txtDecksLeft.Location = new System.Drawing.Point(238, 213);
            this.txtDecksLeft.Name = "txtDecksLeft";
            this.txtDecksLeft.ReadOnly = true;
            this.txtDecksLeft.Size = new System.Drawing.Size(39, 32);
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
            // addMemberToolStripMenuItem
            // 
            this.addMemberToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addMemberToolStripMenuItem1,
            this.removeMemberToolStripMenuItem});
            this.addMemberToolStripMenuItem.Name = "addMemberToolStripMenuItem";
            this.addMemberToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.addMemberToolStripMenuItem.Text = "Player";
            // 
            // addMemberToolStripMenuItem1
            // 
            this.addMemberToolStripMenuItem1.Name = "addMemberToolStripMenuItem1";
            this.addMemberToolStripMenuItem1.Size = new System.Drawing.Size(165, 22);
            this.addMemberToolStripMenuItem1.Text = "Add Player";
            // 
            // removeMemberToolStripMenuItem
            // 
            this.removeMemberToolStripMenuItem.Name = "removeMemberToolStripMenuItem";
            this.removeMemberToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.removeMemberToolStripMenuItem.Text = "Remove Player";
            // 
            // addDeckToolStripMenuItem
            // 
            this.addDeckToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deckToolStripMenuItem,
            this.deckToolStripMenuItem1,
            this.deckToolStripMenuItem2});
            this.addDeckToolStripMenuItem.Name = "addDeckToolStripMenuItem";
            this.addDeckToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.addDeckToolStripMenuItem.Text = "Add Deck";
            // 
            // excludeCardToolStripMenuItem
            // 
            this.excludeCardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chooseCardToolStripMenuItem});
            this.excludeCardToolStripMenuItem.Name = "excludeCardToolStripMenuItem";
            this.excludeCardToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.excludeCardToolStripMenuItem.Text = "Exclude Card";
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restartGameToolStripMenuItem});
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.restartToolStripMenuItem.Text = "Restart";
            // 
            // deckToolStripMenuItem
            // 
            this.deckToolStripMenuItem.Name = "deckToolStripMenuItem";
            this.deckToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deckToolStripMenuItem.Text = "1/2 Deck";
            // 
            // deckToolStripMenuItem1
            // 
            this.deckToolStripMenuItem1.Name = "deckToolStripMenuItem1";
            this.deckToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.deckToolStripMenuItem1.Text = "1 Deck";
            // 
            // deckToolStripMenuItem2
            // 
            this.deckToolStripMenuItem2.Name = "deckToolStripMenuItem2";
            this.deckToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.deckToolStripMenuItem2.Text = "2 Deck";
            // 
            // chooseCardToolStripMenuItem
            // 
            this.chooseCardToolStripMenuItem.Name = "chooseCardToolStripMenuItem";
            this.chooseCardToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.chooseCardToolStripMenuItem.Text = "Choose Card";
            // 
            // restartGameToolStripMenuItem
            // 
            this.restartGameToolStripMenuItem.Name = "restartGameToolStripMenuItem";
            this.restartGameToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.restartGameToolStripMenuItem.Text = "Restart Game";
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
            // Kings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.lbCardsLeft);
            this.Controls.Add(this.lbDecksLeft);
            this.Controls.Add(this.txtDecksLeft);
            this.Controls.Add(this.txtCardsLeft);
            this.Controls.Add(this.nextCardButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCardRule);
            this.Controls.Add(this.txtCardName);
            this.Controls.Add(this.cardBox);
            this.Controls.Add(this.menuKings);
            this.MainMenuStrip = this.menuKings;
            this.Name = "Kings";
            this.Text = "Kings";
            ((System.ComponentModel.ISupportInitialize)(this.cardBox)).EndInit();
            this.menuKings.ResumeLayout(false);
            this.menuKings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox cardBox;
        private System.Windows.Forms.RichTextBox txtCardName;
        private System.Windows.Forms.RichTextBox txtCardRule;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button nextCardButton;
        private System.Windows.Forms.RichTextBox txtCardsLeft;
        private System.Windows.Forms.RichTextBox txtDecksLeft;
        private System.Windows.Forms.Label lbDecksLeft;
        private System.Windows.Forms.Label lbCardsLeft;
        private System.Windows.Forms.MenuStrip menuKings;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addMemberToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem removeMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDeckToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excludeCardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem welcomeScreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deckToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deckToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deckToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem chooseCardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartGameToolStripMenuItem;
    }
}