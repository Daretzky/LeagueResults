SELECT COUNT(*) AS matches_played,
player_name, team_name, 
(SELECT SUM(goals_home) from matches WHERE teams.player_name = matches.team_home) + (SELECT SUM(goals_away) from matches WHERE teams.player_name = matches.team_away) AS strzelone,
(SELECT SUM(goals_away) from matches WHERE teams.player_name = matches.team_home) + (SELECT SUM(goals_home) from matches WHERE teams.player_name = matches.team_away) AS stracone,
(SELECT COUNT(*) FROM matches WHERE (teams.player_name = matches.team_home AND goals_home > goals_away) OR (teams.player_name = matches.team_away AND goals_away > goals_home)) AS Won,
(SELECT COUNT(*) FROM matches WHERE (teams.player_name = matches.team_home AND goals_home < goals_away) OR (teams.player_name = matches.team_away AND goals_away < goals_home)) AS Lost,
(SELECT COUNT(*) FROM matches WHERE (teams.player_name = matches.team_home OR teams.player_name = matches.team_away) AND goals_home = goals_away) AS draw,
(SELECT (SELECT COUNT(*) FROM matches WHERE (teams.player_name = matches.team_home AND goals_home > goals_away) OR (teams.player_name = matches.team_away AND goals_away > goals_home)) * 3 + 
	(SELECT COUNT(*) FROM matches WHERE ((teams.player_name = matches.team_home OR teams.player_name = matches.team_away) AND goals_home = goals_away)) AS PTS)
FROM teams
LEFT JOIN matches
ON teams.player_name = matches.team_home OR teams.player_name = matches.team_away
WHERE matches.league = 'I' 
GROUP BY player_name, team_name
ORDER BY pts DESC, strzelone DESC, stracone;