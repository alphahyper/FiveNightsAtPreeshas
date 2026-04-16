using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static Unity.Collections.AllocatorManager;

public class GameOverScript : MonoBehaviour
{
    public Text gameOverText;
    // Start is called before the first frame update
    async Task Start()
    {
        // Fade to invisible (0 alpha) immediately
        gameOverText.canvasRenderer.SetAlpha(0f);
        // Fade in to full (1 alpha) over 2 seconds
        Invoke(nameof(FadesIn), 1f);
        Invoke(nameof(FadesOut), 5f);
        await Task.Delay(8000);
        SceneManager.LoadScene("Title Screen");
    }

    public void FadesOut()
    {
        // Fade out to 0 alpha over 1 second
        gameOverText.CrossFadeAlpha(0f, 2f, false);
    }

    public void FadesIn()
    {
        // Fade out to 0 alpha over 1 second
        gameOverText.CrossFadeAlpha(1f, 3f, false);
    }


}