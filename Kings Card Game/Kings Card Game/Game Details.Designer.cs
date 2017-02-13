namespace Kings_Card_Game
{
    partial class Welcome_Screen
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
            this.addPlayerButton = new System.Windows.Forms.Button();
            this.enterDetails = new System.Windows.Forms.TextBox();
            this.addDeckButton = new System.Windows.Forms.Button();
            this.excludeCardButton = new System.Windows.Forms.Button();
            this.grdPlayerNames = new System.Windows.Forms.DataGridView();
            this.grdDeckAmount = new System.Windows.Forms.DataGridView();
            this.grdExcludedCards = new System.Windows.Forms.DataGridView();
            this.startGameButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdPlayerNames)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDeckAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdExcludedCards)).BeginInit();
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
            this.Heading.TabIndex = 1;
            this.Heading.Text = "Kings Card Game";
            // 
            // addPlayerButton
            // 
            this.addPlayerButton.Font = new System.Drawing.Font("Century", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPlayerButton.Location = new System.Drawing.Point(89, 154);
            this.addPlayerButton.Name = "addPlayerButton";
            this.addPlayerButton.Size = new System.Drawing.Size(160, 45);
            this.addPlayerButton.TabIndex = 2;
            this.addPlayerButton.Text = "Add Player";
            this.addPlayerButton.UseVisualStyleBackColor = true;
            // 
            // enterDetails
            // 
            this.enterDetails.BackColor = System.Drawing.Color.Silver;
            this.enterDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.enterDetails.Font = new System.Drawing.Font("Century", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterDetails.Location = new System.Drawing.Point(140, 105);
            this.enterDetails.Multiline = true;
            this.enterDetails.Name = "enterDetails";
            this.enterDetails.Size = new System.Drawing.Size(620, 32);
            this.enterDetails.TabIndex = 0;
            this.enterDetails.Text = "Please enter the details for the game here";
            this.enterDetails.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // addDeckButton
            // 
            this.addDeckButton.Font = new System.Drawing.Font("Century", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDeckButton.Location = new System.Drawing.Point(354, 154);
            this.addDeckButton.Name = "addDeckButton";
            this.addDeckButton.Size = new System.Drawing.Size(160, 45);
            this.addDeckButton.TabIndex = 3;
            this.addDeckButton.Text = "Add Deck";
            this.addDeckButton.UseVisualStyleBackColor = true;
            // 
            // excludeCardButton
            // 
            this.excludeCardButton.Font = new System.Drawing.Font("Century", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excludeCardButton.Location = new System.Drawing.Point(633, 154);
            this.excludeCardButton.Name = "excludeCardButton";
            this.excludeCardButton.Size = new System.Drawing.Size(160, 45);
            this.excludeCardButton.TabIndex = 4;
            this.excludeCardButton.Text = "Exclude Card";
            this.excludeCardButton.UseVisualStyleBackColor = true;
            // 
            // grdPlayerNames
            // 
            this.grdPlayerNames.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.grdPlayerNames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPlayerNames.Location = new System.Drawing.Point(89, 227);
            this.grdPlayerNames.Name = "grdPlayerNames";
            this.grdPlayerNames.Size = new System.Drawing.Size(160, 191);
            this.grdPlayerNames.TabIndex = 5;
            // 
            // grdDeckAmount
            // 
            this.grdDeckAmount.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.grdDeckAmount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDeckAmount.Location = new System.Drawing.Point(410, 227);
            this.grdDeckAmount.Name = "grdDeckAmount";
            this.grdDeckAmount.Size = new System.Drawing.Size(40, 32);
            this.grdDeckAmount.TabIndex = 6;
            // 
            // grdExcludedCards
            // 
            this.grdExcludedCards.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.grdExcludedCards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdExcludedCards.Location = new System.Drawing.Point(633, 227);
            this.grdExcludedCards.Name = "grdExcludedCards";
            this.grdExcludedCards.Size = new System.Drawing.Size(160, 191);
            this.grdExcludedCards.TabIndex = 7;
            // 
            // startGameButton
            // 
            this.startGameButton.Font = new System.Drawing.Font("Century", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startGameButton.Location = new System.Drawing.Point(370, 440);
            this.startGameButton.Name = "startGameButton";
            this.startGameButton.Size = new System.Drawing.Size(160, 45);
            this.startGameButton.TabIndex = 8;
            this.startGameButton.Text = "Start Game";
            this.startGameButton.UseVisualStyleBackColor = true;
            // 
            // Welcome_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.startGameButton);
            this.Controls.Add(this.grdExcludedCards);
            this.Controls.Add(this.grdDeckAmount);
            this.Controls.Add(this.grdPlayerNames);
            this.Controls.Add(this.excludeCardButton);
            this.Controls.Add(this.addDeckButton);
            this.Controls.Add(this.addPlayerButton);
            this.Controls.Add(this.Heading);
            this.Controls.Add(this.enterDetails);
            this.Name = "Welcome_Screen";
            this.Text = "Welcome To Kings Card Game";
            ((System.ComponentModel.ISupportInitialize)(this.grdPlayerNames)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDeckAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdExcludedCards)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Heading;
        private System.Windows.Forms.Button addPlayerButton;
        private System.Windows.Forms.TextBox enterDetails;
        private System.Windows.Forms.Button addDeckButton;
        private System.Windows.Forms.Button excludeCardButton;
        private System.Windows.Forms.DataGridView grdPlayerNames;
        private System.Windows.Forms.DataGridView grdDeckAmount;
        private System.Windows.Forms.DataGridView grdExcludedCards;
        private System.Windows.Forms.Button startGameButton;
    }
}

