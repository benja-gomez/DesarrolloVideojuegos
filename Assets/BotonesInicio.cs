using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BotonesInicio : MonoBehaviour
{
    public Button yourButton;

    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener (TaskOnClick);
    }

    void TaskOnClick()
    {
        Debug.Log("You have clicked the button!");
        Cambiar();
    }

    public void Cambiar()
    {
        SceneManager.LoadScene("Level_01_GameScene_0");
    }
}
