using System;
using System.Collections;
using System.Collections.Generic;
using Chapter.Singleton;
using UnityEditor;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] CharacterController controller;
    [SerializeField] float speed = 11f;
    [SerializeField] float jumpHeight = 3.5f;
    [SerializeField] float gravity = -30f;
    
    private Vector2 _horizontalInput;
    private Vector3 _verticalVelocity = Vector3.zero;

    private bool _jump;
    private bool _isGrounded;
    
    private void Update()
    {
        _isGrounded = controller.isGrounded;

        if (_isGrounded) { _verticalVelocity.y = 0; }

        Vector3 horizontalVelocity =
            (transform.right * _horizontalInput.x + transform.forward * _horizontalInput.y) * speed;
        controller.Move(horizontalVelocity * Time.deltaTime);

        if (_jump && _isGrounded)
        {
            _verticalVelocity.y = Mathf.Sqrt(-2f * jumpHeight * gravity);
            _jump = false;
        }
        
        _verticalVelocity.y += gravity * Time.deltaTime;
        controller.Move(_verticalVelocity * Time.deltaTime);
    }

    public void OnJumpPressed()
    {
        _jump = true;
    }

    public void ReceiveInput(Vector2 horizontalInput)
    {
        this._horizontalInput = horizontalInput;
    }
}
