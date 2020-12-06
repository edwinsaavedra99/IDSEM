using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game3 : MonoBehaviour
{
    [SerializeField] private AudioClip m_correctSound = null;
    [SerializeField] private AudioClip m_incorrectSound = null;
    [SerializeField] private Color m_correctColor = Color.black;
    [SerializeField] private Color m_incorrectColor = Color.black;
    //tiempo de espera entre cada pregunta
    [SerializeField] private float m_waitTime = 0.0f;

    private QuestionDB2 m_quizDB = null;
    private QuizUI2 m_quizUI = null;
    private AudioSource m_audioSource = null;
    public Manager manager = null;
    private bool ganar;

    private void Start()
    {
        m_quizDB = GameObject.FindObjectOfType<QuestionDB2>();
        m_quizUI = GameObject.FindObjectOfType<QuizUI2>();
        manager = GameObject.FindObjectOfType<Manager>();
        m_audioSource = GetComponent<AudioSource>();
        NextQuestion();
    }
    private void NextQuestion()
    {
        m_quizUI.Construct(m_quizDB.GetRandom());
        StartCoroutine(GiveAnswerRoutine());
    }

   
    private IEnumerator GiveAnswerRoutine()
    {
        yield return new WaitForSeconds(m_waitTime);
        if (m_audioSource.isPlaying)
            m_audioSource.Stop();
      
        //cambio de sonido segun respuesta correcta o incorrecta
        m_audioSource.clip = ganar ? m_correctSound : m_incorrectSound;

        //cambio de color segun respuesta correcta o incorrecta
       // optionButton.SetColor(ganar ? m_correctColor : m_incorrectColor);

        m_audioSource.Play();
        

        if (manager.count == 0)
            NextQuestion();
        else
            GameOver();
    }

    private void GameOver()
    {
        //me lleva a la primera escena
        SceneManager.LoadScene(0);
    }

}
