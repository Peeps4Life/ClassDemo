using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchMove : MonoBehaviour
{
    // Start is called before the first frame update

    public float moveSpeed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void FixedUpdate()
    {
        TouchMovement();
    }



    void TouchMovement()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            if (mousePos.x > 1)
            {
                //move right
                transform.Translate(moveSpeed, 0, 0);
            }
            else if (mousePos.x < -1)
            {
                //move left
                transform.Translate(-moveSpeed, 0, 0);
            }

        }
    }

    
    }
