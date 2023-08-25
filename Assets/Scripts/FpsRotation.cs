using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class FpsRotation : MonoBehaviour
{
    //private Vector2 touchStartPos;
    //private float rotationSpeed = 1.0f;

    //void Update()
    //{


    //    //if (Input.touchCount > 0)
    //    //{
    //    //    Touch touch = Input.GetTouch(0);

    //    //    if (touch.phase == UnityEngine.TouchPhase.Began)
    //    //    {
    //    //        touchStartPos = touch.position;
    //    //    }
    //    //    else if (touch.phase == UnityEngine.TouchPhase.Moved)
    //    //    {
    //    //        Vector2 deltaTouchPos = touch.position - touchStartPos;
    //    //        float rotationAmount = deltaTouchPos.x * rotationSpeed;

    //    //        transform.Rotate(Vector3.up, rotationAmount, Space.World);

    //    //        touchStartPos = touch.position;
    //    //    }
    //    //}
    //}

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
        

            transform.Rotate(Vector3.up, rotationAmount, Space.World);

            lastMousePosition = currentMousePosition;
        }
    }


}
