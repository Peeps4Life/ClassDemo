using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerAutoMovement movement;
    
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            GetComponent<PlayerAutoMovement>().enabled = false;
            FindObjectOfType<GameManager>().GameOver();
           
        }
    }
}
