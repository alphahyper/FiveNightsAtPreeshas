using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Power : MonoBehaviour
{
    static float power;
    static int powerLeft;
    static int usage;
    static bool startCount = false;
    // Start is called before the first frame update
    void Start()
    {
        power = 100.00f;
        powerLeft = 99;
    }

    // Update is called once per frame
    void Update()
    {
        if (startCount == true)
        {
            power -= Time.deltaTime * usage;  // The increment of power usage
            if (power < powerLeft)
            {
                HUDManager.ChangePower(powerLeft--);  // Always checks if power is less than powerLeft, then changes HUD
            }

            if (power < 0)  // When power runs out
            {
                startCount = false;
                // ** send signal to stop doors, cameras, and lights **
            }
        }
    }
    public static void Restart()
    {
        power = 100.00f;
        powerLeft = 99;
        startCount = true;
    }
}
