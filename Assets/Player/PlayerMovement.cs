using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] CharacterController controller;
    [SerializeField] float speed = 11f;
    [SerializeField] float jumpHeight = 3.5f;
    [SerializeField] float gravity = -30f;
    
    private Vector2 horizontalInput;
    private Vector3 verticalVelocity = Vector3.zero;

    private bool jump;
    private bool isGrounded;
    
    private void Update()
    {
        isGrounded = controller.isGrounded;

        if (isGrounded) { verticalVelocity.y = 0; }

        Vector3 horizontalVelocity =
            (transform.right * horizontalInput.x + transform.forward * horizontalInput.y) * speed;
        controller.Move(horizontalVelocity * Time.deltaTime);

        if (jump && isGrounded)
        {
            verticalVelocity.y = Mathf.Sqrt(-2f * jumpHeight * gravity);
            jump = false;
        }
        
        verticalVelocity.y += gravity * Time.deltaTime;
        controller.Move(verticalVelocity * Time.deltaTime);
    }

    public void OnJumpPressed()
    {
        jump = true;
    }

    public void ReceiveInput(Vector2 _horizontalInput)
    {
        horizontalInput = _horizontalInput;
    }
}
