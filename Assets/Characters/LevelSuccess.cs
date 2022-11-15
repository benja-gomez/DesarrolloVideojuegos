using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelSuccess : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "LevelSuccess")
        {
            SceneManager
                .LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            Debug.Log("Awake:" + SceneManager.GetActiveScene().name);
        }
    }
}
