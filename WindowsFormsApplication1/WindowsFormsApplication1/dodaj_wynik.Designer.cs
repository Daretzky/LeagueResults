namespace WindowsFormsApplication1
{
    partial class dodaj_wynik
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.scoreHome = new System.Windows.Forms.TextBox();
            this.scoreAway = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addResult = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.leagueNo = new System.Windows.Forms.ComboBox();
            this.queriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.queriesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Home";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Away";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // scoreHome
            // 
            this.scoreHome.Location = new System.Drawing.Point(30, 76);
            this.scoreHome.Name = "scoreHome";
            this.scoreHome.Size = new System.Drawing.Size(100, 20);
            this.scoreHome.TabIndex = 4;
            this.scoreHome.TextChanged += new System.EventHandler(this.scoreHome_TextChanged);
            // 
            // scoreAway
            // 
            this.scoreAway.Location = new System.Drawing.Point(264, 76);
            this.scoreAway.Name = "scoreAway";
            this.scoreAway.Size = new System.Drawing.Size(100, 20);
            this.scoreAway.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Score:";
            // 
            // addResult
            // 
            this.addResult.Location = new System.Drawing.Point(98, 200);
            this.addResult.Name = "addResult";
            this.addResult.Size = new System.Drawing.Size(75, 23);
            this.addResult.TabIndex = 7;
            this.addResult.Text = "Add Result";
            this.addResult.UseVisualStyleBackColor = true;
            this.addResult.Click += new System.EventHandler(this.addResult_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(30, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(264, 33);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 12;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // leagueNo
            // 
            this.leagueNo.FormattingEnabled = true;
            this.leagueNo.Location = new System.Drawing.Point(29, 120);
            this.leagueNo.Name = "leagueNo";
            this.leagueNo.Size = new System.Drawing.Size(121, 21);
            this.leagueNo.TabIndex = 13;
            this.leagueNo.SelectedIndexChanged += new System.EventHandler(this.leagueNo_SelectedIndexChanged);
            // 
            // queriesBindingSource
            // 
            this.queriesBindingSource.DataSource = typeof(WindowsFormsApplication1.Queries);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "League:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dodaj_wynik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 309);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.leagueNo);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.addResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.scoreAway);
            this.Controls.Add(this.scoreHome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "dodaj_wynik";
            this.Text = "Add match result";
            ((System.ComponentModel.ISupportInitialize)(this.queriesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox scoreHome;
        private System.Windows.Forms.TextBox scoreAway;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addResult;
        private System.Windows.Forms.BindingSource queriesBindingSource;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox leagueNo;
        private System.Windows.Forms.Label label4;
    }
}