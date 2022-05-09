using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterController))]
[RequireComponent(typeof(PlayerInput))]

public class RuntimeMovement : MonoBehaviour
{
    private movement _input;
    private CharacterController _controler;
    [SerializeField] private float fraction;
    // Start is called before the first frame update
    private void Start()
    {
        _controler = GetComponent<CharacterController>();
        _input = GetComponent<movement>();
    }

    // Update is called once per frame
    private void Update()
    {
        Move();   
    }

    private void Move()
    {
        _controler.Move(new Vector3((_input.moveVal.x*_input.moveSpeed)/fraction,0f,(_input.moveVal.y*_input.moveSpeed)/fraction));
    }
}
