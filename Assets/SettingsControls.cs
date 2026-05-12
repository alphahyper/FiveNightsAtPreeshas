using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingsControls : MonoBehaviour
{
    // Start is called before the first frame update

    public void SwitchtoSettings()
    {
        Time.timeScale = 0;
        SceneManager.LoadScene("Settings Screen", LoadSceneMode.Additive);
    }

    public void BackToGame()
    {
        Time.timeScale = 1;
        SceneManager.UnloadSceneAsync("Settings Screen");
    }
}
