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
    public partial class Form1 : Form
    {
        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable();

        Queries sql = new Queries();

        public Form1()
        {
            InitializeComponent();
           

        }
        
        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void wynikiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void wynikiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                dt = sql.readQuery(ds, dt, 1);
                dataGridView1.DataSource = dt;
            }
            catch (Exception msg)
            {
                
                MessageBox.Show(msg.ToString());
                throw;
            }
        }

        private void meczeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                dt = sql.readQuery(ds, dt, 3);
                dataGridView1.DataSource = dt;
            }
            catch (Exception msg)
            {

                MessageBox.Show(msg.ToString());
                throw;
            }
        }

        private void druzynyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                dt = sql.readQuery(ds, dt, 2);
                dataGridView1.DataSource = dt;

            }
            catch (Exception msg)
            {

                MessageBox.Show(msg.ToString());
                throw;
            }
        }


        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void addMatchResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dodaj_wynik dodaj_wynik = new dodaj_wynik();
            dodaj_wynik.Show();
        }

        private void addPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTeam dodaj_wynik = new AddTeam();
            dodaj_wynik.Show();
        }

        private void addLeagueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateLeague createLeague = new CreateLeague();
            createLeague.Show();
        }
    }
}
