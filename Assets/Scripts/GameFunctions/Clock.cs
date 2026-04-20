using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    private GameManager gameManager;
    private HUDManager hudManager;
    static float clockTime;
    static int hourDisplay;
    static bool startCount = false;  // Determines whether the timer runs or not

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        hudManager = GameObject.Find("GameManager").GetComponent<HUDManager>();
        clockTime = 0f;
        hourDisplay = 0;
        Debug.Log("done");
    }
    // TODO: figure out how to change timer
    void Update()
    {
        if (startCount == true)
        {
            clockTime += Time.deltaTime;
            // Every 90 sec is 1 hour in-game
            if (clockTime >= 1f)
            {
                hourDisplay += 1;
                hudManager.ChangeTimer(hourDisplay);

                clockTime = 0f;
            }

            // Finishes when clock reaches 6 AM
            if (hourDisplay >= 6)
            {
                gameManager.FinishNight();
                startCount = false;
            }
        }
    }

    public static void Restart()
    {
        Debug.Log("restarted");
        clockTime = 0;
        hourDisplay = 0;
        startCount = true;
    }

     
}
