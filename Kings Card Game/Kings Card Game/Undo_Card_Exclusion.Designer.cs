using System.ComponentModel;
using System.Windows.Forms;

namespace Kings_Card_Game
{
    partial class UndoCardExclusion
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
            this.UndoExclusionButton = new System.Windows.Forms.Button();
            this.lbSelectCard = new System.Windows.Forms.Label();
            this.comboCard = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // UndoExclusionButton
            // 
            this.UndoExclusionButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.UndoExclusionButton.Font = new System.Drawing.Font("Century", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UndoExclusionButton.Location = new System.Drawing.Point(137, 135);
            this.UndoExclusionButton.Name = "UndoExclusionButton";
            this.UndoExclusionButton.Size = new System.Drawing.Size(178, 30);
            this.UndoExclusionButton.TabIndex = 37;
            this.UndoExclusionButton.Text = "Undo Exclusion";
            this.UndoExclusionButton.UseVisualStyleBackColor = true;
            // 
            // lbSelectCard
            // 
            this.lbSelectCard.Font = new System.Drawing.Font("Century", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSelectCard.Location = new System.Drawing.Point(179, 12);
            this.lbSelectCard.Name = "lbSelectCard";
            this.lbSelectCard.Size = new System.Drawing.Size(231, 104);
            this.lbSelectCard.TabIndex = 36;
            this.lbSelectCard.Text = "Please select the card from the box and press the \r\n\'Undo Exclusion\' button if yo" +
    "u would like add the card to the deck.";
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
            this.comboCard.Location = new System.Drawing.Point(12, 56);
            this.comboCard.Name = "comboCard";
            this.comboCard.Size = new System.Drawing.Size(160, 21);
            this.comboCard.TabIndex = 38;
            // 
            // Undo_Card_Exclusion
            // 
            this.AcceptButton = this.UndoExclusionButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(424, 191);
            this.Controls.Add(this.comboCard);
            this.Controls.Add(this.UndoExclusionButton);
            this.Controls.Add(this.lbSelectCard);
            this.Name = "UndoCardExclusion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Undo Card Exclusion";
            this.ResumeLayout(false);

        }

        #endregion

        private Button UndoExclusionButton;
        private Label lbSelectCard;
        public ComboBox comboCard;

    }
}