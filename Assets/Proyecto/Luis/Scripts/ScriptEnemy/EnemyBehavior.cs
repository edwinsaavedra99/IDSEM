using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    public float visionRadious;
    
    private float variable;
    public float speed;
    public GameObject player;
    Vector3 initialPosition; 

    // Start is called before the first frame update
    void Start()
    {
        //player = GameObject.FindGameObjectWithTag("Player");
        initialPosition = transform.position;
        this.variable = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 target = initialPosition;
        float dist = Vector3.Distance(player.transform.position, transform.position);
        if (dist < visionRadious)
        {
            target = player.transform.position;
        }
        if( transform.position.x >= variable ) {
            transform.rotation = Quaternion.Euler(0,0,0);
        }else{
           transform.rotation = Quaternion.Euler(0,180,0);
        }
        this.variable = transform.position.x;

        float fixedSpeed = speed*Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target, fixedSpeed);
        Debug.DrawLine(transform.position, target, Color.green); 

    }
}
