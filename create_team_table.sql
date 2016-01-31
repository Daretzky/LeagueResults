CREATE TABLE teams
(
	team_name VARCHAR(80) NOT NULL,
	player_name VARCHAR(80) PRIMARY KEY,
	seasons_won INT,
	seasons_played INT
		
);

CREATE TABLE matches
(	league VARCHAR(10),
	team_home VARCHAR(80) NOT NULL,
	team_away VARCHAR(80) NOT NULL,
	goals_home INT,
	goals_away INT,
	date DATE
		
);