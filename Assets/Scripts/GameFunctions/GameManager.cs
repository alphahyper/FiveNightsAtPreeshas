using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    static int night;

    void Start()
    {
        night = 0;
    }

    // Starts the night that is listed
    public static void StartNight(int num)
    {
        night = num;
        HUDManager.ShowOfficeHUD();
        Clock.Restart();
    }

    // TODO: Finish this when HUD has been made
    // Tells the game to complete the night
    public static void FinishNight()
    {
        HUDManager.HideOfficeHUD();  // Hides office HUD
    }



}
