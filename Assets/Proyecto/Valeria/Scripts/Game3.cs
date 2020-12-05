using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
[RequireComponent(typeof(AudioSource))]
public class Game3 : MonoBehaviour
{
   
    //tiempo de espera entre cada pregunta
    [SerializeField] private float m_waitTime = 0.0f;

    private QuestionDB2 m_quizDB = null;
    private QuizUI2 m_quizUI = null;
   

    private void Start()
    {
        m_quizDB = GameObject.FindObjectOfType<QuestionDB2>();
        m_quizUI = GameObject.FindObjectOfType<QuizUI2>();
        NextQuestion();
    }
    private void NextQuestion()
    {
        m_quizUI.Construct(m_quizDB.GetRandom(), GiveAnswer);
    }

    private void GiveAnswer(OptionButton2 optionButton)
    {
        StartCoroutine(GiveAnswerRoutine(optionButton));
    }
    private IEnumerator GiveAnswerRoutine(OptionButton2 optionButton)
    {
    
   
        yield return new WaitForSeconds(m_waitTime);

        if (optionButton.Option2.id==2)
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
