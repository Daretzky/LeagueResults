using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class AddTeam : Form
    {
        public AddTeam()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddTeam_Load(object sender, EventArgs e)
        {

        }

        private void addTeamButton_Click(object sender, EventArgs e)
        {
            try
            {
                AddValues sql = new AddValues();
                string sqlQuery = String.Format("INSERT INTO teams VALUES ('{0}','{1}');",
                    textBox1.Text, textBox2.Text);
                sql.addMatchResults(sqlQuery);

            }
            catch (Exception msg)
            {
                // something went wrong, and you wanna know why
                MessageBox.Show(msg.ToString());
                throw;
            }
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
