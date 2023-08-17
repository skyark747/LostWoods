using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotRoam : MonoBehaviour
{
    [SerializeField] private Transform startPoint;
    [SerializeField] private Transform endPoint;
    [SerializeField] private float speed = 2f;
    [SerializeField] private float delayTime = 1f;
    public Animator anim;
    public Transform Player;

    private float currentLerpTime = 0f;
    private float journeyLength;
    private bool isMoving = true;
    private bool isDelaying = false;
    private float delayTimer = 0f;

    private void Start()
    {
        journeyLength = Vector3.Distance(startPoint.position, endPoint.position);
    }

    private void Update()
    {
        if (FindAnyObjectByType<BotMovement>().isCollided==false)
        {
            if (isMoving)
            {
                currentLerpTime += Time.deltaTime * speed;

                if (currentLerpTime > 1f)
                {
                    // Swap start and end points to move the platform back and forth
                    Transform temp = startPoint;
                    startPoint = endPoint;
                    endPoint = temp;
                    currentLerpTime = 0f;
                    isMoving = false;
                    isDelaying = true;
                    delayTimer = 0f;
                }

                float percentage = currentLerpTime / 1f;
                transform.position = Vector3.Lerp(startPoint.position, endPoint.position, percentage);
                anim.SetBool("IsRunning", true);
                Player.position = transform.position;
            }
            else if (isDelaying)
            {
                delayTimer += Time.deltaTime;

                if (delayTimer >= delayTime)
                {
                    isDelaying = false;
                    isMoving = true;
                    transform.Rotate(transform.rotation.x, transform.rotation.y+180,transform.rotation.z);
                }
            }
        }
    }
}
