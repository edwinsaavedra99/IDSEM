using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BDItemns : MonoBehaviour
{
    public List<Item> itemnsnivel1;
    public List<Item> itemnsnivel2;
    public List<Item> itemnsnivel3;
    public List<Item> itemnsnivel4;

    public static BDItemns Instance { get; private set; }
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
    }

    public List<Item> getData()
    {
        //Nivel 1
        if (itemnsnivel1!=null){
            Debug.Log(itemnsnivel1[0].id);
            return itemnsnivel1;
        }
        //itemnsnivel1.Add(new Item("","",0, auxImage, ""));
        return null;

    }


}
