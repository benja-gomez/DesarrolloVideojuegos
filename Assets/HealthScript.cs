using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthScript : MonoBehaviour
{
    public int health;

    public Image healthBar;

    public Bandit player;

    void Start()
    {
        health = player.health;
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log();
        healthBar.fillAmount = (float) player.health / 1000;

        health = player.health;
    }
}
