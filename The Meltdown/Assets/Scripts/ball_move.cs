using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball_move : MonoBehaviour
{

    //pull information on the rigid body
    public Rigidbody2D rb2D;
    
    
   
    //initialize variables that control jumping
    int canJump = 0;

    int jumpTimer = 0;

    

    public Vector3 v3Velocity;

    bool sprint = false;

    //check if the player is on the ground
   private void OnCollisionStay2D(Collision2D collision){
        //if so, set the game into a state where the player can jump

        if (collision.collider.GetType() == typeof(BoxCollider2D))
        {
            // do stuff only for the box collider
            canJump = 2;
            jumpTimer = 60;
        }

       
       //Debug.Log("hit detected");
   }
    // Start is called before the first frame update

    void Start()
    {
        rb2D = gameObject.GetComponent<Rigidbody2D>();
        

        //get the velocity of the player
        v3Velocity = rb2D.velocity;
    }

    // Update is called once per frame
    void Update()
    {

        sprint = false;

        //update the velocity check every frame
        v3Velocity = rb2D.velocity;
        //Debug.Log(v3Velocity);

        if (Input.GetKeyUp(KeyCode.Space))
        {
            --canJump;
        } 


        if (Input.GetKey(KeyCode.LeftShift))
        {
            sprint = true;
        }


        //check if a jump input was made
        if (Input.GetKeyDown(KeyCode.Space))
        {
             
            //check if the player is allowed to jump
            if (canJump > 0 && jumpTimer > 0)
            {
                
                for (jumpTimer=60;jumpTimer>0;--jumpTimer)
                {
                    rb2D.AddForce(Vector3.up*4);
                }
                //add an upwards force




                // print ("up)");
            }
        }

        //check if a left input was made
        if (Input.GetKey(KeyCode.A))
        {

            if (sprint)
            {
                //check if the player is moving too fast
                if (v3Velocity[0] >= -4.5)
                { 
                    //if not, add a leftwards force
                    rb2D.AddForce(Vector3.left);
                }

            }

            else
            {
                 //check if the player is moving too fast
                if (v3Velocity[0] >= -2.5)
                { 
                    //if not, add a leftwards force
                    rb2D.AddForce(Vector3.left);
                }               
            }


            
        }

        //check if a right input was made
        if (Input.GetKey(KeyCode.D))
        {
            if (sprint)
            {
                //check if the player is moving too fast
                if (v3Velocity[0] <= 4.5)
                { 
                    //if not, add a leftwards force
                    rb2D.AddForce(Vector3.right);
                }

            }

            else
            {
                 //check if the player is moving too fast
                if (v3Velocity[0] <= 2.5)
                { 
                    //if not, add a leftwards force
                    rb2D.AddForce(Vector3.right);
                }               
            }
        }

        
    }
}
