using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlSave : MonoBehaviour
{    
    public InputField inputNick;
    public GameObject panel;
    public Text saludo;
    private const int T = 1;

    public void save()
    {

        if (inputNick.text.Length != 0)
        {
            PlayerPrefs.SetString("Nick", inputNick.text); //guardar nick
            PlayerPrefs.SetInt("Avatar", PlayerPrefs.GetInt("AvatarTemp",1)); //guardar avatar
            //PlayerPrefs.DeleteKey("AvatarTemp"); borrar al dar continua
            PlayerPrefs.SetInt("NewPerfil", 1); //decir que ya guardamos informacion
            saludo.text = "QUE BUENO VERTE \n"+ inputNick.text.ToUpper();
            panel.active = true;

        }

    }
    public void cancelSave()
    {
        StartCoroutine("StartInicio");
        
    }

    IEnumerator StartInicio()
    {
        yield return new WaitForSeconds(T);
        PlayerPrefs.DeleteKey("AvatarTemp");
        Application.LoadLevel("Inicio");
    }

    public void continuar()
    {
        Application.LoadLevel("Niveles");
    }


}
