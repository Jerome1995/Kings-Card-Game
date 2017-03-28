using System.ComponentModel;
using System.Windows.Forms;

namespace Kings_Card_Game
{
    partial class ExcludeCards
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
            this.comboCard = new System.Windows.Forms.ComboBox();
            this.lbExcludeCard = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.excludeCardButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboCard
            // 
            this.comboCard.AutoCompleteCustomSource.AddRange(new string[] {
            "1/2 Deck",
            "1 Deck",
            "2 Deck",
            "3 Deck"});
            this.comboCard.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCard.FormattingEnabled = true;
            this.comboCard.Items.AddRange(new object[] {
            "Ace Of Spades",
            "Two Of Spades",
            "Three Of Spades",
            "Four Of Spades",
            "Five Of Spades",
            "Six Of Spades",
            "Seven Of Spades",
            "Eight Of Spades",
            "Nine Of Spades",
            "Ten Of Spades",
            "Ace Of Hearts",
            "Two Of Hearts",
            "Three Of Hearts",
            "Four Of Hearts",
            "Five Of Hearts",
            "Six Of Hearts",
            "Seven Of Hearts",
            "Eight Of Hearts",
            "Nine Of Hearts",
            "Ten Of Hearts",
            "Ace Of Diamonds",
            "Two Of Diamonds",
            "Three Of Diamonds",
            "Four Of Diamonds",
            "Five Of Diamonds",
            "Six Of Diamonds",
            "Seven Of Diamonds",
            "Eight Of Diamonds",
            "Nine Of Diamonds",
            "Ten Of Diamonds",
            "Ace Of Clubs",
            "Two Of Clubs",
            "Three Of Clubs",
            "Four Of Clubs",
            "Five Of Clubs",
            "Six Of Clubs",
            "Seven Of Clubs",
            "Eight Of Clubs",
            "Nine Of Clubs",
            "Ten Of Clubs",
            "Jack Of Spades",
            "Jack Of Hearts",
            "Jack Of Diamonds",
            "Jack Of Clubs",
            "Queen Of Spades",
            "Queen Of Hearts",
            "Queen Of Diamonds",
            "Queen Of Clubs",
            "King Of Spades",
            "King Of Hearts",
            "King Of Diamonds",
            "King Of Clubs"});
            this.comboCard.Location = new System.Drawing.Point(107, 94);
            this.comboCard.Name = "comboCard";
            this.comboCard.Size = new System.Drawing.Size(205, 21);
            this.comboCard.TabIndex = 35;
            // 
            // lbExcludeCard
            // 
            this.lbExcludeCard.AutoSize = true;
            this.lbExcludeCard.Font = new System.Drawing.Font("Century", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExcludeCard.Location = new System.Drawing.Point(80, 60);
            this.lbExcludeCard.Name = "lbExcludeCard";
            this.lbExcludeCard.Size = new System.Drawing.Size(258, 20);
            this.lbExcludeCard.TabIndex = 34;
            this.lbExcludeCard.Text = "Please select cards to exclude:";
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Font = new System.Drawing.Font("Century", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(245, 147);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(125, 30);
            this.cancelButton.TabIndex = 33;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // excludeCardButton
            // 
            this.excludeCardButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.excludeCardButton.Font = new System.Drawing.Font("Century", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excludeCardButton.Location = new System.Drawing.Point(70, 147);
            this.excludeCardButton.Name = "excludeCardButton";
            this.excludeCardButton.Size = new System.Drawing.Size(125, 30);
            this.excludeCardButton.TabIndex = 32;
            this.excludeCardButton.Text = "Exclude";
            this.excludeCardButton.UseVisualStyleBackColor = true;
            // 
            // Exclude_Cards
            // 
            this.AcceptButton = this.excludeCardButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(424, 191);
            this.Controls.Add(this.comboCard);
            this.Controls.Add(this.lbExcludeCard);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.excludeCardButton);
            this.Name = "ExcludeCards";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exclude Cards";
            this.Load += new System.EventHandler(this.Exclude_Cards_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbExcludeCard;
        private Button cancelButton;
        private Button excludeCardButton;
        public ComboBox comboCard;
    }
}