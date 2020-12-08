using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isAtacked : MonoBehaviour
{
    public Animator animator;
    public gameControllerFight gameControllerFight;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gameControllerFight.underAtackMonster){
            animator.SetBool("Walk Forward",false);
            animator.SetTrigger("Attack 02");   
        }
        if(!gameControllerFight.underAtackMonster){
            animator.SetBool("Walk Forward",true);
            animator.SetTrigger("StopAttack");   
        }
    }
}
