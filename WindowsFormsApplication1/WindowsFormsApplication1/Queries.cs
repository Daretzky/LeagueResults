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
using WindowsFormsApplication1;

namespace WindowsFormsApplication1
{

    public class Queries
    {
        private const string resultsQuery = "SELECT COUNT(*) AS matches_played, " +
                            "player_name, team_name, " +
                            "(SELECT SUM(goals_home) from matches WHERE teams.player_name = matches.team_home) + (SELECT SUM(goals_away) from matches WHERE teams.player_name = matches.team_away) AS strzelone, " +
                            "(SELECT SUM(goals_away) from matches WHERE teams.player_name = matches.team_home) + (SELECT SUM(goals_home) from matches WHERE teams.player_name = matches.team_away) AS stracone, " +
                            "(SELECT COUNT(*) FROM matches WHERE (teams.player_name = matches.team_home AND goals_home > goals_away) OR (teams.player_name = matches.team_away AND goals_away > goals_home)) AS Won, " +
                            "(SELECT COUNT(*) FROM matches WHERE (teams.player_name = matches.team_home AND goals_home < goals_away) OR (teams.player_name = matches.team_away AND goals_away < goals_home)) AS Lost, " +
                            "(SELECT COUNT(*) FROM matches WHERE (teams.player_name = matches.team_home OR teams.player_name = matches.team_away) AND goals_home = goals_away) AS draw, " +
                            "(SELECT (SELECT COUNT(*) FROM matches WHERE (teams.player_name = matches.team_home AND goals_home > goals_away) OR (teams.player_name = matches.team_away AND goals_away > goals_home)) * 3 + " +
                                "(SELECT COUNT(*) FROM matches WHERE ((teams.player_name = matches.team_home OR teams.player_name = matches.team_away) AND goals_home = goals_away)) AS PTS) " +
                            "FROM teams " +
                            "LEFT JOIN matches " +
                            "ON teams.player_name = matches.team_home OR teams.player_name = matches.team_away " +
                            "GROUP BY team_name, player_name " +
                            "ORDER BY pts DESC, strzelone DESC, stracone; ";

        private const string teamsQuery = "SELECT * FROM teams;";
        private const string matchesQuery = "SELECT * FROM matches;";
        private const string teamsList = "SELECT player_name FROM teams;";
        private const string leagueNoList = "SELECT DISTINCT league FROM matches;";


        public DataTable readQuery(DataSet ds, DataTable dt, int queryNo)
        {

            string queryString = "";
            switch (queryNo)
            {
                case 1: queryString = resultsQuery; break;
                case 2: queryString = teamsQuery; break;
                case 3: queryString = matchesQuery; break;
                case 4: queryString = teamsList; break;
                default: queryString = resultsQuery; break;
            }

            try
            {

                string connstring = String.Format("Server=127.0.0.1;Port=5432;" +
                    "User Id=postgres;Password=admin;Database=league;");

                NpgsqlConnection conn = new NpgsqlConnection(connstring);
                conn.Open();

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(queryString, conn);

                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];
                conn.Close();
                return dt;

            }
            catch (Exception msg)
            {

                MessageBox.Show(msg.ToString());
                throw;
            }

        }

        public List<string> readQueryList(DataSet ds, DataTable dt, int queryNo)
        {
            var dataList = new List<string>();
            string queryString = "";
            switch (queryNo)
            {
                case 1: queryString = resultsQuery; break;
                case 2: queryString = teamsQuery; break;
                case 3: queryString = matchesQuery; break;
                case 4: queryString = teamsList; break;
                case 5: queryString = leagueNoList; break;
                default: queryString = resultsQuery; break;
            }

            try
            {

                string connstring = String.Format("Server=127.0.0.1;Port=5432;" +
                    "User Id=postgres;Password=admin;Database=league;");

                NpgsqlConnection conn = new NpgsqlConnection(connstring);
                conn.Open();
                NpgsqlCommand command = new NpgsqlCommand(queryString, conn);

                NpgsqlDataReader dr = command.ExecuteReader();

                while(dr.Read())
                {
                    for(int i=0 ; i < dr.FieldCount; i++)
                    {
                        dataList.Add(dr[i].ToString());             }
                }
               
                conn.Close();
                return dataList;

            }
            catch (Exception msg)
            {

                MessageBox.Show(msg.ToString());
                throw;
            }

        }

    }
}
   