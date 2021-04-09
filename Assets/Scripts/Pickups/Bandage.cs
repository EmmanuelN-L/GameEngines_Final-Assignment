using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Bandage : MonoBehaviour
{
    public Shop shop;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {

            shop.setBandages(1);
            Destroy(this.gameObject);

        }
    }
}
