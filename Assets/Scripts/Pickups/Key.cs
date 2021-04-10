using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public Ending end;
    private UI_Script playerStats;
    public void Start()
    {
        playerStats = GameObject.FindGameObjectWithTag("HealthBar").GetComponent<UI_Script>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            playerStats.setMoney(500);
            end.hasKey = true;
            Destroy(this.gameObject);

        }
    }
}
