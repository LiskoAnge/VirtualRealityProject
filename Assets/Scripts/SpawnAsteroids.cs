using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAsteroids : MonoBehaviour
{

    public float Timer = 5;
    public GameObject[] asteroids;
    public Transform[] asteroidPos;
    int randomAsteroids;
    int randomPosition;


    void Update()
    {
        Timer -= Time.deltaTime;
        if (Timer <= 0f)
        {
            //Debug.Log("rock instantiated!");
            randomAsteroids = Random.Range(0, asteroids.Length);
            randomPosition = Random.Range(0, asteroidPos.Length);
            Instantiate(asteroids[randomAsteroids], asteroidPos[randomPosition].position, asteroidPos[randomPosition].rotation);

            Timer = 5f;
        }
    }



}

