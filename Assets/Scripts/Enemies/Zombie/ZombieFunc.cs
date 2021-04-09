using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieFunc : MonoBehaviour
{
    public float health = 100f;

    public void onTakeDamage(float damage)
    {
        health -= damage;
        if(health <=0)
        {
            Destroy(gameObject);
        }
    }
}
