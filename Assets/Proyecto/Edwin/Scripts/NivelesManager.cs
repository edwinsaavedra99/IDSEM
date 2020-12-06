using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NivelesManager : MonoBehaviour
{
    // Start is called before the first frame update
    private int nivel;
    public List<Image> portadaNiveles;

    void Start()
    {
        nivel = PlayerPrefs.GetInt("NivelDesblock", 1);
        for(int i = 0; i < portadaNiveles.Count; i++)
        {
            if(i+1 > nivel)
            {
                portadaNiveles[i].GetComponent<Image>().color = new Color32(67, 67, 67, 255);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
