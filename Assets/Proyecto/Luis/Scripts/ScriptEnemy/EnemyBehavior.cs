using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    public float visionRadious;
    
    private float variable;
    public float speed;
    private float remainspeed;
    public GameObject player;
    Vector3 initialPosition;
    public gameControllerFight gameControllerFight; 

    // Start is called before the first frame update
    void Start()
    {
        remainspeed = speed;
        transform.rotation = Quaternion.Euler(0,-135,0);
        //player = GameObject.FindGameObjectWithTag("Player");
        initialPosition = transform.position;
        this.variable = transform.position.x;
    }
    void Update() {
        
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if( !gameControllerFight.endGame){
        Vector3 target = initialPosition;
        float dist = Vector3.Distance(player.transform.position, transform.position);
        if (dist < visionRadious)
        {
            target = player.transform.position;
        }
        if( transform.position.x >= variable ) {
            gameControllerFight.MonsterDireccion =1;
            transform.rotation = Quaternion.Euler(0,135,0);
        }else{
            gameControllerFight.MonsterDireccion =2;
            transform.rotation = Quaternion.Euler(0,-135,0);
        }
        //change if its necesary, delete just the if condition
        if(!gameControllerFight.underAtackMonster ){
            this.variable = transform.position.x;
            float fixedSpeed = speed*Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, target, fixedSpeed);
            Debug.DrawLine(transform.position, target, Color.green); 

        }
        }
        

    }
}
