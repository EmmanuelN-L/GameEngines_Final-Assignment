using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    public float stoppingDistance;
    public float retreatDistance;

    public GameObject projectile;
    private float timeBtweenShots;
    public float startTimeBtweenshots;
    public Transform BulletSpawn;
    public float health;

    public GameObject key;

    private Transform player;
    private float positionY;   

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        Debug.Log(player.name);
        positionY = transform.position.y;
        health = 200;
    }
    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player);

        if(Vector3.Distance(transform.position, player.position) > stoppingDistance)
        {
            transform.position = Vector3.MoveTowards(new Vector3(transform.position.x, positionY, transform.position.z), player.position, speed * Time.deltaTime);
        }
        else if(Vector3.Distance(transform.position, player.position) < stoppingDistance 
            && Vector3.Distance(transform.position, player.position) > retreatDistance)
        {
            transform.position = this.transform.position;
        }
        else if(Vector3.Distance(transform.position, player.position) < retreatDistance)
        {
            transform.position = Vector3.MoveTowards(new Vector3(transform.position.x, positionY, transform.position.z), player.position, -speed * Time.deltaTime);
        }


        if(timeBtweenShots <= 0)
        {
            Instantiate(projectile, new Vector3(BulletSpawn.position.x, BulletSpawn.position.y, BulletSpawn.position.z),transform.rotation * Quaternion.Euler(90,45,0));
            timeBtweenShots = startTimeBtweenshots;
        }
        else
        {
            timeBtweenShots -= Time.deltaTime;
        }

    }
    public void defeated()
    {
        Debug.Log("I'm defeated ");
        Instantiate(key, new Vector3(transform.position.x, transform.position.y + 3, transform.position.z), Quaternion.identity);
        Destroy(gameObject);
    }
}
