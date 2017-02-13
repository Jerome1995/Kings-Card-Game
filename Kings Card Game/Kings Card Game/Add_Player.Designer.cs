namespace Kings_Card_Game
{
    partial class Add_Player
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
            this.addPlayerButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.lbEnterPlayer = new System.Windows.Forms.Label();
            this.txtPlayerName = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // addPlayerButton
            // 
            this.addPlayerButton.Font = new System.Drawing.Font("Century", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPlayerButton.Location = new System.Drawing.Point(70, 147);
            this.addPlayerButton.Name = "addPlayerButton";
            this.addPlayerButton.Size = new System.Drawing.Size(125, 30);
            this.addPlayerButton.TabIndex = 22;
            this.addPlayerButton.Text = "Add";
            this.addPlayerButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Century", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(245, 147);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(125, 30);
            this.cancelButton.TabIndex = 23;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // lbEnterPlayer
            // 
            this.lbEnterPlayer.AutoSize = true;
            this.lbEnterPlayer.Font = new System.Drawing.Font("Century", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEnterPlayer.Location = new System.Drawing.Point(12, 83);
            this.lbEnterPlayer.Name = "lbEnterPlayer";
            this.lbEnterPlayer.Size = new System.Drawing.Size(225, 20);
            this.lbEnterPlayer.TabIndex = 27;
            this.lbEnterPlayer.Text = "Please enter player name:";
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Location = new System.Drawing.Point(243, 71);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(169, 32);
            this.txtPlayerName.TabIndex = 28;
            this.txtPlayerName.Text = "";
            // 
            // Add_Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(424, 191);
            this.Controls.Add(this.txtPlayerName);
            this.Controls.Add(this.lbEnterPlayer);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addPlayerButton);
            this.Name = "Add_Player";
            this.Text = "Add Player";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addPlayerButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label lbEnterPlayer;
        private System.Windows.Forms.RichTextBox txtPlayerName;
    }
}