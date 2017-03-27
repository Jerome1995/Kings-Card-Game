namespace Kings_Card_Game
{
    partial class Change_Player_Name
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
            this.lbSelectPlayerName = new System.Windows.Forms.Label();
            this.lbNewName = new System.Windows.Forms.Label();
            this.txtNewName = new System.Windows.Forms.RichTextBox();
            this.setNewNameButton = new System.Windows.Forms.Button();
            this.txtOldName = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbSelectPlayerName
            // 
            this.lbSelectPlayerName.Font = new System.Drawing.Font("Century", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSelectPlayerName.Location = new System.Drawing.Point(181, 12);
            this.lbSelectPlayerName.Name = "lbSelectPlayerName";
            this.lbSelectPlayerName.Size = new System.Drawing.Size(231, 84);
            this.lbSelectPlayerName.TabIndex = 31;
            this.lbSelectPlayerName.Text = "Please enter the old player name and enter \r\nthe new name in the text box";
            // 
            // lbNewName
            // 
            this.lbNewName.AutoSize = true;
            this.lbNewName.Font = new System.Drawing.Font("Century", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNewName.Location = new System.Drawing.Point(135, 110);
            this.lbNewName.Name = "lbNewName";
            this.lbNewName.Size = new System.Drawing.Size(102, 20);
            this.lbNewName.TabIndex = 32;
            this.lbNewName.Text = "New Name:";
            // 
            // txtNewName
            // 
            this.txtNewName.Location = new System.Drawing.Point(243, 110);
            this.txtNewName.Name = "txtNewName";
            this.txtNewName.Size = new System.Drawing.Size(121, 20);
            this.txtNewName.TabIndex = 33;
            this.txtNewName.Text = "";
            // 
            // setNewNameButton
            // 
            this.setNewNameButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.setNewNameButton.Font = new System.Drawing.Font("Century", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setNewNameButton.Location = new System.Drawing.Point(139, 149);
            this.setNewNameButton.Name = "setNewNameButton";
            this.setNewNameButton.Size = new System.Drawing.Size(125, 30);
            this.setNewNameButton.TabIndex = 34;
            this.setNewNameButton.Text = "Set Name";
            this.setNewNameButton.UseVisualStyleBackColor = true;
            // 
            // txtOldName
            // 
            this.txtOldName.Location = new System.Drawing.Point(32, 59);
            this.txtOldName.Name = "txtOldName";
            this.txtOldName.Size = new System.Drawing.Size(121, 20);
            this.txtOldName.TabIndex = 35;
            this.txtOldName.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "Old Name:";
            // 
            // Change_Player_Name
            // 
            this.AcceptButton = this.setNewNameButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(424, 191);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOldName);
            this.Controls.Add(this.setNewNameButton);
            this.Controls.Add(this.txtNewName);
            this.Controls.Add(this.lbNewName);
            this.Controls.Add(this.lbSelectPlayerName);
            this.Name = "Change_Player_Name";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Player Name";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSelectPlayerName;
        private System.Windows.Forms.Label lbNewName;
        private System.Windows.Forms.Button setNewNameButton;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.RichTextBox txtNewName;
        public System.Windows.Forms.RichTextBox txtOldName;
    }
}