using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGeneration : MonoBehaviour
{
    public GameObject platform;

    public int numberOfPlatforms = 1000;
    public float levelWidth = 5;
    public float minY = .2f;
    public float maxY = 1.5f;

    private void Start()
    {
        //the folling for loop allows us to set an amount of platforms we want, and spawn them within a random height and width range.
        // we are specifying also that the rotation won't change. as this will cause some issues with the game.
        //If I were to spend more time on this project, I would figure out how to make this infinite, but I feel for the purposes
        //of this assignment, this does well.
        Vector3 spawnPosition = new Vector3();

        for(int i = 0; i < numberOfPlatforms; i++)
        {
            Time.timeScale = 1;
            spawnPosition.y += Random.Range(minY, maxY);
            spawnPosition.x = Random.Range(-levelWidth, levelWidth);
            Instantiate(platform, spawnPosition, Quaternion.identity);
        }
    }
}
