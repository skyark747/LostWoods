using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunLaser : MonoBehaviour
{
    private LineRenderer lr;
    public float Pos = 100f;
    void Start()
    {
        lr=GetComponent<LineRenderer>();
    }

    
    void Update()
    {
        lr.SetPosition(0,transform.position);
        RaycastHit hit;
        if(Physics.Raycast(transform.position,transform.forward,out hit,0.5f))
        {
            if(hit.collider)
            {
                lr.SetPosition(1, hit.point);
            }
        }
        lr.SetPosition(1, transform.forward*Pos);
        
    }
}
