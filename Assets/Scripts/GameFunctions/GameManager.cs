using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public HUDManager HUDManager;
    static int night;

    void Start()
    {
        HUDManager = GetComponent<HUDManager>();
        StartNight(0);
        night = 0;
    }

    // Starts the night that is listed
    public void StartNight(int num)
    {
        night = num;
        HUDManager.ShowOfficeHUD();
        Clock.Restart();
    }

    // TODO: Finish this when HUD has been made
    // Tells the game to complete the night
    public void FinishNight()
    {
        HUDManager.HideOfficeHUD();  // Hides office HUD
    }



}
