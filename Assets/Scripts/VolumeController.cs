using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeController : MonoBehaviour
{
    AudioSource music;
    public void ChangeVolume(float volume)
    {
        music.volume = volume;
    }
}
