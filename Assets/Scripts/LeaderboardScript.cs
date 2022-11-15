using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Web;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LeaderboardScript : MonoBehaviour
{
    public Text leaderBoardname;

    public Text leaderBoardscore;

    public Button botonIniciar;

    private const string leaderBoardFile = "leaderBoardFile.txt";

    [Serializable]
    public class PlayerLog
    {
        public string username;

        public int score;
    }

    public class Board
    {
        public List<PlayerLog> players;

        public Board()
        {
            players = new List<PlayerLog>();
        }
    }

    public static void SaveScore()
    {
        if (Bandit.username.Length > 0)
        {
            PlayerLog nuevoPlayer = new PlayerLog();
            var jsonString = File.ReadAllText(leaderBoardFile);
            var leaderboard = JsonUtility.FromJson<Board>(jsonString);
            nuevoPlayer.username = Bandit.username;
            nuevoPlayer.score = Stats.gold;
            leaderboard.players.Add (nuevoPlayer);

            var saveString = JsonUtility.ToJson(leaderboard, true);
            File.WriteAllText (leaderBoardFile, saveString);
        }
    }

    void goInicio()
    {
        SceneManager.LoadScene("Level_00_PersonalData");
    }

    void Start()
    {
        Button btnIniciar = botonIniciar.GetComponent<Button>();
        btnIniciar.onClick.AddListener (goInicio);
        if (
            File.Exists(leaderBoardFile) // 9
        )
        {
            var jsonString = File.ReadAllText(leaderBoardFile);
            var leaderboard = JsonUtility.FromJson<Board>(jsonString);
            leaderboard.players =
                leaderboard.players.OrderBy(o => o.score).ToList();
            int index = 1;
            foreach (var
                player
                in
                leaderboard.players.OrderByDescending(o => o.score).ToList()
            )
            {
                if (index <= 10)
                {
                    leaderBoardname.text +=
                        "\n " + index + "  " + player.username.ToString();
                    leaderBoardscore.text += "\n" + player.score.ToString();
                    index++;
                }

                Debug.Log (index);
            }
        }

        // Board jugadores = new Board();
        // PlayerLog nuevoPlayer = new PlayerLog();
        // PlayerLog nuevoPlayer1 = new PlayerLog();
        // nuevoPlayer.username = "Benja";
        // jugadores.players.Add (nuevoPlayer);
        // nuevoPlayer1.username = "Ostap";
        // jugadores.players.Add (nuevoPlayer1);

        // var jsonString = JsonUtility.ToJson(jugadores, true);
        // File.WriteAllText (leaderBoardFile, jsonString);
    }
}
