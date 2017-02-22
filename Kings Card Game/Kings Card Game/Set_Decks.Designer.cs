namespace Kings_Card_Game
{
    partial class Set_Decks
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
            this.lbSetDeck = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.setDeckButton = new System.Windows.Forms.Button();
            this.comboDeck = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbSetDeck
            // 
            this.lbSetDeck.AutoSize = true;
            this.lbSetDeck.Font = new System.Drawing.Font("Century", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSetDeck.Location = new System.Drawing.Point(12, 83);
            this.lbSetDeck.Name = "lbSetDeck";
            this.lbSetDeck.Size = new System.Drawing.Size(259, 20);
            this.lbSetDeck.TabIndex = 30;
            this.lbSetDeck.Text = "Please select number of decks:";
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Font = new System.Drawing.Font("Century", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(245, 147);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(125, 30);
            this.cancelButton.TabIndex = 29;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // setDeckButton
            // 
            this.setDeckButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.setDeckButton.Font = new System.Drawing.Font("Century", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setDeckButton.Location = new System.Drawing.Point(70, 147);
            this.setDeckButton.Name = "setDeckButton";
            this.setDeckButton.Size = new System.Drawing.Size(125, 30);
            this.setDeckButton.TabIndex = 28;
            this.setDeckButton.Text = "Set";
            this.setDeckButton.UseVisualStyleBackColor = true;
            // 
            // comboDeck
            // 
            this.comboDeck.AutoCompleteCustomSource.AddRange(new string[] {
            "1/2 Deck",
            "1 Deck",
            "2 Deck",
            "3 Deck"});
            this.comboDeck.FormattingEnabled = true;
            this.comboDeck.Items.AddRange(new object[] {
            "1/2 Deck",
            "1 Deck",
            "2 Deck",
            "3 Deck"});
            this.comboDeck.Location = new System.Drawing.Point(278, 82);
            this.comboDeck.Name = "comboDeck";
            this.comboDeck.Size = new System.Drawing.Size(121, 21);
            this.comboDeck.TabIndex = 31;
            // 
            // Set_Decks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(424, 191);
            this.Controls.Add(this.comboDeck);
            this.Controls.Add(this.lbSetDeck);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.setDeckButton);
            this.Name = "Set_Decks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Set Decks";
            this.Load += new System.EventHandler(this.Set_Decks_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSetDeck;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button setDeckButton;
        public System.Windows.Forms.ComboBox comboDeck;
    }
}