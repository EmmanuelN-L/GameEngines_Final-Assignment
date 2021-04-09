using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverFunctionality : MonoBehaviour
{
    //Lever
    public bool isLeverUp = false;
    public float Rotation_Speed;
    public float Rotation_Friction; //The smaller the value, the more Friction there is. [Keep this at 1 unless you know what you are doing].
    public float Rotation_Smoothness; //Believe it or not, adjusting this before anything else is the best way to go.
   
    private Quaternion Quaternion_Rotate_From;
    private Quaternion Quaternion_Rotate_To;

    //MovingPlatform
    public GameObject movingPlatform;
    public Vector3 MoveLocation;
    private Vector3 OriginalLocation;
    public bool move = false;
    public float movementSpeed;
    public float moveX;
    public float moveY;
    public float moveZ;


    Character.MovementComponent playerControls;
    private void Start()
    {
        OriginalLocation = movingPlatform.transform.position;
        MoveLocation = new Vector3(OriginalLocation.x + moveX, OriginalLocation.y + moveY, OriginalLocation.z + moveZ);
        //transform.localRotation.eulerAngles.y = 0f;
        Debug.Log(transform.localRotation.eulerAngles.y);

    }

    // Update is called once per frame
    private void Update()
    {
        rotateUp(isLeverUp);

        if (move)
        {
            movingPlatform.transform.position = Vector3.Lerp(movingPlatform.transform.position, MoveLocation, movementSpeed * Time.deltaTime);
            Debug.Log("UP");
        }
        else
        {
            movingPlatform.transform.position = Vector3.Lerp(movingPlatform.transform.position, OriginalLocation, movementSpeed * Time.deltaTime);
            Debug.Log("down");
        }
    }

    public void rotateUp(bool up)
    {
        if (up)
        {
            Quaternion_Rotate_From = transform.localRotation;
            Quaternion_Rotate_To = Quaternion.Euler(-90, transform.localRotation.y, transform.localRotation.z);

            transform.localRotation = Quaternion.Lerp(Quaternion_Rotate_From, Quaternion_Rotate_To, Time.deltaTime * Rotation_Smoothness);
            move = true;
        }
        else
        {
            Quaternion_Rotate_From = transform.localRotation;


            Quaternion_Rotate_To = Quaternion.Euler(0, transform.localRotation.y, transform.localRotation.z);

            transform.localRotation = Quaternion.Lerp(Quaternion_Rotate_From, Quaternion_Rotate_To, Time.deltaTime * Rotation_Smoothness);
            move = false;
        }
    }

    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.tag =="Player")
    //    {
    //        Debug.Log("Press E");
    //        playerControls.Lever = gameObject;
    //        playerControls.lever = gameObject.GetComponent<LeverFunctionality>();
    //    }
    //}

    //private void OnTriggerExit(Collider other)
    //{
    //    if (other.tag == "Player")
    //    {
    //        Debug.Log("Exiting");
    //        playerControls.Lever = gameObject;
    //        playerControls.lever = gameObject.GetComponent<LeverFunctionality>();
    //    }
    //}
}

