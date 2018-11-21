using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Spawning_of_bawlingballs : MonoBehaviour
{
    public GameObject gameOverText;
    public GameObject restartButton;
    public Text text;
    public float timeLeft = 30;
    public GameObject bowlingBall;
    public float maxWidth = 1;
    public float StartTime=2;
    public float time = 2;
    public bool gamestart=false;
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
            if (timeLeft != 0)
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
            if (timeLeft <= 0)
            {
                gameOverText.SetActive(true);
                restartButton.SetActive(true);
            }

        
    }

    void FixedUpdate()
    {
        timeLeft = timeLeft - Time.deltaTime;
        if (timeLeft < 0)
        { timeLeft = 0; }
        // Koristi se Mathf.RountToInt kako bi vrijeme bilo bez decimalnih brojeva
        text.text = "Time Left: \n" + Mathf.RoundToInt(timeLeft);
    }


    
}


