using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverFunctionality : MonoBehaviour
{

    public bool isLeverUp = false;
    public float Rotation_Speed;
    public float Rotation_Friction; //The smaller the value, the more Friction there is. [Keep this at 1 unless you know what you are doing].
    public float Rotation_Smoothness; //Believe it or not, adjusting this before anything else is the best way to go.

    private Quaternion Quaternion_Rotate_From;
    private Quaternion Quaternion_Rotate_To;

    // Update is called once per frame
    private void Update()
    {
        rotateUp(isLeverUp);
    }
    public void rotateUp(bool down)
    {
        if (down)
        {
            Quaternion_Rotate_From = transform.rotation;
            Quaternion_Rotate_To = Quaternion.Euler(-90, transform.rotation.y, transform.rotation.z);

            transform.rotation = Quaternion.Lerp(Quaternion_Rotate_From, Quaternion_Rotate_To, Time.deltaTime * Rotation_Smoothness);
        }
        else
        {
            Quaternion_Rotate_From = transform.rotation;
            Quaternion_Rotate_To = Quaternion.Euler(0, transform.rotation.y, transform.rotation.z);

            transform.rotation = Quaternion.Lerp(Quaternion_Rotate_From, Quaternion_Rotate_To, Time.deltaTime * Rotation_Smoothness);
        }
    }
}

