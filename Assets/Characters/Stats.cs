using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Stats : MonoBehaviour
{
    private float time = 0.0f;

    bool triggerEntorno = false;

    bool triggerSpike = false;

    float lastTick = 0;

    public float tickDamageTime = 1;

    public int maxHealth = 1000;

    public int health = 1000;

    public static int gold = 0;

    public Image healthBar;

    public Text totalGold;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "gold")
        {
            gold += 1;
            totalGold.text = gold.ToString();
            Destroy(collider.gameObject);
        }
        if (collider.gameObject.tag == "Bomb")
        {
            health -= Random.Range(100, 200);

            Destroy(collider.gameObject);
        }
        if (collider.gameObject.tag == "heal1")
        {
            HealItem("heal1");
            Destroy(collider.gameObject);
        }

        if (collider.gameObject.tag == "Enemy10")
        {
            triggerEntorno = true;
        }
        if (collider.gameObject.tag == "Spike")
        {
            triggerSpike = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Enemy10")
        {
            triggerEntorno = false;
        }
        if (collider.gameObject.tag == "Spike")
        {
            triggerSpike = false;
        }
    }

    void Update()
    {
        healthBar.fillAmount = (float) health / 1000;
        if (triggerEntorno)
        {
            if ((time - lastTick) > tickDamageTime)
            {
                lastTick = time;

                health -= 1;
            }
        }
        if (triggerSpike)
        {
            if ((time - lastTick) > tickDamageTime)
            {
                lastTick = time;

                health -= 5;
            }
        }
        time += Time.deltaTime;

        if (health <= 0)
        {
            SceneManager.LoadScene("Level_GameOver");
        }
    }

    private void HealItem(string healitem)
    {
        if (healitem == "heal1")
        {
            health += Random.Range(10, 50);

            if (health > maxHealth)
            {
                health = maxHealth;
            }
        }
        else
        {
            health += Random.Range(50, 150);
        }
    }
}
