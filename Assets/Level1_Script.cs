using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1_Script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject
            .FindGameObjectWithTag("Music")
            .GetComponent<MusicClassHome>()
            .StopMusic();

    }

    // Update is called once per frame
    void Update()
    {
    }
}
