using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    [SerializeField] private float sensitivityX = 8f;
    [SerializeField] private float sensitivityY = 0.5f;
    
    [SerializeField] private Transform playerCamera;
    [SerializeField] private float xClamp = 85f;
    
    private float _mouseX, _mouseY;
    private float _xRotation = 0f;
    
    private void Update()
    {
        transform.Rotate(Vector3.up, _mouseX * Time.deltaTime);

        _xRotation -= _mouseY;
        _xRotation = Mathf.Clamp(_xRotation, -xClamp, xClamp);
        Vector3 targetRotation = transform.eulerAngles;
        targetRotation.x = _xRotation;
        playerCamera.eulerAngles = targetRotation;
    }

    public void ReceiveInput(Vector2 mouseInput)
    {
        _mouseX = mouseInput.x * sensitivityX;
        _mouseY = mouseInput.y * sensitivityY;
    }
}
