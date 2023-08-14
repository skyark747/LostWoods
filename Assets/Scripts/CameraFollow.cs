using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Vector3 set;
    public float x = 41, y = 40;
    [SerializeField] Transform target;
   
    void Start()
    {
        set = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(target.position.x+set.x-x,set.y,target.position.z+set.z-y);

    }
}
