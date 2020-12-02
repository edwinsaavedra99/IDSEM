using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Required when Using UI elements.

public class SimpleGirlMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator animator;
    //public Action actualAction = Action.Idle;
    //int actualAnim = (int)Action.Idle;
    private const float SPEED = 5f;
    //public Animator animator;
    public Text lifeDisplayText;
    public Text enemyDisplayText;
    public Text messageDisplayText; //food
    //public Text foodDislayText; //food
    public int lifepoints;
    public int enemypointsinit;//food
    public Slider lifeSlider;
    public Slider enemySlider;
    public int enemyDamage;
    public GameObject winDisplay;
    public GameObject loseDisplay;
    void Start()
    {
        this.lifeSlider.minValue = 0;
        this.lifeSlider.maxValue = lifepoints;
        this.lifeSlider.value = lifepoints;
        this.lifeDisplayText.text = "" + lifepoints;

        this.enemySlider.minValue = 0;
        this.enemySlider.maxValue = enemypointsinit;
        this.enemySlider.value = enemypointsinit;
        this.enemyDisplayText.text = ""+enemypointsinit;
    }

    // Update is called once per frame
    void Update()
    {
        HandleMovement();
        if (lifepoints <= 0)
        {
            Debug.Log("Perdiste");
            //this.animator.SetTrigger("sleepGirl");
            loseDisplay.SetActive(true);
        }
        if (enemypointsinit <= 0) {
            Debug.Log("Ganaste");
            this.winDisplay.SetActive(true);
        }
    }

    private void HandleMovement()
    {
        float moveX = 0f;
        float moveY = 0f;
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            //this.animator.SetTrigger("atackGirl");
            //moveY = +1f;
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            //this.animator.SetTrigger("atackGirl");
            //moveY = -1f;
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.rotation = Quaternion.Euler(0,180,0);
            this.animator.SetTrigger("isWalking");
            moveX = -1f;
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.rotation = Quaternion.Euler(0,0,0);
            this.animator.SetTrigger("isWalking");
            moveX = +1f;
        }
        
        Vector3 moveDir = new Vector3(moveX, moveY).normalized;

        transform.position += moveDir * SPEED * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Enemy" )
        {
            Debug.Log("muere como enemigo");
             this.lifepoints = this.lifepoints - this.enemyDamage;
            this.lifeDisplayText.text = "" + lifepoints;
            this.lifeSlider.value = lifepoints;
            Destroy(collider.gameObject);
        }
        if(collider.tag == "Message")
        {
            Debug.Log("mensanje");
            this.messageDisplayText.text = "";
        }
        
        
    }
}
