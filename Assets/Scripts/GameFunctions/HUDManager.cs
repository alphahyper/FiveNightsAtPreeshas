using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Hierarchy;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static UnityEngine.Rendering.DebugUI;

public class HUDManager : MonoBehaviour
{
    public static GameObject HUD;
    // Office HUD
    private static TMP_Text clock;
    private static TMP_Text power;
    private static Transform[] batteries;

    public static HUDManager Instance { get; private set; }  // Instance of this HUDManager

    private void Awake()  // Creates a singleton
    {
        // If an instance already exists and it's not this one, destroy this duplicate
        //if (Instance != null && Instance != this)
        //{
        //    Destroy(gameObject);
        //    return;
        //}

        //// Set the instance and ensure it persists across scene loads
        //Instance = this;
        //DontDestroyOnLoad(gameObject);
    }

    // Loads HUD
    private void Start()
    {
        
    }

    public static void LoadOfficeHUD()
    {
        HUD = GameObject.Find("HUD");
        Debug.Log(HUD);
        Transform panel;
        panel = HUD.transform.Find("Panel");
        power = panel.transform.Find("PowerText").GetComponent<TMP_Text>();
        clock = panel.transform.Find("ClockText").GetComponent<TMP_Text>();
        // TODO: fix the transform
        //batteries = HUD.transform.Find("UsageText").GetComponentsInChildren<Transform>(true);
    }

 
    // Changes clock HUD
    public static void ChangeTimer(int hour)
    {
        clock.text = hour.ToString() + " AM";
    }

    // Changes power HUD
    public static void ChangePower(int battery)
    {
        Debug.Log(battery);
        power.text = "Power:" + battery.ToString() + "%";
    }

    // Changes icon for battery
    // TODO: CHANGE WHEN ICONS ARE MADE
    public static void ChangeBatteryUsage(int battery)
    {
        batteries[battery].gameObject.SetActive(false);
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
