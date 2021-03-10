using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{

    public Vector3 MoveLocation;
    private Vector3 OriginalLocation;
    public bool move = false;
    public float movementSpeed;
    public float moveX;
    public float moveY;
    public float moveZ;
    private Vector3 currentPosition;

    private void Start()
    {
        OriginalLocation = transform.position;
        MoveLocation = new Vector3(OriginalLocation.x + moveX, OriginalLocation.y + moveY, OriginalLocation.z + moveZ);  

    }

    void Update()
    {
        
        if(move)
        {
            transform.position = Vector3.Lerp(transform.position, MoveLocation, movementSpeed * Time.deltaTime);
        }
        else
        {
            transform.position = Vector3.Lerp(transform.position, OriginalLocation, movementSpeed * Time.deltaTime);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.collider.transform.SetParent(transform);
        }
    }
}
