using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFX : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip audioClip;


    public void ClickSound()
    {
        audioSource.PlayOneShot(audioClip);
    }

}
