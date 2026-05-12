using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicControls : MonoBehaviour

{
    public AudioSource audio1;
    public AudioSource audio2;
    public AudioSource audio3;
    public AudioSource audio4;
    public AudioSource audio5;
    // Start is called before the first frame update
    void Start()
    {
        int num = Random.Range(1, 6);
        switch (num)
        {
            case 1:
                audio1.Play();
                StartCoroutine(WaitForAudioToEnd(audio1.clip.length));
                break;
            case 2:
                audio2.Play();
                StartCoroutine(WaitForAudioToEnd(audio2.clip.length));
                break;
            case 3:
                audio3.Play();
                StartCoroutine(WaitForAudioToEnd(audio3.clip.length));
                break;
            case 4:
                audio4.Play();
                StartCoroutine(WaitForAudioToEnd(audio4.clip.length));
                break;
            case 5:
                audio5.Play();
                StartCoroutine(WaitForAudioToEnd(audio5.clip.length));
                break;
        }
    }

    public void PlayMusic()
    {
        int num = Random.Range(1, 6);
        switch (num)
        {
            case 1:
                audio1.Play();
                StartCoroutine(WaitForAudioToEnd(audio1.clip.length));
                break;
            case 2:
                audio2.Play();
                StartCoroutine(WaitForAudioToEnd(audio2.clip.length));
                break;
            case 3:
                audio3.Play();
                StartCoroutine(WaitForAudioToEnd(audio3.clip.length));
                break;
            case 4:
                audio4.Play();
                StartCoroutine(WaitForAudioToEnd(audio4.clip.length));
                break;
            case 5:
                audio5.Play();
                StartCoroutine(WaitForAudioToEnd(audio5.clip.length));
                break;
        }
    }

    private IEnumerator WaitForAudioToEnd(float duration)
    {
        yield return new WaitForSeconds(duration);
        PlayMusic();
        Debug.Log("Audio Finished!");
    }
}
