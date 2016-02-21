namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.wynikiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wynikiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.meczeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.druzynyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMatchResultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addLeagueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1387, 306);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wynikiToolStripMenuItem,
            this.addToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1411, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // wynikiToolStripMenuItem
            // 
            this.wynikiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wynikiToolStripMenuItem1,
            this.meczeToolStripMenuItem,
            this.druzynyToolStripMenuItem});
            this.wynikiToolStripMenuItem.Name = "wynikiToolStripMenuItem";
            this.wynikiToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.wynikiToolStripMenuItem.Text = "Tabele";
            this.wynikiToolStripMenuItem.Click += new System.EventHandler(this.wynikiToolStripMenuItem_Click);
            // 
            // wynikiToolStripMenuItem1
            // 
            this.wynikiToolStripMenuItem1.Name = "wynikiToolStripMenuItem1";
            this.wynikiToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.wynikiToolStripMenuItem1.Text = "Wyniki";
            this.wynikiToolStripMenuItem1.Click += new System.EventHandler(this.wynikiToolStripMenuItem1_Click);
            // 
            // meczeToolStripMenuItem
            // 
            this.meczeToolStripMenuItem.Name = "meczeToolStripMenuItem";
            this.meczeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.meczeToolStripMenuItem.Text = "Mecze";
            this.meczeToolStripMenuItem.Click += new System.EventHandler(this.meczeToolStripMenuItem_Click);
            // 
            // druzynyToolStripMenuItem
            // 
            this.druzynyToolStripMenuItem.Name = "druzynyToolStripMenuItem";
            this.druzynyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.druzynyToolStripMenuItem.Text = "Druzyny";
            this.druzynyToolStripMenuItem.Click += new System.EventHandler(this.druzynyToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addMatchResultToolStripMenuItem,
            this.addPlayerToolStripMenuItem,
            this.addLeagueToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.addToolStripMenuItem.Text = "Add...";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // addMatchResultToolStripMenuItem
            // 
            this.addMatchResultToolStripMenuItem.Name = "addMatchResultToolStripMenuItem";
            this.addMatchResultToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.addMatchResultToolStripMenuItem.Text = "Add match result";
            this.addMatchResultToolStripMenuItem.Click += new System.EventHandler(this.addMatchResultToolStripMenuItem_Click);
            // 
            // addPlayerToolStripMenuItem
            // 
            this.addPlayerToolStripMenuItem.Name = "addPlayerToolStripMenuItem";
            this.addPlayerToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.addPlayerToolStripMenuItem.Text = "Add player";
            this.addPlayerToolStripMenuItem.Click += new System.EventHandler(this.addPlayerToolStripMenuItem_Click);
            // 
            // addLeagueToolStripMenuItem
            // 
            this.addLeagueToolStripMenuItem.Name = "addLeagueToolStripMenuItem";
            this.addLeagueToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.addLeagueToolStripMenuItem.Text = "Add league";
            this.addLeagueToolStripMenuItem.Click += new System.EventHandler(this.addLeagueToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1411, 407);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem wynikiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wynikiToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem meczeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem druzynyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addMatchResultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPlayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addLeagueToolStripMenuItem;
    }
}

