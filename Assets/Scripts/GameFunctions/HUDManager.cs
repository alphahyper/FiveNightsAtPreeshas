using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Hierarchy;
using UnityEngine;
using UnityEngine.UI;

public class HUDManager : MonoBehaviour
{
    public TextMeshPro clock;
    public TextMeshPro power;
    public TextMeshPro[] HUDS = new TextMeshPro[1];
    public Canvas officeHUD;


    private void Start()
    {
        Debug.Log(officeHUD.tag);
        HUDS = officeHUD.GetComponents<TextMeshPro>();
        Debug.Log(HUDS.Length);
        /*foreach (TextMeshPro text in HUDS) {
            Debug.Log(text.name);
            //if (text.name == "powerText") power = text;
            //else if (text.name == "clockText") clock = text;
        }*/
        
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
