using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level3Script : MonoBehaviour
{
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
