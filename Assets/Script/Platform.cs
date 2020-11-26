using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public float jumpForce = 10;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //relative velocity allows us to check the the speed we are going and which direction we are going.
        //I'm using it to check if the player is falling, if so, then run the code that allows to bounce upon collision.
        if (collision.relativeVelocity.y <= 0f)
        {
            Rigidbody2D playerRigidBody2D = collision.collider.GetComponent<Rigidbody2D>();
            if (playerRigidBody2D != null)
            {
                //these three lines allow for the player to jump as soon as it collides with a platform.
                //because of the relative velocity, it won't bounce while it is coming up from underneath the platform.
                Vector2 velocity = playerRigidBody2D.velocity;
                velocity.y = jumpForce;
                playerRigidBody2D.velocity = velocity;
            }
        }        
    }
}
