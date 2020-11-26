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
        player = FindObjectOfType<CameraFollow>();       
        highScore.text = PlayerPrefs.GetFloat("HighScore", 0).ToString();
    }

    // Start is called before the first frame update
    public void ScoreUpdate()
    {
        if (player.highScore > PlayerPrefs.GetFloat("HighScore", 0))
        {
            PlayerPrefs.SetFloat("HighScore", player.highScore);
        }
    }
}
