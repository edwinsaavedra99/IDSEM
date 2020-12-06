using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class LoadSceneAudio : MonoBehaviour, IPointerClickHandler
{
    public string namescene;
    public AudioSource audioSource;
    public AudioClip audioClip;
    private const int T = 1;
    //private const string TAG = "Level_";

    public void OnPointerClick(PointerEventData eventData)
    {
        //if (nameLevel <= PlayerPrefs.GetInt("NivelDesblock", 1))
        //{
            audioSource.PlayOneShot(audioClip);
            StartCoroutine("StartNivel");
        //}
        //else
        //{
            //No se puede acceder a nivel --mostrar notificacion o algo
        //}
    }

    IEnumerator StartNivel()
    {
        yield return new WaitForSeconds(T);
        //PlayerPrefs.SetInt("NivelSelect", nameLevel);
        SceneManager.LoadScene(namescene);
    }
}
