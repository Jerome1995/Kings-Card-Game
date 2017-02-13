﻿namespace Kings_Card_Game
{
    partial class Exclude_Cards
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
            this.comboCard.FormattingEnabled = true;
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
            this.cancelButton.Font = new System.Drawing.Font("Century", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(245, 147);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(125, 30);
            this.cancelButton.TabIndex = 33;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // excludeCardButton
            // 
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(424, 191);
            this.Controls.Add(this.comboCard);
            this.Controls.Add(this.lbExcludeCard);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.excludeCardButton);
            this.Name = "Exclude_Cards";
            this.Text = "Exclude Cards";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboCard;
        private System.Windows.Forms.Label lbExcludeCard;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button excludeCardButton;
    }
}