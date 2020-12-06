using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecompensasInitial : MonoBehaviour
{
    // Start is called before the first frame update
    private int nivel;
    private List<Item> items;
    private BDItemns bD;
    public Text title;
    public Image item1;
    public Image item2;
    public Image item3;


    void Start()
    {
        nivel = PlayerPrefs.GetInt("NivelSelect", 1);
        bD = BDItemns.Instance;
        items = bD.getData(nivel);
        if (items != null && items[0]!=null && items[1]!=null && items[2]!=null)
        {
            item1.sprite = items[0].imagen.sprite;
            item2.sprite = items[1].imagen.sprite;
            item3.sprite = items[2].imagen.sprite;
            title.text = "Nivel 1";
            PlayerPrefs.SetString("Recompensa1",items[0].id);
            PlayerPrefs.SetString("Recompensa2", items[1].id);
            PlayerPrefs.SetString("Recompensa3", items[2].id);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
