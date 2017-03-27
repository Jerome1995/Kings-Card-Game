namespace Kings_Card_Game
{
    partial class Remove_Player
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
            this.txtPlayerName = new System.Windows.Forms.RichTextBox();
            this.lbEnterPlayer = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.removePlayerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Location = new System.Drawing.Point(243, 83);
            this.txtPlayerName.Multiline = false;
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(127, 20);
            this.txtPlayerName.TabIndex = 32;
            this.txtPlayerName.Text = "";
            // 
            // lbEnterPlayer
            // 
            this.lbEnterPlayer.AutoSize = true;
            this.lbEnterPlayer.Font = new System.Drawing.Font("Century", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEnterPlayer.Location = new System.Drawing.Point(12, 83);
            this.lbEnterPlayer.Name = "lbEnterPlayer";
            this.lbEnterPlayer.Size = new System.Drawing.Size(225, 20);
            this.lbEnterPlayer.TabIndex = 31;
            this.lbEnterPlayer.Text = "Please enter player name:";
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Font = new System.Drawing.Font("Century", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(245, 147);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(125, 30);
            this.cancelButton.TabIndex = 30;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // removePlayerButton
            // 
            this.removePlayerButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.removePlayerButton.Font = new System.Drawing.Font("Century", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removePlayerButton.Location = new System.Drawing.Point(70, 147);
            this.removePlayerButton.Name = "removePlayerButton";
            this.removePlayerButton.Size = new System.Drawing.Size(125, 30);
            this.removePlayerButton.TabIndex = 29;
            this.removePlayerButton.Text = "Remove";
            this.removePlayerButton.UseVisualStyleBackColor = true;
            // 
            // Remove_Player
            // 
            this.AcceptButton = this.removePlayerButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(424, 191);
            this.Controls.Add(this.txtPlayerName);
            this.Controls.Add(this.lbEnterPlayer);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.removePlayerButton);
            this.Name = "Remove_Player";
            this.Text = "Remove Player";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.RichTextBox txtPlayerName;
        private System.Windows.Forms.Label lbEnterPlayer;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button removePlayerButton;
    }
}