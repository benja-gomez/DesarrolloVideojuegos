using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGameOverScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (
            GameObject
                .FindGameObjectWithTag("Music")
                .GetComponent<MusicClassHome>() !=
            null
        )
        {
            GameObject
                .FindGameObjectWithTag("Music")
                .GetComponent<MusicClassHome>()
                .StopMusic();
        }
        if (
            GameObject
                .FindGameObjectWithTag("Music")
                .GetComponent<MusicClassGame>() !=
            null
        )
        {
            GameObject
                .FindGameObjectWithTag("Music")
                .GetComponent<MusicClassGame>()
                .StopMusic();
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
