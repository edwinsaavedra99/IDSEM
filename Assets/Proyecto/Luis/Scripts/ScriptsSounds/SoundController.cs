using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    // Start is called before the first frame update

    public AudioClip AudioClipPunchPlayer;
    public AudioClip AudioClipBitEnemy;
    public AudioClip AudioClipRugidoEnemy;
    public AudioClip AudioClipPainEnemy;
    public AudioClip AudioClipWin;
    public AudioClip AudioClipLose;
    public AudioSource audioSource;
    private bool isSound = false;
    public static SoundController Instance;
    private void Awake() {
        Instance = this ;
    }
    
    public void punchPlayer(){
        audioSource.PlayOneShot(this.AudioClipPunchPlayer,1.5F);
    }
    public void bitEnemy(){
         audioSource.PlayOneShot(this.AudioClipBitEnemy,0.8F );
    }
    public void rugidoEnemy(){
         audioSource.PlayOneShot(this.AudioClipRugidoEnemy,0.8F );
    }
    public void painEnemy(){
         audioSource.PlayOneShot(this.AudioClipPainEnemy);
    }
    public void winGame(){
        //this.audioSource.PlayOneShot(this.AudioClipWin,5F);
    }
    public void loseGame(){
        this.audioSource.PlayOneShot(this.AudioClipLose,2F);
        
    }
}

