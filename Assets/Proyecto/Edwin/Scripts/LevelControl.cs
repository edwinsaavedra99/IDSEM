using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelControl : MonoBehaviour
{
    // Start is called before the first frame update
    public Text namePerfil;
    public float RoundLength = 30f;
    public Text textTimer;

    private float timeKeeper;
    private bool isPaused = false;
    private bool gameIsOver = false;

    void Start()
    {
        namePerfil.text = PlayerPrefs.GetString("Nick", "");
        this.timeKeeper = this.RoundLength;
    }

    // Update is called once per frame
    void Update()
    {
        if (!this.isPaused && !this.gameIsOver)
        {
            this.timeKeeper -= Time.deltaTime;
            textTimer.text = ""+ this.timeKeeper;

            if (this.timeKeeper < 0f) DoGameOver();
        }
    }
    void DoGameOver()
    {
        this.gameIsOver = true;
    }
}
