using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BotonesInicio : MonoBehaviour
{
    public Button botonIniciar;

    public Button botonLeaderboard;

    void Start()
    {
        Button btnIniciar = botonIniciar.GetComponent<Button>();
        Button btnLeaderboard = botonLeaderboard.GetComponent<Button>();
        btnIniciar.onClick.AddListener (goInicio);
        btnLeaderboard.onClick.AddListener (goLeaderboard);
    }

    void goInicio()
    {
        SceneManager.LoadScene("Level_00_PersonalData");
    }

    void goLeaderboard()
    {
        SceneManager.LoadScene("Level_99_Leaderboard");
    }
}
