using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    public GameManager GameManager;
    static float clockTime;
    static int hourDisplay;
    static bool startCount;  // Determines whether the timer runs or not

    void Start()
    {
        clockTime = 0f;
        hourDisplay = 0;
        startCount = false;
    }

    void Update()
    {
        if (startCount == true)
        {
            clockTime += Time.deltaTime;
            // Every 90 sec is 1 hour in-game
            if (clockTime >= 90)
            {
                hourDisplay += 1;
                clockTime = 0f;
            }

            // Finishes when clock reaches 6 AM
            if (clockTime >= 6)
            {
                GameManager.FinishNight();
                startCount = false;
            }
        }
    }

    public static void Restart()
    {
        clockTime = 0;
        hourDisplay = 0;
        startCount = true;
    }

     
}
