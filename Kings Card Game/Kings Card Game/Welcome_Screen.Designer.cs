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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome_Screen));
            this.Heading = new System.Windows.Forms.TextBox();
            this.enterDetails = new System.Windows.Forms.TextBox();
            this.playButton = new System.Windows.Forms.Button();
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
            // enterDetails
            // 
            this.enterDetails.BackColor = System.Drawing.Color.Silver;
            this.enterDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.enterDetails.Font = new System.Drawing.Font("Century", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterDetails.Location = new System.Drawing.Point(140, 121);
            this.enterDetails.Multiline = true;
            this.enterDetails.Name = "enterDetails";
            this.enterDetails.Size = new System.Drawing.Size(620, 155);
            this.enterDetails.TabIndex = 0;
            this.enterDetails.Text = resources.GetString("enterDetails.Text");
            this.enterDetails.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // playButton
            // 
            this.playButton.Font = new System.Drawing.Font("Century", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.Location = new System.Drawing.Point(370, 325);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(160, 45);
            this.playButton.TabIndex = 8;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            // 
            // Welcome_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.Heading);
            this.Controls.Add(this.enterDetails);
            this.Name = "Welcome_Screen";
            this.Text = "Kings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Heading;
        private System.Windows.Forms.TextBox enterDetails;
        private System.Windows.Forms.Button playButton;
    }
}