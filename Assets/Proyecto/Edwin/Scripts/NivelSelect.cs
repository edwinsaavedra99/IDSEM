using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.EventSystems;

public class NivelSelect : MonoBehaviour, IPointerClickHandler
{
    
    public string nameLevel = "";
    public AudioSource audioSource;
    public AudioClip audioClip;
    private const int T = 1;

    public void OnPointerClick(PointerEventData eventData)
    {
        audioSource.PlayOneShot(audioClip);
        StartCoroutine("StartNivel");
    }

    IEnumerator StartNivel()
    {
        yield return new WaitForSeconds(T);        
        Application.LoadLevel(nameLevel);
    }
}
