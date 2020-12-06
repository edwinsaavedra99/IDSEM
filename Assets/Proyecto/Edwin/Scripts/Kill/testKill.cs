using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testKill : MonoBehaviour
{
    // Start is called before the first frame update

    //private BDItemns bD;
    private List<Item> items;
    private string slot1;
    private string slot2;
    private string slot3;
    private string slot4;
    void Start()
    {
        items = BDItemns.items;
        slot1 = PlayerPrefs.GetString("Slot1","0");
        slot2 = PlayerPrefs.GetString("Slot2", "0");
        slot3 = PlayerPrefs.GetString("Slot3", "0");
        slot4 = PlayerPrefs.GetString("Slot4", "0");
        //validar que si es igual a cero - no se guardo el item -- error
        //Debug.Log(slot1);
        //Debug.Log(items[0].id);


        Debug.Log(items.Find(x => x.id.Equals(slot1)).nombre);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
