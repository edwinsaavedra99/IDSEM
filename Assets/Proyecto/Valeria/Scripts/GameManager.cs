﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
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

    private void Start()
    {
        m_quizDB = GameObject.FindObjectOfType<QuestionDB>();
        m_quizUI = GameObject.FindObjectOfType<QuizUI>();
        m_audioSource = GetComponent<AudioSource>();
            NextQuestion();
    }
    private void NextQuestion()
    {
        m_quizUI.Construct(m_quizDB.GetRandom(),GiveAnswer);
    }

    private void GiveAnswer(OptionButton optionButton)
    {
        StartCoroutine(GiveAnswerRoutine(optionButton));
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