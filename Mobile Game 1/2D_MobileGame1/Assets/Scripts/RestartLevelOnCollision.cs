using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevelOnCollision : MonoBehaviour
{
    [SerializeField]
    string strTag;

    private GameManager GameManager;


    void Start()
    {
        GameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == strTag)

            GameManager.GameOver();
    }
}
