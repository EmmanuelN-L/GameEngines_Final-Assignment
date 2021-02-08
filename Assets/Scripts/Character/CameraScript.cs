using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraScript : MonoBehaviour
{

    [SerializeField] private float RotationSpeed = 1;
    [SerializeField] private float HorizontalDamping = 1;
    [SerializeField] private GameObject FollowTarget;

    private Transform FollowTargetTransform;

    private Vector2 PreviousMouseInput;

    // Start is called before the first frame update
    private void Start()
    {
        FollowTargetTransform = FollowTarget.transform;
        PreviousMouseInput = Vector2.zero;
    }

    public void OnLook(InputValue delta)
    {
        Vector2 aimValue = delta.Get<Vector2>();

        FollowTargetTransform.rotation *=
            Quaternion.AngleAxis(
                Mathf.Lerp(PreviousMouseInput.x, aimValue.x, 1f / HorizontalDamping) * RotationSpeed,
                transform.up
            );

        transform.rotation = Quaternion.Euler(0, FollowTargetTransform.transform.rotation.eulerAngles.y, 0);

        FollowTargetTransform.localEulerAngles = Vector3.zero;

        PreviousMouseInput = aimValue;
    }
}

