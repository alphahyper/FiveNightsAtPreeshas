using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public HUDManager HUDManager;
    static int night;
    public static GameManager Instance { get; private set; }  // Instance of this GameManager

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
