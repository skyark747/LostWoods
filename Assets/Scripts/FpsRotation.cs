using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class FpsRotation : MonoBehaviour
{
    private Vector3 lastMousePosition;
    public float rotationSpeed = 1.0f;

    void Update()
    {
        Vector3 currentMousePosition = Input.mousePosition;

        if (Input.GetMouseButtonDown(0))
        {
            lastMousePosition = currentMousePosition;
        }
        else if (Input.GetMouseButton(0))
        {
            Vector3 deltaMousePos = currentMousePosition - lastMousePosition;
            float rotationAmount = deltaMousePos.x * rotationSpeed;

            // Rotate the player around the up axis
            transform.Rotate(Vector3.up, rotationAmount, Space.World);

            lastMousePosition = currentMousePosition;
        }
    }
}
