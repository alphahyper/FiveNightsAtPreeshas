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
        Transform panel;
        panel = HUD.transform.Find("NormalHUD");
        power = panel.transform.Find("PowerText").GetComponent<TMP_Text>();
        clock = panel.transform.Find("ClockText").GetComponent<TMP_Text>();
        // TODO: fix the transform
        batteries = panel.transform.Find("UsageText").GetComponentsInChildren<Transform>();
    }

 
    // Changes clock HUD
    public static void ChangeTimer(int hour)
    {
        clock.text = hour.ToString() + " AM";
    }

    // Changes power HUD
    public static void ChangePower(int battery)
    {
        power.text = "Power:" + battery.ToString() + "%";
    }

    // Changes icon for battery
    // TODO: CHANGE WHEN ICONS ARE MADE
    public static void ChangeBatteryUsage(int battery)
    {
        for (int i = 5; i > battery; i--)
        {
            batteries[i].gameObject.SetActive(false);
        }
        for (int i = battery;i > 0; i--)
        {
            batteries[i].gameObject.SetActive(true);
        }
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
        GameObject.Find("HUD").transform.Find("Panel").transform.Find("UsageText").gameObject.SetActive(true);
    }
    // Hides the HUD for the actual gameplay
    public static void HideOfficeHUD()
    {
        clock.enabled = false;
        power.enabled = false;
        GameObject.Find("HUD").transform.Find("Panel").transform.Find("UsageText").gameObject.SetActive(false);
    }
}
