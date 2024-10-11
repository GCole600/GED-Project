using System;
using UnityEngine;
using UnityEngine.UIElements;

namespace CommandPattern
{
    public class PlayerReceiver : MonoBehaviour
    {
        public float moveSpeed = 5f;
        public float rotationSpeed = 10f;
        private float _xRotation = 0f;
        public float gravity = -30f;
        
        public Transform playerCamera;

        private CharacterController _controller;
        private Vector3 _velocity;
        
        private bool _isGrounded;

        private void Awake()
        {
            _controller = GetComponent<CharacterController>();
            
            if (playerCamera == null)
                playerCamera = Camera.main.transform;
        }

        public void Move(Vector2 direction)
        {
            Vector3 move = transform.right * direction.x + transform.forward * direction.y;

            _controller.Move(move * (moveSpeed * Time.deltaTime));

            // Keep Grounded
            if (_controller.isGrounded && _velocity.y < 0)
                _velocity.y = -2f;

            _velocity.y += gravity * Time.deltaTime;
            _controller.Move(_velocity * Time.deltaTime);
        }

        public void Look(Vector2 lookInput)
        {
            // Horizontal Rotation
            transform.Rotate(Vector3.up * (lookInput.x * rotationSpeed * Time.deltaTime));

            // Vertical Rotation
            _xRotation -= lookInput.y * rotationSpeed * Time.deltaTime;
            _xRotation = Mathf.Clamp(_xRotation, -90f, 90f);

            playerCamera.localRotation = Quaternion.Euler(_xRotation, 0f, 0f);
        }
    }
}