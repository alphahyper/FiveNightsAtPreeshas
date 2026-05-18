using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Power : MonoBehaviour
{
    static float power;
    static int powerLeft;
    public static int usage;
    static float[] usages = new float[6];
    static bool startCount = false;
    // Start is called before the first frame update
    void Start()
    {
        power = 100.00f;
        powerLeft = 99;
        usage = 1;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (startCount == true)
        {
            power -= Time.deltaTime * usage/2f;  // The increment of power usage
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
        usage = 1;
        usages = new float[] { 0f, 0.2f, 0.5f, 1f, 1.8f, 2.5f };
        ChangeUsage(usage);
        startCount = true;
    }

    public static void ChangeUsage(int use)
    {
        if (use <= 5 || use >= 1)
        {
            usage = use;
            HUDManager.ChangeBatteryUsage(usage);
        }
    }
}
