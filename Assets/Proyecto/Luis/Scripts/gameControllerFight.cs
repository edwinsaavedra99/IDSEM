using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameControllerFight : MonoBehaviour
{
    // Start is called before the first frame update
    public bool underAtackMonster;
    public float tiempoDisparador=-1;
    public float tiempoCouldDownMonster;
    public int MonsterDireccion=2;
    public float backknock;

    // animaciones de daño y muerte
    public Damage Player;    

    //
    public Text lifeDisplayText;
    public Text enemyDisplayText;
    public Text messageDisplayText; //food
    //public Text foodDislayText; //food
    public int lifepoints;
    public int enemypointsinit=1000;//food
    public Slider lifeSlider;
    public Slider enemySlider;
    public int enemyDamage=100;
    public int playerDamage;
    public bool endGame;
    public GameObject winDisplay;
    public GameObject loseDisplay;
    
       
    void Start()
    {
        //datos 
        playerDamage = datosController.Damage;
        lifepoints = datosController.Vitality;
        enemyDamage = enemyDamage - datosController.Resistance ;
        //sotad 


        SoundController.Instance.rugidoEnemy();
        this.MonsterDireccion = 2;
        
        this.lifeSlider.minValue = 0;
        this.lifeSlider.maxValue = lifepoints;
        this.lifeSlider.value = lifepoints;
        this.lifeDisplayText.text = "" + lifepoints;

        this.enemySlider.minValue = 0;
        this.enemySlider.maxValue = enemypointsinit;
        this.enemySlider.value = enemypointsinit;
        this.enemyDisplayText.text = ""+enemypointsinit;

        this.underAtackMonster = false;
        this.endGame = false;
    }

    // Update is called once per frame
    void Update() {
        if(lifepoints <=0 ){
            this.endGame =true;
            this.Player.getDead();
            SoundController.Instance.loseGame();
            loseDisplay.SetActive(true);
        }
        if(enemypointsinit <=0){
            this.endGame = true;
            SoundController.Instance.winGame();
            winDisplay.SetActive(true);
            
        }
        
        
    }
    void FixedUpdate()
    {
        if(Time.time > tiempoDisparador ){
            if(this.underAtackMonster){
            reducirVidaPlayer();
            }
        }
        

    }
    public void reducirVidaPlayer(){
        this.lifepoints = this.lifepoints - this.enemyDamage;
        this.lifeDisplayText.text = "" + lifepoints;
        this.lifeSlider.value = lifepoints;
        this.Player.getHurt();
        SoundController.Instance.rugidoEnemy();
        this.tiempoDisparador = Time.time + this.tiempoCouldDownMonster;

    }
    public void reducirVidaEnemigo(){
        this.enemypointsinit = this.enemypointsinit - this.playerDamage;
        this.enemyDisplayText.text = "" + enemypointsinit;
        this.enemySlider.value = enemypointsinit;
        //SoundController.Instance.painEnemy();
        
            
    }
}

