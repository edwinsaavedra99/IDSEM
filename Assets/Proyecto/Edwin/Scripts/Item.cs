using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Item {
    public string id;
    public string atributo;
    public int puntos;
    public Image imagen;
    public string nombre;
    public int categoria;
    public Item(string arg,string arg01,int arg02,Image arg03,string arg04,int arg05)
    {
        id = arg;
        atributo = arg01;
        puntos = arg02;
        imagen = arg03;
        nombre = arg04;
        categoria = arg05;
    }

    public Image getImage()
    {
        return imagen;
    }
    public bool compare(string a ){
        return a.Equals(atributo);
    }

}
