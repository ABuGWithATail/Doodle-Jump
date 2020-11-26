using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]

public class Player : MonoBehaviour
{
    
    float movement = 0f;
    public float movementSpeed = 10f;
    public float winHeight = 100;


    public GameObject upMovement;
    public GameObject downMovement;
    Rigidbody2D playerRB;
    public GameObject winObject;


    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
        WinCondition();
        
    }

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxis("Horizontal") * movementSpeed;
        
    }
    private void FixedUpdate()
    {
        //We want to actuate the players movement in fixed update, not update as I am using physics and velocity to move the player.
        Vector2 velocity = playerRB.velocity;
        velocity.x = movement;
        playerRB.velocity = velocity;
        
        //this script here is a very brutforce animation switching. I understand why it's bad, I only did it because
        // the sprites I found online and did a majority of this asignment with were'nt part of the same file to begin with.
        //this was the easiest way I could figure around it, by making them game objects and setting them active depending on velocity.
        //budget animation? it's functional.
        if(velocity.y > 0)
        {
            upMovement.SetActive(true);
            downMovement.SetActive(false);
        }
        if(velocity.y < 0)
        {
            upMovement.SetActive(false);
            downMovement.SetActive(true);
        }
    }
    


    public void WinCondition()
    {
        //this serves as a win condition, but then allows the player to go further to get a high score
        if(transform.position.y >= winHeight)
        {
            Time.timeScale = 0;
            winObject.SetActive(true);
            
        }
    }

    public void Continue()
    {
        //unpause the game and keep going.
        Time.timeScale = 1;
        winObject.SetActive(false);
    }

}
