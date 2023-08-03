using UnityEngine;

public class FollowCameraRotation : MonoBehaviour
{
    [SerializeField] Transform cam;

  
    void LateUpdate()
    {
        transform.LookAt(cam);
    }
}
