using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Hierarchy;
using UnityEngine;
using UnityEngine.UI;

public class HUDManager : MonoBehaviour
{
    public static TextMeshPro clock;
    public static TextMeshPro power;

    // Changes clock HUD
    public static void ChangeTimer(int hour)
    {
        clock.text = hour.ToString() + " AM";
    }

    // Changes power HUD
    public static void ChangePower(int battery)
    {
        power.text = battery.ToString() + "%";
    }

    // Changes icon for battery
    // TODO: CHANGE WHEN ICONS ARE MADE
    public static void ChangeBatteryUsage(int battery)
    {

    }

    
    /* 
     * TODO: add the appropriate HUD elements to the following four functions:
     */

    // Shows the HUD for the menu
    public static void ShowMenuHUD()
    {
        clock.enabled = true;
        power.enabled = true;
    }
    // Hides the HUD for the menu
    public static void HideMenuHUD()
    {
        clock.enabled = false;
        power.enabled = false;
    }

    // Shows the HUD for the actual gameplay
    public static void ShowOfficeHUD()
    {
        clock.enabled = true;
        power.enabled = true;
    }
    // Hides the HUD for the actual gameplay
    public static void HideOfficeHUD()
    {
        clock.enabled = false;
        power.enabled = false;
    }
}
