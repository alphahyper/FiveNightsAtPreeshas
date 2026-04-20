using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        night = 1;
        Debug.Log(SceneManager.GetActiveScene());
    }
    


    // Starts the night that is listed
    public void StartNight(int num)
    {
        night = num;
        //HUDManager.LoadHUD("School");
        //HUDManager.ShowOfficeHUD();
        Debug.Log("office shown");
        Clock.Restart();
    }

    // TODO: Finish this when HUD has been made
    // Tells the game to complete the night
    public void FinishNight()
    {
        HUDManager.HideOfficeHUD();  // Hides office HUD
    }

    
    public void StartNightScene()
    {
        SceneManager.LoadScene("Night Scene");
    }
    public void StartSchoolScene()
    {
        SceneManager.LoadScene("School");
        StartNight(night++);
    }


    // Waits until scene is loaded
    IEnumerator LoadAsync(string sceneName)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneName);

        // Wait until the scene is fully loaded
        while (!operation.isDone)
        {
            // You can track operation.progress here (0.0 to 0.9)
            yield return null;
        }

        Debug.Log("Scene fully loaded!");
    }
}
