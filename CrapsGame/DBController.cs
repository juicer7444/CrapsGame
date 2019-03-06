using System;
using System.Collections.Generic;
using Dapper;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Data;

namespace CrapsGame
{
    // controller for SQL DB calls
    public static class DBController
    {

        /* 
         * In this controller I use direct SQL queries, 
         * but I do know better practice is to use stored procedures.
         */ 

        //returns all players as a list of strings from database
        public static List<Player> getPlayers()
        {
            using (IDbConnection connection = new SqlConnection(cnnVal("CrapsDB")))
            {
                return connection.Query<Player>(" use CrapsDB select * from Players").ToList();
            }
        }

        public static Player getPlayer(string playerId)
        {
            using (IDbConnection connection = new SqlConnection(cnnVal("CrapsDB")))
            {
                return connection.Query<Player>($"use CrapsDB select * from Players where playerID = '{ playerId }'").Single();
            }
        }

        // Creates new player into database
        public static void CreatePlayer(string playerName)
        {
            using (IDbConnection connection = new SqlConnection(cnnVal("CrapsDB")))
            {
                connection.Query<Player>($"USE CrapsDB INSERT Players (playerID, playerName) VALUES (NewID(), '{ playerName }')");
            }
        }

        // returns Player object based off of given player name
        public static Player getPlayerByName(string playerName)
        {
            using (IDbConnection connection = new SqlConnection(cnnVal("CrapsDB")))
            {
                return connection.Query<Player>($"USE CrapsDB SELECT * FROM Players WHERE playerName = '{ playerName }'").Single();
            }
        }

        // Edits a player and saves to database
        public static void EditPlayer(string playerId, string playerName)
        {
            using (IDbConnection connection = new SqlConnection(cnnVal("CrapsDB")))
            {
                connection.Query<Player>($"USE CrapsDB UPDATE dbo.Players SET PlayerName = '{ playerName }' WHERE playerID = '{ playerId}'");
            }
        }

        // Deletes specified player from database
        public static void DeletePlayer(string playerId)
        {
            using (IDbConnection connection = new SqlConnection(cnnVal("CrapsDB")))
            {
                connection.Query<Player>($"USE CrapsDB DELETE FROM Players WHERE playerID = '{ playerId }'");
            }
        }

        // returns all rounds for the specified player from database
        public static List<Round> GetRounds(string playerId)
        {
            using (IDbConnection connection = new SqlConnection(cnnVal("CrapsDB")))
            {
                return connection.Query<Round>($"use CrapsDB select * from Rounds WHERE playerID = '{ playerId }' ORDER BY RoundID").ToList();
            }
        }

        // clears all rounds for current player
        public static void ClearRound(string playerId)
        {
            using (IDbConnection connection = new SqlConnection(cnnVal("CrapsDB")))
            {
                connection.Query<Round>($"use CrapsDB DELETE FROM Rounds WHERE playerID = '{ playerId }'");
            }
        }

        // adds round to specified player into database
        public static void AddRound(Round round)
        {
            using (IDbConnection connection = new SqlConnection(cnnVal("CrapsDB")))
            {
                connection.Query<Round>($"USE CrapsDB INSERT Rounds (RoundTotal, RoundPoint, RoundResult, PlayerID) VALUES ('{ round.RoundTotal }', '{ round.RoundPoint }', '{ round.RoundResult }', '{ round.PlayerID }')");
            }
        }

        // grabs SQL connection string from App.config
        public static string cnnVal(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
