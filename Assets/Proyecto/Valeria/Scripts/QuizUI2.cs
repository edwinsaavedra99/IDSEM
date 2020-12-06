using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizUI2 : MonoBehaviour
{
    [SerializeField] private Text m_question = null;
    [SerializeField] private List<OptionButton2> m_buttonList = null;

    public void Construct(Question2 q)
    {
        m_question.text = q.text;
        for (int n = 0; n < m_buttonList.Count; n++)
        {
            m_buttonList[n].Construct(q.options[n]);
        }
    }
}
