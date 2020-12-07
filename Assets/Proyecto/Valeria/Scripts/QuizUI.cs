using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizUI : MonoBehaviour
{
    [SerializeField] private Text m_question = null;
    [SerializeField] private Image m_question_image = null;
    [SerializeField] private List<OptionButton> m_buttonList = null;

    public void Construct(Question q, Action<OptionButton> callback)
    {
        m_question.text = q.text;
        m_question_image.gameObject.active = false;
        if (q.imageanexa != null)
        {
            m_question_image.gameObject.active = true;
            m_question_image.sprite = q.imageanexa.sprite;

        }

        for(int n = 0; n < m_buttonList.Count; n++)
        {
            m_buttonList[n].Construct(q.options[n], callback);
        }
    }
}
