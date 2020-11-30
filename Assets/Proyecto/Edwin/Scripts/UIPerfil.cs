using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIPerfil : MonoBehaviour
{

    public Image avatar1_ninho;
    public Image avatar2_ninha;
    public InputField inputNick;
    public Text textAvatar;

    // Start is called before the first frame update
    void Start()
    {
       string nick = PlayerPrefs.GetString("Nick", "");
        inputNick.text = nick;
        
       int avatar = PlayerPrefs.GetInt("Avatar",1);
       if(avatar == 1)
        {
            //niño
            avatar1_ninho.GetComponent<Image>().color = new Color32(73, 220, 255, 255);
            avatar2_ninha.GetComponent<Image>().color = new Color32(255, 255, 225, 255);
            textAvatar.text = "Niño";
        }
        else if (avatar == 2) 
        {
            //niña
            avatar2_ninha.GetComponent<Image>().color = new Color32(73, 220, 255, 255);
            avatar1_ninho.GetComponent<Image>().color = new Color32(255, 255, 225, 255);
            textAvatar.text = "Niña";
        }



    }
}
