using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraFollow : MonoBehaviour
{

    public Transform target;
    public HighScoresaving scores;

    public float smoothedSpeed = 0.3f;
    public Text currentHeight;
    public float curHeight;
    public float highScore;


    // Update is called once per frame
    void Update()
    {
        curHeight = transform.position.y;
        currentHeight.text = ("Heights Reached: " + curHeight.ToString());
        highScore = curHeight;
        //this is throwing a null reference exception, I don't understand why, it is also functioning exactly as I want it to. So I'm at a loss here.
        scores.ScoreUpdate();
    }
    // Update is called once per frame
    void LateUpdate()
    {
        //this is in late update so that we don't have the camera movement happening at the same time asthe player movement.
        //essentially, if the players Y position is higher then the cameras, move the camera, if not, keep us still.
        if(target.position.y >= transform.position.y)
        {
            Vector3 newPosition = new Vector3(0f, target.position.y, -10f);
            transform.position = newPosition;
        }    
    }
}
