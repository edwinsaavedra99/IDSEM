using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverController : MonoBehaviour
{
    
    public AudioSource audioSource;
    public AudioClip audioClip;
    private const int T = 1;

    public void deNuevo()
    {
        audioSource.PlayOneShot(audioClip);
        StartCoroutine("StartNiveldeNuevo");
    }
    public void irInicio()
    {
        audioSource.PlayOneShot(audioClip);
        StartCoroutine("StartNivelInicio");
    }

    IEnumerator StartNiveldeNuevo()
    {
        yield return new WaitForSeconds(T);
        int nivel = PlayerPrefs.GetInt("NivelSelect",1);
        SceneManager.LoadScene("Level_"+nivel);
    }
    IEnumerator StartNivelInicio()
    {
        yield return new WaitForSeconds(T);
        SceneManager.LoadScene("Inicio");
    }
}
