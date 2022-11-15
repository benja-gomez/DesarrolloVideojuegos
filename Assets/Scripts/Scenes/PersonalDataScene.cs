using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PersonalDataScene : MonoBehaviour
{
    public Button botonStart;

    public InputField userName;

    public Text warningMessage;

    void Start()
    {
        Stats.gold = 0;
        if (Bandit.username.Length > 0)
        {
            userName.text = Bandit.username;
        }
        Button btnStart = botonStart.GetComponent<Button>();

        btnStart.onClick.AddListener (goStart);
    }

    void goStart()
    {
        if (userName.text.Length < 1)
        {
            warningMessage.text = "Porfavor ingrese su nombre";
        }
        else
        {
            Bandit.username = userName.text;
            SceneManager.LoadScene("Level_01_GameScene_0");
        }
    }
}
