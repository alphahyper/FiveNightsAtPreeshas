using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    static float clockTime;
    static int hourDisplay;
    static bool startCount = false;  // Determines whether the timer runs or not

    void Start()
    {
        clockTime = 0f;
        hourDisplay = 0;
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
                HUDManager.ChangeTimer(hourDisplay);

                clockTime = 0f;
            }

            // Finishes when clock reaches 6 AM
            if (hourDisplay >= 6)
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
        HUDManager.ChangeTimer(12);
        startCount = true;
    }

     
}
