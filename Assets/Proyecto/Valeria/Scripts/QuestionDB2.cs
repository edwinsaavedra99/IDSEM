using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionDB2 : MonoBehaviour
{
    [SerializeField] private List<Question2> mk_questionList = null;

    //para no perder preguntas
    private List<Question2> m_backup = null;
    private void Awake()
    {
        m_backup = mk_questionList.ToList();
    }

    //indica que se remueve la pregunta en la base de datos para que no vuelva a aparecer posteriormente
    public Question2 GetRandom(bool remove = true)
    {
        //en caso se nos acaben las preguntas, restauramos la bd
        if (mk_questionList.Count == 0)
            RestoreBackup();

        int index = Random.Range(0, mk_questionList.Count);

        if (!remove)
            return mk_questionList[index];

        Question2 q = mk_questionList[index];
        mk_questionList.RemoveAt(index);
        return q;
    }

    //en caso se desee y se vayan borrando preguntas
    private void RestoreBackup()
    {
        mk_questionList = m_backup;

    }
}
