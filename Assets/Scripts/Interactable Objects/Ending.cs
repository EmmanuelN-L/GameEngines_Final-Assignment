using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ending : MonoBehaviour
{
    public bool hasKey = false;
    public void OnEnding()
    {
        if (hasKey)
        {
            if (!GameManager.Instance.CursorActive)
            {
                AppEvents.Invoke_OnMouseCursorEnable(true);
            }
            Time.timeScale = 1;
            SceneManager.LoadScene("End");
        }
        else
        {
            Debug.Log("No Key");
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            OnEnding();
        }
    }
}
