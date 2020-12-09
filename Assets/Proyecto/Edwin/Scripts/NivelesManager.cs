using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NivelesManager : MonoBehaviour
{
    // Start is called before the first frame update
    private int nivel;
    public List<Image> portadaNiveles;
    public Text perfil;
    public Image Islot1;
    public Image Islot2;
    public Image Islot3;
    private List<Item> items;
    public Image Islot4;
    private BDItemns bD;
    private string slot1;
    private string slot2;
    private string slot3;
    private string slot4;

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
        perfil.text = PlayerPrefs.GetString("Nick","");
        inventario();
        
    }
    private void inventario()
    {
        bD = BDItemns.Instance;
        if (bD != null)
        {            
            items = bD.getItemsnAll();
            slot1 = PlayerPrefs.GetString("Slot1", "0");
            slot2 = PlayerPrefs.GetString("Slot2", "0");
            slot3 = PlayerPrefs.GetString("Slot3", "0");
            slot4 = PlayerPrefs.GetString("Slot4", "0");
            Item aux1 = items.Find(x => x.id.Equals(slot1));
            Item aux2 = items.Find(x => x.id.Equals(slot2));
            Item aux3 = items.Find(x => x.id.Equals(slot3));
            Item aux4 = items.Find(x => x.id.Equals(slot4));
            if (aux1 != null)
            {
                Islot1.sprite = items.Find(x => x.id.Equals(slot1)).imagen.sprite;
                Islot1.gameObject.active = true;
            }
            if (aux2 != null)
            {
                Islot2.sprite = items.Find(x => x.id.Equals(slot2)).imagen.sprite;
                Islot2.gameObject.active = true;
            }
            if (aux3 != null)
            {
                Islot3.sprite = items.Find(x => x.id.Equals(slot3)).imagen.sprite;
                Islot3.gameObject.active = true;
            }
            if (aux4 != null)
            {
                Islot4.sprite = items.Find(x => x.id.Equals(slot4)).imagen.sprite;
                Islot4.gameObject.active = true;
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
