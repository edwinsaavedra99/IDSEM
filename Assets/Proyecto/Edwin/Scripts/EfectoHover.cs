using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EfectoHover : MonoBehaviour
{
    public Color colorentrad;
    public Color colorsalida;
    public Image img;

    public void entra()
    {
        img.GetComponent<Image>().color = colorentrad;
    }
    public void sale()
    {
        img.GetComponent<Image>().color = colorsalida;
    }



}
