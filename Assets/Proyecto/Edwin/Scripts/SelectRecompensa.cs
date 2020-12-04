using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectRecompensa : MonoBehaviour
{

    public string tesoro;
    private int slot;
    public Image imagenBorde;

    void Start()
    {
        slot = PlayerPrefs.GetInt("NivelDesblock", 1);
    }


    public void eventoActive()
    {
        if (slot == 1)
        {
            PlayerPrefs.SetString("Slot1", PlayerPrefs.GetString(tesoro, "0"));
        }
        else if(slot == 2)
        {

            PlayerPrefs.SetString("Slot2", PlayerPrefs.GetString(tesoro, "0"));
        }
        else if (slot == 3)
        {

            PlayerPrefs.SetString("Slot3", PlayerPrefs.GetString(tesoro, "0"));
        }
        else if(slot == 4)
        {

            PlayerPrefs.SetString("Slot4", PlayerPrefs.GetString(tesoro, "0"));
        }

    }
}
