using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Game3 : MonoBehaviour
{
    public GameObject Imagen1, Imagen2, Imagen3, Imagen4, im1, im2, im3, im4;
    //tiempo de espera entre cada pregunta
    [SerializeField] private float m_waitTime = 0.0f;

    private QuestionDB2 m_quizDB = null;
    private QuizUI2 m_quizUI = null;
    public AudioSource source;
    public AudioClip correct;
    public AudioClip incorrect;
    private int count = 0;
    private string level;
    Vector2 Imagen1InitialPos, Imagen2InitialPos, Imagen3InitialPos, Imagen4InitialPos;

    // Start is called before the first frame update
    public Text namePerfil;
    public float RoundLength = 30f;
    public Text textTimer;

    private float timeKeeper;
    private bool isPaused = false;
    private bool gameIsOver = false;

    private void Start()
    {
        m_quizDB = GameObject.FindObjectOfType<QuestionDB2>();
        m_quizUI = GameObject.FindObjectOfType<QuizUI2>();
    
    
        Imagen1InitialPos = Imagen1.transform.position;
        Imagen2InitialPos = Imagen2.transform.position;
        Imagen3InitialPos = Imagen3.transform.position;
        Imagen4InitialPos = Imagen4.transform.position;
        level = Application.loadedLevelName;
        NextQuestion();
        namePerfil.text = PlayerPrefs.GetString("Nick", "");
        this.timeKeeper = this.RoundLength;
    }

    // Update is called once per frame
    void Update()
    {
        if (!this.isPaused && !this.gameIsOver)
        {
            this.timeKeeper -= Time.deltaTime;
            textTimer.text = "" + (int)Math.Round(this.timeKeeper, 0);
            if (this.timeKeeper < 0f) DoGameOver();
            if (level == "Level_3_1")
            {
                if (count == 3)
                    SceneManager.LoadScene("Level_3_2");
                /*else
                    DoGameOver();*/
            }
            else if (level == "Level_3_2")
            {
                if (count == 3)
                    SceneManager.LoadScene("Recompensas");
                /*else
                    DoGameOver();*/
            }
            else if (level == "Level_2_1")
            {
                if (count == 4)
                    SceneManager.LoadScene("Level_2_2");
                /*else
                    DoGameOver();*/
            }
            else if (level == "Level_2_2")
            {
                if (count == 4)
                    SceneManager.LoadScene("Recompensas");
                /*else
                    DoGameOver();*/
            }
            else if (level == "Level_1_2")
            {
                if (count == 4)
                    SceneManager.LoadScene("Recompensas");
                /*else
                    DoGameOver();*/
            }
            else if (level == "Level_4_2")
            {
                SceneManager.LoadScene("Recompensas");

            }

        }
    }
    void DoGameOver()
    {
        this.gameIsOver = true;
        //StopAllCoroutines();
        SceneManager.LoadScene("GameOver");
    }

    private void NextQuestion()
    {
        m_quizUI.Construct(m_quizDB.GetRandom());
        //StartCoroutine(GiveAnswerRoutine());
    }

   
    private IEnumerator GiveAnswerRoutine()
    {
        yield return new WaitForSeconds(m_waitTime);
        DoGameOver();

        /*if (level == "Level_3_1")
        {
            if (count == 3)
                SceneManager.LoadScene("Level_3_2");
            else
                GameOver();
        }
        else if (level == "Level_3_2")
        {
            if (count == 3)
                SceneManager.LoadScene("Level_4");
            else
                GameOver();
        }
        else if (level == "Level_2_1")
        {
            if (count == 4)
                SceneManager.LoadScene("Level_2_2");
            else
                GameOver();
        }
        else if (level == "Level_2_2")
        {
            if (count == 4)
                SceneManager.LoadScene("Level_3");
            else
                GameOver();
        }
        else if (level == "Level_1_2")
        {
            if (count == 4)
                SceneManager.LoadScene("Recompensas");
            else
                GameOver();
        }
        else if (level == "Level_4_2")
        {
            SceneManager.LoadScene("Level_1");

        }*/
     }

    /*private void GameOver()
    {

        if (level == "Level_3_1")
        
                SceneManager.LoadScene("Level_3");
             
        else if (level == "Level_3_2")
        
                SceneManager.LoadScene("Level_3");
       
        else if (level == "Level_2_1")
       
                SceneManager.LoadScene("Level_2");
       
        else if (level == "Level_2_2")
                SceneManager.LoadScene("Level_2");
      
        else if (level == "Level_1_2")
                SceneManager.LoadScene("Niveles");

        else if (level == "Level_4_1")
            SceneManager.LoadScene("Level_4");

         //me lleva a la primera escena
      //  SceneManager.LoadScene(0);
    }*/
    public void dragImagen1()
    {
        Imagen1.transform.position = Input.mousePosition;

    }
    public void dragImagen2()
    {
        Imagen2.transform.position = Input.mousePosition;

    }
    public void dragImagen3()
    {
        Imagen3.transform.position = Input.mousePosition;

    }
    public void dragImagen4()
    {
        Imagen4.transform.position = Input.mousePosition;
    }

    public void dropImagen1()
    {
        float Distance = Vector3.Distance(Imagen1.transform.position, im1.transform.position);
        if (Distance < 40)
        {
            Imagen1.transform.position = im1.transform.position;
            source.clip = correct;
            source.Play();
            count = count + 1;
        }
        else
        {
            Imagen1.transform.position = Imagen1InitialPos;
            source.clip = incorrect;
            source.Play();
            StartCoroutine(GiveAnswerRoutine());
        }
    }
    public void dropImagen2()
    {
        float Distance = Vector3.Distance(Imagen2.transform.position, im2.transform.position);
        if (Distance < 50)
        {
            Imagen2.transform.position = im2.transform.position;
            source.clip = correct;
            source.Play();
            count = count + 1;

        }
        else
        {
            Imagen2.transform.position = Imagen2InitialPos;
            source.clip = incorrect;
            source.Play();
            StartCoroutine(GiveAnswerRoutine());
        }
    }
    public void dropImagen3()
    {
        float Distance = Vector3.Distance(Imagen3.transform.position, im3.transform.position);
        if (Distance < 50)
        {
            Imagen3.transform.position = im3.transform.position;
            source.clip = correct;
            source.Play();
            count = count + 1;
        }
        else
        {
            Imagen3.transform.position = Imagen3InitialPos;
            source.clip = incorrect;
            source.Play();
            StartCoroutine(GiveAnswerRoutine());
        }
    }
    public void dropImagen4()
    {
        float Distance = Vector3.Distance(Imagen4.transform.position, im4.transform.position);
        if (Distance < 50)
        {
            Imagen4.transform.position = im4.transform.position;
            source.clip = correct;
            source.Play();
            count = count + 1;
        }
        else
        {
            Imagen4.transform.position = Imagen4InitialPos;
            source.clip = incorrect;
            source.Play();
            StartCoroutine(GiveAnswerRoutine());
        }
    }

}
