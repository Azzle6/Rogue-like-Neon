using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GFC_PlayerDash : MonoBehaviour

{
    public Rigidbody2D rb;
    public float dashSpeed;
    private float dashDuration;
    public float startDashDuration;
    private int direction;

    // Start is called before the first frame update
    void Start()
    {
        rb.GetComponent<Rigidbody2D>();
        
        dashDuration = startDashDuration;
    }

    // Update is called once per frame
    void Update()
    {
        if(direction == 0)
        {
            if (Input.GetKey(KeyCode.LeftArrow) && Input.GetKeyDown(KeyCode.Space))
            {
                direction = 1;
            }
            else if (Input.GetKey(KeyCode.RightArrow) && Input.GetKeyDown(KeyCode.Space))
            {
                direction = 2;
            }
            else if (Input.GetKey(KeyCode.UpArrow) && Input.GetKeyDown(KeyCode.Space))
            {
                direction = 3;
            }
            else if (Input.GetKey(KeyCode.DownArrow) && Input.GetKeyDown(KeyCode.Space))
            {
                direction = 4;
            }

            //Une tentative de le faire aller en diagonale

            //else if (Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.UpArrow) && Input.GetKeyDown(KeyCode.Space))
            {
                //direction = 5;
            }
            //else if (Input.GetKey(KeyCode.RightArrow) && Input.GetKey(KeyCode.UpArrow) && Input.GetKeyDown(KeyCode.Space))
            {
                //direction = 6;
            }
            //else if (Input.GetKey(KeyCode.RightArrow) && Input.GetKey(KeyCode.DownArrow) && Input.GetKeyDown(KeyCode.Space))
            {
                //direction = 7;
            }
            //else if (Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.DownArrow) && Input.GetKeyDown(KeyCode.Space))
            {
                //direction = 8;
            }
        }
        else
        {
            if (dashDuration <= 0)
            {
                direction = 0;
                dashDuration = startDashDuration;
                rb.velocity = Vector2.zero;
            } 
            else
            {
                dashDuration -= Time.deltaTime;

                if (direction == 1)
                {
                    rb.velocity = Vector2.left * dashSpeed;
                }
                else if (direction == 2)
                {
                    rb.velocity = Vector2.right * dashSpeed;
                }
                else if (direction == 3)
                {
                    rb.velocity = Vector2.up * dashSpeed;
                }
                else if (direction == 4)
                {
                    rb.velocity = Vector2.down * dashSpeed;
                }
                
            }
        }
    }
}
