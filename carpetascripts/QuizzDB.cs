using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizzDB : MonoBehaviour
{
    [SerializeField] private List<Question> m_questionList = null;

    private List<Question> m_backup = null;
    public GameObject pantallaContinuar;
    private int valormodificable;

    private void Awake()
    {
        m_backup = m_questionList.ToList();

    }

    public Question GetRandom(bool remove = true)
    {
        if(m_questionList.Count == 0)
        {pantallaContinuar.gameObject.SetActive(true);
         }
        //RestoreBackup();

        int index = Random.Range(0, m_questionList.Count);
        Debug.Log(index);

        if(!remove)
        return m_questionList[index];

        Question q = m_questionList[index];
        m_questionList.RemoveAt(index);

        return q;

    }

    public Question GetOrder(bool remove = true)
    {
        if(m_questionList.Count == 0)
        {Invoke("FinalizarQuizz", 1.0f);;
         }
        //RestoreBackup();

        //valormodificable--;

        int valormodificable = 0;

        if(!remove)
        return m_questionList[valormodificable];
        Debug.Log(valormodificable);

        Question q = m_questionList[valormodificable];
        m_questionList.RemoveAt(valormodificable);

        return q;

    }

    

    public Question GuardarElemento(bool remove = true)
    {
        if(m_questionList.Count == 0)
        {pantallaContinuar.gameObject.SetActive(true);
         }
        //RestoreBackup();

        //valormodificable--;


        int valormodificable = Random.Range(0, m_questionList.Count);
        Debug.Log(valormodificable);

        if(!remove)
        return m_questionList[valormodificable];
        Debug.Log(valormodificable);

        Question q = m_questionList[valormodificable];
        
        

        return q;


    }

    //private void RestoreBackup()  => Repetir preguntas
    //{
    //    m_questionList = m_backup.ToList();
    //}

    public Question RespuestaCorrecta(bool remove = true)
    {

        m_questionList.RemoveAt(valormodificable);

    
        GetRandom();

        if(!remove)
        return m_questionList[valormodificable];
        Debug.Log(valormodificable);


        Question q = m_questionList[valormodificable];
        

        return q;
        
    }

    public Question RespuestaInCorrecta(bool remove = true)
    {
        GuardarElemento();

        if(!remove)
        return m_questionList[valormodificable];

        Question q = m_questionList[valormodificable];
        

        return q;


        
    }

    public Question PrimeraVez(bool remove = true)
    {
        if(m_questionList.Count == 0)
        {pantallaContinuar.gameObject.SetActive(true);
         }
        //RestoreBackup();

        //valormodificable--;

        int valormodificable = 0;
        
        Debug.Log(valormodificable);

        if(!remove)
        return m_questionList[valormodificable];
        Debug.Log(valormodificable);

        Question q = m_questionList[valormodificable];
        
        

        return q;


    }

    void FinalizarQuizz()
    {
        pantallaContinuar.gameObject.SetActive(true);
    }
}
