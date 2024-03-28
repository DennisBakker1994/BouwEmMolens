using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class DefaultMovement : MonoBehaviour
{
    public CharacterController player;

   [SerializeField] PlayerInput playerInput;

    public float _upAndDown;

    public void up()
    {
        print("ik werk!");
        transform.position += new Vector3(0, 0.5f, 0);
    }

    private void OnEnable()
    {
        playerInput.actions.FindAction("NewUp").started += UpAndDown;
        playerInput.actions.FindAction("NewUp").performed += UpAndDown;
        playerInput.actions.FindAction("NewUp").canceled += UpAndDown;
    }

    private void UpAndDown(InputAction.CallbackContext context)
    {
        Debug.Log("button" + context.ReadValue<float>());
        _upAndDown = context.ReadValue<float>();
    }


}
