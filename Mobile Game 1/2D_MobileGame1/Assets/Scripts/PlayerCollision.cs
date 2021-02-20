using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerAutoMovement movement;

    private GameManager GameManager;
    
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            GetComponent<PlayerAutoMovement>().enabled = false;
            GetComponent<Character2DController>().enabled = false;
            GetComponent<Weapon>().enabled = false;
            FindObjectOfType<GameManager>().GameOver();

            //GameManager.GameOver(); 
           
        }
    }
}
