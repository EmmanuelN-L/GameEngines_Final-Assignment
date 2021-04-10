using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieFunc : MonoBehaviour
{
    public float health = 100f;
    private UI_Script playerStats;

    public void onTakeDamage(float damage)
    {
        health -= damage;
        if(health <=0)
        {
            playerStats = GameObject.FindGameObjectWithTag("HealthBar").GetComponent<UI_Script>();
            playerStats.setMoney(100);
            Destroy(gameObject);
        }
    }
}
