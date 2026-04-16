using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    private GameManager gameManager;
    private HUDManager hudManager;
    static float clockTime;
    static int hourDisplay;
    static bool startCount;  // Determines whether the timer runs or not

    void Start()
    {
        // TODO: Attach HUD and GAME managers to their vars, then test if they can be accessed
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        hudManager = GameObject.Find("GameManager").GetComponent<HUDManager>();
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
                gameManager.FinishNight();
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
