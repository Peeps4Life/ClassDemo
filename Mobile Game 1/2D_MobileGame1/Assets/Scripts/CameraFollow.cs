
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public float movingSpeed = 10f;

    void Update()
    {
        transform.position += Vector3.up * Time.deltaTime * movingSpeed;
    }
}
