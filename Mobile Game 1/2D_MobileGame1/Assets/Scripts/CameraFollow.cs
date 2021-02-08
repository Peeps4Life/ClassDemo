
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;

    private void FixedUpdate()
    {
        if (target != null)
        {
            transform.position = target.position + offset;
        }
    }
}
