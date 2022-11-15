using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2Script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (GameObject.FindGameObjectWithTag("Music") != null)
        {
            GameObject
                .FindGameObjectWithTag("Music")
                .GetComponent<MusicClassGame>()
                .PlayMusic();
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
