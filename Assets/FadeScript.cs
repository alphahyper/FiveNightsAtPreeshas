using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static Unity.Collections.AllocatorManager;

public class FadeScript : MonoBehaviour
{
    public Text myText;
    // Start is called before the first frame update
    void Start()
    {
        // Fade to invisible (0 alpha) immediately
        myText.canvasRenderer.SetAlpha(0f);
        // Fade in to full (1 alpha) over 2 seconds
        Invoke(nameof(FadeIn), 1f);
        Invoke(nameof(FadeOut), 3f);
    }

    public void FadeOut()
    {
        // Fade out to 0 alpha over 1 second
        myText.CrossFadeAlpha(0f, 3f, false);
    }

    public void FadeIn()
    {
        // Fade out to 0 alpha over 1 second
        myText.CrossFadeAlpha(1f, 3f, false);
    }


}
