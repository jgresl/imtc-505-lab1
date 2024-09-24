using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Mover : MonoBehaviour
{
    private Vector3 currentPosition;
    private Vector3 newPosition;
    private float inputX;
    public InputAction playerMovement;
    Vector3 moveDirection = Vector3.zero;


    private void OnEnable()
    {
        playerMovement.Enable();
    }

    private void OnDisable()
    {
        playerMovement.Disable();
    }

    // Update is called once per frame
    void Update()
    {
        moveDirection = playerMovement.ReadValue<Vector2>();
        Debug.Log(inputX);
        //transform.position = currentPosition + moveDirection;
        Debug.Log(transform.position);
    }
}
