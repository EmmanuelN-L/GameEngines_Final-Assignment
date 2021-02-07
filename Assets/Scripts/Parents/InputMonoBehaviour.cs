using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputMonoBehaviour : MonoBehaviour
{

    protected GameInputActions GameInput;


    protected void Awake()
    {
        GameInput = new GameInputActions();
    }

    protected void OnEnable()
    {
        GameInput.Enable();
    }

    protected void OnDisable()
    {
        GameInput.Disable();

    }
}
