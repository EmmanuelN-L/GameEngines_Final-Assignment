using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CrosshairScript : InputMonoBehaviour
{
    public Vector2 MouseSensitivity;
    public bool Inverted = false;

    public Vector2 CurrentAimPosition { get; private set; }

    [SerializeField, Range(0, 1)]
    private float CrosshairHorizontalPercentage = 0.25f;

    private float HorizontalOffset;
    private float MaxHorizontalConstrainValue;
    private float MinHorizontalConstrainValue;

    [SerializeField, Range(0, 1)]
    private float CrosshairVerticalPercentage = 0.25f;

    private float VerticalOffset;
    private float MaxVerticalConstrainValue;
    private float MinVerticalConstrainValue;


    private Vector2 CrosshairStartingPosition;
    private Vector2 CurrentLookDelta;



    // Start is called before the first frame update
    void Start()
    {
        if(GameManager.Instance.CursorActive)
        {
            AppEvents.Invoke_OnMouseCursorEnable(false);
        }

        CrosshairStartingPosition = new Vector2(Screen.width / 2f, Screen.height / 2f);

        HorizontalOffset = (Screen.width * CrosshairHorizontalPercentage) / 2;
        MinHorizontalConstrainValue = -(Screen.width / 2f) + HorizontalOffset;
        MaxHorizontalConstrainValue = (Screen.width / 2f) - HorizontalOffset;

        VerticalOffset = (Screen.height * CrosshairHorizontalPercentage) / 2f;
        MinVerticalConstrainValue = -(Screen.height / 2f) + VerticalOffset;
        MaxVerticalConstrainValue = (Screen.height / 2f) - VerticalOffset;


    }

    private void OnLook(InputAction.CallbackContext delta)
    {
        Vector2 mouseDelta = delta.ReadValue<Vector2>();

        CurrentLookDelta.x += mouseDelta.x * MouseSensitivity.x;
        if (CurrentLookDelta.x >= MaxHorizontalConstrainValue || CurrentLookDelta.x <= MinHorizontalConstrainValue)
        {
            CurrentLookDelta.x -= mouseDelta.x * MouseSensitivity.x;
        }

        CurrentLookDelta.y += mouseDelta.y * MouseSensitivity.y;
        if (CurrentLookDelta.y >= MaxVerticalConstrainValue || CurrentLookDelta.y <= MinVerticalConstrainValue)
        {
            CurrentLookDelta.y -= mouseDelta.y * MouseSensitivity.y;
        }
    }
    // Update is called once per frame
    private void Update()
    {
        float crosshairXPosition = CrosshairStartingPosition.x + CurrentLookDelta.x;
        float crosshairYPosition = Inverted
            ? CrosshairStartingPosition.y - CurrentLookDelta.y
            : CrosshairStartingPosition.y + CurrentLookDelta.y;

        CurrentAimPosition = new Vector2(crosshairXPosition, crosshairYPosition);

        transform.position = CurrentAimPosition;
    }

    private new void OnEnable()
    {
        base.OnEnable();
        GameInput.ThirdPerson.Look.performed += OnLook;
    }

    

    private new void OnDisable()
    {
        base.OnDisable();
        GameInput.ThirdPerson.Look.performed -= OnLook;
    }
}
