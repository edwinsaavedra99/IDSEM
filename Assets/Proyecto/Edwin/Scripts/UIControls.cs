using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIControls : MonoBehaviour
{
   
    public void changeScene()
    {
        int scene  = PlayerPrefs.GetInt("NewPerfil", 0); //comprobar si ah guardado datos anteriormente
        if(scene == 0)
        {
            //ir a scena de perfil
            Application.LoadLevel("Perfil");

        }else if (scene == 1)
        {
            //ir a scena de niveles
            Application.LoadLevel("Niveles");
        }

    }

    public void exitGame()
    {
        Application.Quit();
    }

    public void infoScenes()
    {
        Application.LoadLevel("Instrucciones");
    }

    public void perfilScene()
    {
        Application.LoadLevel("Perfil");
    }

}
