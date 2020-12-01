using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class NivelSelect : MonoBehaviour, IPointerClickHandler
{
    public string nameLevel = "";    

    public void OnPointerClick(PointerEventData eventData)
    {
        Application.LoadLevel(nameLevel);
    }
}
