using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Sellers : MonoBehaviour
{
    public TMP_Text feedback;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            feedback.text = "Press M to talk";

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            feedback.text = null;
        }
    }
}
