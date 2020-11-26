using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lose : MonoBehaviour
{
    public GameObject LoseMenu;
    public CameraFollow player;
    public HighScoresaving saving;

    //this script is the very basic UI work I am becoming accustomed too.

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Rigidbody2D playerRB = collision.collider.GetComponent<Rigidbody2D>();
        if (playerRB != null)
        {
            //run lose function
            Time.timeScale = 0;
            LoseMenu.SetActive(true);
            player.highScore = player.curHeight;
            saving.ScoreUpdate();
        }
    }
    
    public void RetryButton()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Main");
    }

    public void GoToMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Menu");
    }

    public void ExitButton()
    {
        Application.Quit();
    }


}
