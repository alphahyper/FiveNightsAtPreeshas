using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Hierarchy;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HUDManager : MonoBehaviour
{
    // Office HUD
    private TMP_Text clock;
    private TMP_Text power;

    public static HUDManager Instance { get; private set; }  // Instance of this HUDManager

    private void Awake()  // Creates a singleton
    {
        // If an instance already exists and it's not this one, destroy this duplicate
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        // Set the instance and ensure it persists across scene loads
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {

    }

    // Loads an HUD
    public void LoadHUD(string scene)
    {
        GameObject[] objects = SceneManager.GetSceneByName("School").GetRootGameObjects();
        Transform panel;
        Debug.Log(objects[0]);
        // Assigns all HUDs
        foreach (GameObject obj in objects)
        {
            Debug.Log(obj.name);
            if (obj.name.Equals("HUD"))
            {
                panel = obj.GetComponent<Canvas>().transform.Find("Panel");
                foreach (Transform child in panel)
                {
                    Debug.Log(child.name);
                    if (child.name.Equals("PowerText")) power = child.GetComponent<TMP_Text>();
                    else if (child.name.Equals("ClockText")) clock = child.GetComponent<TMP_Text>();
                }
            }
        }

    }
    // Changes clock HUD
    public void ChangeTimer(int hour)
    {
        clock.text = hour.ToString() + " AM";
    }

    // Changes power HUD
    public void ChangePower(int battery)
    {
        power.text = battery.ToString() + "%";
    }

    // Changes icon for battery
    // TODO: CHANGE WHEN ICONS ARE MADE
    public void ChangeBatteryUsage(int battery)
    {

    }

    
    /* 
     * TODO: add the appropriate HUD elements to the following four functions:
     */

    // Shows the HUD for the menu
    public void ShowMenuHUD()
    {
        clock.enabled = true;
        power.enabled = true;
    }
    // Hides the HUD for the menu
    public void HideMenuHUD()
    {
        clock.enabled = false;
        power.enabled = false;
    }

    // Shows the HUD for the actual gameplay
    public void ShowOfficeHUD()
    {
        clock.enabled = true;
        power.enabled = true;
    }
    // Hides the HUD for the actual gameplay
    public void HideOfficeHUD()
    {
        clock.enabled = false;
        power.enabled = false;
    }
}
