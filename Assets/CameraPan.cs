using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPan : MonoBehaviour
{
    Vector3 touchstart;
    [SerializeField] private Camera cam;
    public float speed=0.01f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
        if (Input.touchCount>0 && Input.GetTouch(0).phase==TouchPhase.Moved)
        {
            Vector2 direction = Input.GetTouch(0).deltaPosition;
           transform.Translate(-direction.x*speed,-direction.y*speed,0);

            transform.position=new Vector3(Mathf.Clamp(transform.position.x,-40f,40f), Mathf.Clamp(transform.position.y, 0f, 0f),
            Mathf.Clamp(transform.position.z, -25f, 25f));
        }

    }
}
