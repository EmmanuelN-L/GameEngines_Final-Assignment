using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AK47Bullet : MonoBehaviour
{

    public float speed;
    public float timeRemaining = 5;

    private Transform player;
    private Vector3 target;
    public float damage = 6;
    private UI_Script playerStats;
    float distance;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        playerStats = GameObject.FindGameObjectWithTag("HealthBar").GetComponent<UI_Script>();

        target = new Vector3(player.position.x, player.position.y, player.position.z);
        transform.LookAt(player);
        transform.rotation *= Quaternion.Euler(90, 0, 0);
        distance = Vector3.Distance(target, transform.position);
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(target.x, target.y + 1, target.z), speed * Time.deltaTime);
        
        if(timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }
        else
        {
            DestroyProjectile();
        }
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Debug.Log("Ow");
            playerStats.SetHealth(-6);
            DestroyProjectile();
        }
        else
        {
            DestroyProjectile();
        }
    }
    void DestroyProjectile()
    {
        Destroy(gameObject);
    }

}
