using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Damage : MonoBehaviour
{
    // Start is called before the first frame update
    
    //public GameObject winDisplay;
    //public GameObject loseDisplay;
    private bool isPunch;
    public Animator anim;
    public gameControllerFight gameControllerFight;
    Vector3 initialPosition;

    void Start()
    {
        this.isPunch =false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)){
            Debug.Log("Pressed primary button.");
            anim.SetBool("Attack",true);
            this.isPunch =true;
            SoundController.Instance.punchPlayer();
        }
        if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("Pressed left click.");
            this.isPunch =false;
            anim.SetBool("Attack",false);
        }
        if (Input.GetMouseButtonDown(1))
            Debug.Log("Pressed secondary button.");

        if (Input.GetMouseButtonDown(2))
            Debug.Log("Pressed middle click.");
    }
    
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Enemy" )
        {
            gameControllerFight.underAtackMonster =true;
            gameControllerFight.tiempoDisparador = Time.time + gameControllerFight.tiempoCouldDownMonster;

            if(isPunch == true){
            Debug.Log("PlAyer hace daño");
                gameControllerFight.reducirVidaEnemigo();       
            }
        }
        if(collider.tag =="Wall"){
            reIntent();
        }       
    }
    private void OnTriggerExit2D(Collider2D other) {
        gameControllerFight.underAtackMonster = false;
    }
    public void getHurt(){
        anim.SetTrigger("Hurt");
        anim.SetFloat ("Speed", 0);
        if(gameControllerFight.MonsterDireccion ==2 ){
            transform.position += new Vector3(-gameControllerFight.backknock,0,0);
        }
        if(gameControllerFight.MonsterDireccion == 1){
            transform.position += new Vector3(gameControllerFight.backknock,0,0);
        }
        
        Debug.Log("animacion de daño");
    }
    public void getDead(){
        anim.SetBool("Dead",true);
        anim.SetFloat ("Speed", 0);
    }
    public void reIntent(){
        transform.position = new Vector3(0,4,0);
    }
}
