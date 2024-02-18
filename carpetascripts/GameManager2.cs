using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
[RequireComponent(typeof(AudioSource))]

public class GameManager2 : MonoBehaviour
{
    [SerializeField]private AudioClip m_correctSound = null;
    [SerializeField]private AudioClip m_incorrectSound = null;
    [SerializeField]private Color m_correctColor =Color.black;
    [SerializeField]private Color m_incorrectColor =Color.black;
    [SerializeField]private float m_waitTime = 0.0f;
    [SerializeField]private AudioSource questionAudio;



    private QuizzDB m_quizzDB = null;
    private QuizzUI m_quizzUI = null;
    private AudioSource m_audioSource = null;

    public GameObject pantallaContinuar;
    public GameObject juegoTerminado;

    private void Start()
    {
        m_quizzDB = GameObject.FindObjectOfType<QuizzDB>();
        m_quizzUI = GameObject.FindObjectOfType<QuizzUI>();
        m_audioSource = GetComponent<AudioSource>();

        pantallaContinuar.gameObject.SetActive(false);
        juegoTerminado.gameObject.SetActive(false);

        NextQuestion();
    }

    private void NextQuestion()
    {
        m_quizzUI.Construct(m_quizzDB.GetRandom() , GiveAnswer);

    }

    private void SaveQuestion()
    {
        m_quizzUI.Construct(m_quizzDB.GuardarElemento() , GiveAnswer);

    }

    private void PorOrden()
    {
        m_quizzUI.Construct(m_quizzDB.GetOrder() , GiveAnswer);

    }

    private void ResponderBien()
    {
        m_quizzUI.Construct(m_quizzDB.RespuestaCorrecta(), GiveAnswer);

    }

    private void ResponderMal()
    {
        m_quizzUI.Construct(m_quizzDB.RespuestaInCorrecta(), GiveAnswer);

    }

    private void PrimeraPregunta()
    {
        m_quizzUI.Construct(m_quizzDB.PrimeraVez(), GiveAnswer);

    }

    private void GiveAnswer(OptionButton optionButton)
    {
        StartCoroutine(GiveAnswerRoutine(optionButton));


    }

    private IEnumerator GiveAnswerRoutine(OptionButton optionButton)
    {
        if(m_audioSource.isPlaying)
        m_audioSource.Stop();
        Debug.Log("Sonido pausado");

        m_audioSource.clip = optionButton.Option.correct ? m_correctSound : m_incorrectSound;
        optionButton.SetColor(optionButton.Option.correct ? m_correctColor : m_incorrectColor);
        m_audioSource.Play();

        yield return new WaitForSeconds( m_waitTime);

        if(optionButton.Option.correct)
        NextQuestion();
        else
        SaveQuestion();
        

    }

    private void GameOver()
    {
        SceneManager.LoadScene(0);

    }



}
