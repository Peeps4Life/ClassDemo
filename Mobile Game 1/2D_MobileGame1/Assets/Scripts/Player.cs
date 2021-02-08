using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameManager gameManager;
    public int maxHealth = 100;
    public int currentHealth;

    //public HealthBar healthBar;
    
    void Start()
    {
        //gameManager.GameOver();
        currentHealth = maxHealth;
        //healthBar.SetMaxHealth(maxHealth);
    }

    
    void Update()
    {
        GameObject GameOver = GameObject.Find("GameOver");
        GameObject LevelFinishhh = GameObject.Find("LevelFinishhh");
        //gameManager.GameOver();
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;

        //healthBar.SetHealth(currentHealth);

        if (currentHealth <= 0)
        {
             gameManager.GameOver();
            //Destroy(gameObject);
            gameObject.SetActive(false);
        }
        //gameManager.GameOver();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            TakeDamage(100);
        }
        if(collision.gameObject.tag == "Killzone")
        {
            
            gameManager.GameOver();
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "End")
        {
            gameManager.LevelFinishhh();
            Destroy(gameObject);
        }
    }
}
