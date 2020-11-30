using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SaveInfo : MonoBehaviour, IPointerClickHandler
{
    public Image avatarImage_1;
    public Image avatarImage_2;
    public Text textAvatar;
    public int avatar;

    public void OnPointerClick(PointerEventData eventData)
    {
        // OnClick code goes here ...
        if(avatar == 1)
        {
            avatarImage_1.GetComponent<Image>().color = new Color32(73, 220, 255, 255);
            avatarImage_2.GetComponent<Image>().color = new Color32(255, 255, 225, 255);
            textAvatar.text = "Niño";
            PlayerPrefs.SetInt("AvatarTemp", avatar);
        }
        else if(avatar ==2)
        {
            avatarImage_2.GetComponent<Image>().color = new Color32(73, 220, 255, 255);
            avatarImage_1.GetComponent<Image>().color = new Color32(255, 255, 225, 255);
            textAvatar.text = "Niña";
            PlayerPrefs.SetInt("AvatarTemp", avatar);
        }
        

    }



}
