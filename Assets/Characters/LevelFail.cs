using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelFail : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "LevelFail")
        {
            SceneManager.LoadScene("Level_GameOver");
        }
    }
}
