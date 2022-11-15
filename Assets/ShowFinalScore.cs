using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowFinalScore : MonoBehaviour
{
    public Text scoreFinal;

    void Start()
    {
        scoreFinal.text =
            string.Format("ORO TOTAL: {0}", Stats.gold.ToString());
        LeaderboardScript.SaveScore();
        
    }

    // Update is called once per frame
    void Update()
    {
    }
}
