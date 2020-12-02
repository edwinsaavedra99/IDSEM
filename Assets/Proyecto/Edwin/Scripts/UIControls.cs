using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class UIControls : MonoBehaviour
{
    private const int T = 1;
    
    public void changeScene()
    {
        StartCoroutine("StartGame");     
    }

    public void exitGame()
    {
        StartCoroutine("EndGame");
    }

    public void infoScenes()
    {
        StartCoroutine("StartInstrucciones");
    }


    public void perfilScene()
    {
        StartCoroutine("StartPerfil");
    }

    IEnumerator StartInstrucciones()
    {
        yield return new WaitForSeconds(T);
        Application.LoadLevel("Instrucciones");
    }

    IEnumerator StartPerfil()
    {
        yield return new WaitForSeconds(T);
        Application.LoadLevel("Perfil");
    }

    IEnumerator EndGame()
    {
        yield return new WaitForSeconds(T);
        Application.Quit();
    }


    IEnumerator StartGame()
    {
        
        yield return new WaitForSeconds(T);
        int scene = PlayerPrefs.GetInt("NewPerfil", 0); //comprobar si ah guardado datos anteriormente
        if (scene == 0)
        {
            //ir a scena de perfil
            Application.LoadLevel("Perfil");

        }
        else if (scene == 1)
        {
            //ir a scena de niveles
            Application.LoadLevel("Niveles");
        }

    }
}
