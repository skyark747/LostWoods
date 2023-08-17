using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthFaceCamera : MonoBehaviour
{
    [SerializeField] Transform cam;
    void LateUpdate()
    {
        transform.LookAt(cam);
    }
}
