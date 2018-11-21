﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawning_of_bawlingballs : MonoBehaviour
{

    public GameObject bowlingBall;
    public float maxWidth = 1;
    public float StartTime=2;
    public float time = 2;
    // Use this for initialization
    void Start()
    {
        Vector3 upperCorner = new Vector3(Screen.width, Screen.height, 0.0f);
        Vector3 targetWidth = Camera.main.ScreenToWorldPoint(upperCorner);
        float ballWidth = bowlingBall.GetComponent<Renderer>().bounds.extents.x / 2;
        maxWidth = targetWidth.x - ballWidth;
        time = StartTime;
       
    }

    /*IEnumerator Spawn()
    {   // Čeka 2 sekunde
        yield return new WaitForSeconds(2.0f);
        // Beskonačna petlja
        while (true)
        {
            // Određuje poziciju iz koje će se instancirati kugle
            Vector3 spawnPosition = new Vector3(Random.Range(-maxWidth, maxWidth), transform.position.y, 0.0f);
            // Za rotaciju se uzima „default“ vrijednost (0, 0, 0, 0)
            Quaternion spawnRotation = Quaternion.identity;
            // Instanciranje kugle
            Instantiate(bowlingBall, spawnPosition, spawnRotation);

            // Čeka 2 sekunde
            yield return new WaitForSeconds(2.0f);
        }

    }
    */

    void Update()
    
        {
        if (time < 0)
        {
            Vector3 spawnPosition = new Vector3(Random.Range(-maxWidth, maxWidth), transform.position.y, 0.0f);
            Quaternion spawnRotation = Quaternion.identity;
            Instantiate(bowlingBall, spawnPosition, spawnRotation);
            time = StartTime;
        }
        else
            time = time - Time.deltaTime;
            
            
        

    }
}
