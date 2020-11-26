using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoresaving : MonoBehaviour
{
    public Text highScore;

    //get the camerafollow script as it uses the camera's height to get current height and make the high score function.
    private CameraFollow player;

    private void Start()
    {
        //the camera script is where I storing the hieght reached, as the player moves up and down constantly.
        player = FindObjectOfType<CameraFollow>();       
        highScore.text = PlayerPrefs.GetFloat("HighScore", 0).ToString();
    }

    // Start is called before the first frame update
    public void ScoreUpdate()
    {
        //only save a new high score if it's higher then the previous one.
        if (player.highScore > PlayerPrefs.GetFloat("HighScore", 0))
        {
            PlayerPrefs.SetFloat("HighScore", player.highScore);
        }
    }
}
