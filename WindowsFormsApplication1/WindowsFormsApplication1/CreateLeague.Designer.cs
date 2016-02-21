namespace WindowsFormsApplication1
{
    partial class CreateLeague
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
            this.leagueName = new System.Windows.Forms.TextBox();
            this.playersList = new System.Windows.Forms.ListBox();
            this.playerTextBox = new System.Windows.Forms.TextBox();
            this.AddPlayer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // leagueName
            // 
            this.leagueName.Location = new System.Drawing.Point(12, 12);
            this.leagueName.Name = "leagueName";
            this.leagueName.Size = new System.Drawing.Size(100, 20);
            this.leagueName.TabIndex = 0;
            // 
            // playersList
            // 
            this.playersList.FormattingEnabled = true;
            this.playersList.Location = new System.Drawing.Point(12, 58);
            this.playersList.Name = "playersList";
            this.playersList.Size = new System.Drawing.Size(120, 95);
            this.playersList.TabIndex = 1;
            // 
            // playerTextBox
            // 
            this.playerTextBox.Location = new System.Drawing.Point(154, 58);
            this.playerTextBox.Name = "playerTextBox";
            this.playerTextBox.Size = new System.Drawing.Size(100, 20);
            this.playerTextBox.TabIndex = 2;
            // 
            // AddPlayer
            // 
            this.AddPlayer.Location = new System.Drawing.Point(154, 109);
            this.AddPlayer.Name = "AddPlayer";
            this.AddPlayer.Size = new System.Drawing.Size(75, 23);
            this.AddPlayer.TabIndex = 3;
            this.AddPlayer.Text = "Add Player";
            this.AddPlayer.UseVisualStyleBackColor = true;
            this.AddPlayer.Click += new System.EventHandler(this.AddPlayer_Click);
            // 
            // CreateLeague
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.AddPlayer);
            this.Controls.Add(this.playerTextBox);
            this.Controls.Add(this.playersList);
            this.Controls.Add(this.leagueName);
            this.Name = "CreateLeague";
            this.Text = "CreateLeague";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox leagueName;
        private System.Windows.Forms.ListBox playersList;
        private System.Windows.Forms.TextBox playerTextBox;
        private System.Windows.Forms.Button AddPlayer;
    }
}