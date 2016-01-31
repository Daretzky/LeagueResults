using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace WindowsFormsApplication1
{
    public partial class dodaj_wynik : Form
    {
        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable();
       

        Queries sql = new Queries();

        public dodaj_wynik()
        {   
            
            InitializeComponent();
            try
            {
                List<string> dataList = new List<string>();
                dataList = sql.readQueryList(ds, dt, 4);
                
                //dataGridView1.DataSource = dt;
                comboBox1.DataSource = dataList;
                comboBox2.DataSource = dataList;

                List<string> dataListLeague = new List<string>();
                dataListLeague = sql.readQueryList(ds, dt, 5);
                leagueNo.DataSource = dataListLeague;

            }
            catch (Exception msg)
            {

                MessageBox.Show(msg.ToString());
                throw;
            }
        }

        private void teamHome_TextChanged(object sender, EventArgs e)
        {

        }

        private void teamAway_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void leagueNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void addResult_Click(object sender, EventArgs e)
        {

            try
            {
                AddValues sql = new AddValues();
                string sqlQuery = String.Format("INSERT INTO matches VALUES ('{0}','{1}', '{2}', {3}, {4}, CURRENT_DATE);",
                    leagueNo.Text, comboBox1.Text, comboBox2.Text, scoreHome.Text, scoreAway.Text);
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

        private void scoreHome_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> dataList = new List<string>();
            dataList = sql.readQueryList(ds, dt, 4);
            dataList.Remove(comboBox1.Text);
            comboBox2.DataSource = dataList;

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void leagueNo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        
    }
}
