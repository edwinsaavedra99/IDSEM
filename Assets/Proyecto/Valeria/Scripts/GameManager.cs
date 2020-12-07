using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]
public class GameManager : MonoBehaviour
{
    [SerializeField] private AudioClip m_correctSound = null;
    [SerializeField] private AudioClip m_incorrectSound = null;
    [SerializeField] private Color m_correctColor = Color.black;
    [SerializeField] private Color m_incorrectColor = Color.black;
    //tiempo de espera entre cada pregunta
    [SerializeField] private float m_waitTime = 0.0f;

    private QuestionDB m_quizDB = null;
    private QuizUI m_quizUI = null;
    private AudioSource m_audioSource = null;
    private int count = 0;
    private string level;

    // Start is called before the first frame update
    public Text namePerfil;
    public float RoundLength = 30f;
    public Text textTimer;

    private float timeKeeper;
    private bool isPaused = false;
    private bool gameIsOver = false;

    private void Start()
    {
        
        m_quizDB = GameObject.FindObjectOfType<QuestionDB>();
        m_quizUI = GameObject.FindObjectOfType<QuizUI>();
        m_audioSource = GetComponent<AudioSource>();
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
            textTimer.text = "" + (int) Math.Round(this.timeKeeper,0);

            if (this.timeKeeper < 0f) DoGameOver();
        }
    }
    void DoGameOver()
    {
        this.gameIsOver = true;
        SceneManager.LoadScene("GameOver");
    }

    private void NextQuestion()
    {
        m_quizUI.Construct(m_quizDB.GetRandom(),GiveAnswer);
        this.timeKeeper = this.RoundLength;
    }

    private void GiveAnswer(OptionButton optionButton)
    {
        if (!this.gameIsOver)
        {
            StartCoroutine(GiveAnswerRoutine(optionButton));
        }
    }
    private IEnumerator GiveAnswerRoutine(OptionButton optionButton)
    {
        if (m_audioSource.isPlaying)
            m_audioSource.Stop();

        //cambio de sonido segun respuesta correcta o incorrecta
        m_audioSource.clip = optionButton.Option.correct ? m_correctSound : m_incorrectSound;

        //cambio de color segun respuesta correcta o incorrecta
        optionButton.SetColor(optionButton.Option.correct ? m_correctColor : m_incorrectColor);

        m_audioSource.Play();
        yield return new WaitForSeconds(m_waitTime);

        if (optionButton.Option.correct)
        {
            
            if (level== "Level_1") {
                count = count + 1;
                if (count == 2)
                    SceneManager.LoadScene("Level_1_2");
                else
                    NextQuestion();
            }
            else if (level == "Level_2")
            {
                count = count + 1;
                if (count == 1)
                    SceneManager.LoadScene("Level_2_1");
                else
                    NextQuestion();
            }
            else if (level == "Level_3")
            {
                count = count + 1;
                if (count == 1)
                    SceneManager.LoadScene("Level_3_1");
                else
                    NextQuestion();
            }
            else if (level == "Level_4")
            {
                count = count + 1;
                if (count == 2)
                    SceneManager.LoadScene("Level_4_2");
                else
                    NextQuestion();
            }
        }

    
            
        else
           DoGameOver();
    }

    /*private void GameOver()
    {
        if (level == "Level_3")

            SceneManager.LoadScene("Level_3");

        else if (level == "Level_2")

            SceneManager.LoadScene("Level_2");

        else if (level == "Level_1")

            SceneManager.LoadScene("Level_1");

        else if (level == "Level_4")
            SceneManager.LoadScene("Level_4");

     
    }*/

}
