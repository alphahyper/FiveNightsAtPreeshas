using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static int night;
    public static GameManager Instance { get; private set; }  // Instance of this GameManager

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
    void Start()
    {
        StartNight(1);
    }



    // Starts the night that is listed
    async public static void StartNight(int num)
    {
        night = num;
        HUDManager.LoadOfficeHUD();
        await Task.Delay(200);
        Clock.Restart();
        Power.Restart();
    }

    public static void PowerOut()
    {
        HUDManager.HideOfficeHUD();
        Transform leftDoor = GameObject.Find("Doors").transform.Find("Left Door");
        Transform rightDoor = GameObject.Find("Doors").transform.Find("Right Door");
        Transform backDoor = GameObject.Find("Doors").transform.Find("Back Door");
        leftDoor.gameObject.SetActive(false);
        rightDoor.gameObject.SetActive(false);
        backDoor.gameObject.SetActive(false);
        MovementManager.backDoorClosed = false;
        MovementManager.leftDoorClosed = false;
        MovementManager.rightDoorClosed = false;
    }

    // TODO: Finish this when HUD has been made
    // Tells the game to complete the night
    public static void FinishNight()
    {
        HUDManager.HideOfficeHUD();  // Hides office HUD
        SceneManager.LoadScene("Congratulations Screen");
    }
}
