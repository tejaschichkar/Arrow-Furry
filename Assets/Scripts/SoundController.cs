using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    public AudioSource Baudio;

    public void PlayAudio()
    {
        Baudio.Play();
    }
}
