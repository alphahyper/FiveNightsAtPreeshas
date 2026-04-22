using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButtonScript : MonoBehaviour
{
    GameManager gameManager;
    public void startGame()
    {
        SceneManager.LoadScene("Night Scene");
    }
}
