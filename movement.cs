using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class movement : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody capsule;
    public Vector2 moveVal;
    public float moveSpeed = 10;

    private void Awake()
    {
        capsule = GetComponent<Rigidbody>();
    }
    public void Moving(InputAction.CallbackContext value)
    {
        if (value.performed)
        {
            moveVal = value.ReadValue<Vector2>();
            //capsule.AddForce(new Vector3(moveVal.x * moveSpeed, 0f, moveVal.y * moveSpeed), ForceMode.Impulse);
        }
        if (value.canceled)
        {
            moveVal = value.ReadValue<Vector2>();
            //capsule.AddForce(new Vector3(moveVal.x * moveSpeed, 0f, moveVal.y * moveSpeed), ForceMode.Impulse);
        }
    }
}
