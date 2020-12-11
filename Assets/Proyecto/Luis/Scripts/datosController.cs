using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class datosController : MonoBehaviour
{
    // Start is called before the first frame update

    public static int Vitality = 1000 ; //100 base + n añadidos, incrementa la vida del jugador
    public static int Resistance = 50 ;  //10 base + n añadidos, va a ser reducido del daño del enemigo 
    public static int Damage = 60; // 20 base + n añaidos , aumenta el daño inflinjido del player
    void Start()
    {
        
    }
    void Awake() {
        //actualizar datos :v 
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
