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
            this.grdPlayerName = new System.Windows.Forms.DataGridView();
            this.lbSelectPlayerName = new System.Windows.Forms.Label();
            this.lbNewName = new System.Windows.Forms.Label();
            this.txtPlayerName = new System.Windows.Forms.RichTextBox();
            this.setNewNameButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdPlayerName)).BeginInit();
            this.SuspendLayout();
            // 
            // grdPlayerName
            // 
            this.grdPlayerName.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.grdPlayerName.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPlayerName.Location = new System.Drawing.Point(16, 12);
            this.grdPlayerName.Name = "grdPlayerName";
            this.grdPlayerName.Size = new System.Drawing.Size(159, 84);
            this.grdPlayerName.TabIndex = 14;
            // 
            // lbSelectPlayerName
            // 
            this.lbSelectPlayerName.Font = new System.Drawing.Font("Century", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSelectPlayerName.Location = new System.Drawing.Point(181, 12);
            this.lbSelectPlayerName.Name = "lbSelectPlayerName";
            this.lbSelectPlayerName.Size = new System.Drawing.Size(231, 84);
            this.lbSelectPlayerName.TabIndex = 31;
            this.lbSelectPlayerName.Text = "Please select the player from the box and enter \r\nthe new name in the text box";
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
            // txtPlayerName
            // 
            this.txtPlayerName.Location = new System.Drawing.Point(243, 98);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(169, 32);
            this.txtPlayerName.TabIndex = 33;
            this.txtPlayerName.Text = "";
            // 
            // setNewNameButton
            // 
            this.setNewNameButton.Font = new System.Drawing.Font("Century", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setNewNameButton.Location = new System.Drawing.Point(139, 149);
            this.setNewNameButton.Name = "setNewNameButton";
            this.setNewNameButton.Size = new System.Drawing.Size(125, 30);
            this.setNewNameButton.TabIndex = 34;
            this.setNewNameButton.Text = "Set Name";
            this.setNewNameButton.UseVisualStyleBackColor = true;
            // 
            // Change_Player_Name
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(424, 191);
            this.Controls.Add(this.setNewNameButton);
            this.Controls.Add(this.txtPlayerName);
            this.Controls.Add(this.lbNewName);
            this.Controls.Add(this.lbSelectPlayerName);
            this.Controls.Add(this.grdPlayerName);
            this.Name = "Change_Player_Name";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Player Name";
            ((System.ComponentModel.ISupportInitialize)(this.grdPlayerName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdPlayerName;
        private System.Windows.Forms.Label lbSelectPlayerName;
        private System.Windows.Forms.Label lbNewName;
        private System.Windows.Forms.RichTextBox txtPlayerName;
        private System.Windows.Forms.Button setNewNameButton;
    }
}