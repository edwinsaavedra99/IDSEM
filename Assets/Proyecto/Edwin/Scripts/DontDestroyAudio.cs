using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyAudio : MonoBehaviour
{
    public static DontDestroyAudio Instance;
    /*public AudioSource audioSource;
    public AudioClip audioClip;

    private void Start()
    {
        if(audioSource != null)
        {
            //audioSource.PlayOneShot(audioClip);
            audioSource.Play();
        }        
        
    }*/

    void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(transform.gameObject);
        } 
    }
}
