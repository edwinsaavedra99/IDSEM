using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class datosController : MonoBehaviour
{
    // Start is called before the first frame update

    public static int Vitality = 300 ; //100 base + n añadidos, incrementa la vida del jugador
    public static int Resistance = 0 ;  //10 base + n añadidos, va a ser reducido del daño del enemigo 
    public static int Damage = 60; // 20 base + n añaidos , aumenta el daño inflinjido del player
    private BDItemns bD;
    private string slot1;
    private string slot2;
    private string slot3;
    private string slot4;
    private List<Item> items;
    void Start()
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
            Debug.Log (aux1.atributo +"  " + aux1.puntos);
            Debug.Log (aux2.atributo +"  " + aux2.puntos);
            Debug.Log (aux3.atributo +"  " + aux3.puntos);
            Debug.Log (aux4.atributo +"  " + aux4.puntos);
            
            //comparacion fuerza bruta , tengo sueño , ya ps con el modelo de datos :'v
            asignAttribute(aux1);
            asignAttribute(aux2);
            asignAttribute(aux3);
            asignAttribute(aux4);

            

        }else{
         Debug.Log ("database not found");   
        }
        
    }
    void Awake() {
        //actualizar datos :v 
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    void asignAttribute(Item aux){
        if(aux.atributo.Equals("inteligencia") ){
            Resistance  = Resistance+ aux.puntos;      
        }
        if(aux.atributo.Equals("Agilidad") ){
            Damage  = Damage + aux.puntos;      
        }
        if(aux.atributo.Equals("fuersa") ){
            Vitality  = Vitality + aux.puntos;      
        }
    }
}
