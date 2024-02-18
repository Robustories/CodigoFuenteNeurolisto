using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizzUI : MonoBehaviour
{
    [SerializeField] private Text m_question = null;
    [SerializeField] private Image m_imagenPregunta = null;
    [SerializeField] private Image m_imagenPregunta2 = null;
    [SerializeField] private Image m_imagenPregunta3 = null;
    [SerializeField] private Image m_imagenPregunta4 = null;
    [SerializeField] private Image m_imagenPregunta5 = null;
    [SerializeField] private Image m_imagenPregunta6 = null;
    [SerializeField] private Image m_imagenPregunta7 = null;
    [SerializeField] private Image m_imagenPregunta8 = null;
    [SerializeField] private Image m_imagenPregunta9 = null;
    [SerializeField] private Image m_imagenPregunta10 = null;
    [SerializeField] private Image m_imagenPregunta11 = null;
    [SerializeField] private Image m_imagenPregunta12 = null;
    [SerializeField] private Image m_imagenPregunta13 = null;
    [SerializeField] private Image m_imagenPregunta14 = null;
    [SerializeField] private Image m_imagenPregunta15 = null;
    [SerializeField] private Image m_imagenPregunta16 = null;
    [SerializeField] private Image m_imagenPregunta17 = null;
    [SerializeField] private Image m_imagenPregunta18 = null;
    [SerializeField] private Image m_imagenPregunta19 = null;
    [SerializeField] private Image m_imagenPregunta20 = null;
    [SerializeField] private Image m_imagenPregunta21 = null;

    [SerializeField] private Image m_imagenRespuesta = null;
    [SerializeField] private AudioClip m_sonidoPregunta = null;
    [SerializeField] private List<OptionButton> m_buttonList = null;
    [SerializeField] private Text m_timer = null;
    [SerializeField] private float tiempoLimite = 0f;
    [SerializeField] private float m_tiempoactual = 0f;
    [SerializeField] public GameObject juegoTerminado;
    [SerializeField] public GameObject generadorAudio;
    [SerializeField] private AudioSource m_audioSource = null;
    public Button btn {get {return GetComponent<Button> ();}}
    

    void Start()
    {
        generadorAudio.AddComponent<AudioSource> ();

        //btn.onClick.AddListener (PlaySound);
        
    }


    public void Construct(Question q , Action<OptionButton> callback)
    {
        tiempoLimite = q.tiempoPregunta;
        m_tiempoactual = q.tiempoPregunta;

        
        
        m_question.text = q.text;
        m_sonidoPregunta = q.sonidoPregunta;

        
        
        


        for (int n = 0; n < m_buttonList.Count; n++)
        {
            m_buttonList[n].Construct(q.options[n], callback);
        }

        m_imagenPregunta.GetComponent<Image>().sprite = q.imagenPregunta;
        m_imagenPregunta2.GetComponent<Image>().sprite = q.imagenPregunta2;
        m_imagenPregunta3.GetComponent<Image>().sprite = q.imagenPregunta3;
        m_imagenPregunta4.GetComponent<Image>().sprite = q.imagenPregunta4;
        m_imagenPregunta5.GetComponent<Image>().sprite = q.imagenPregunta5;
        m_imagenPregunta6.GetComponent<Image>().sprite = q.imagenPregunta6;
        m_imagenPregunta7.GetComponent<Image>().sprite = q.imagenPregunta7;
        m_imagenPregunta8.GetComponent<Image>().sprite = q.imagenPregunta8;
        m_imagenPregunta9.GetComponent<Image>().sprite = q.imagenPregunta9;
        m_imagenPregunta10.GetComponent<Image>().sprite = q.imagenPregunta10;
        m_imagenPregunta11.GetComponent<Image>().sprite = q.imagenPregunta11;
        m_imagenPregunta12.GetComponent<Image>().sprite = q.imagenPregunta12;
        m_imagenPregunta13.GetComponent<Image>().sprite = q.imagenPregunta13;
        m_imagenPregunta14.GetComponent<Image>().sprite = q.imagenPregunta14;
        m_imagenPregunta15.GetComponent<Image>().sprite = q.imagenPregunta15;
        m_imagenPregunta16.GetComponent<Image>().sprite = q.imagenPregunta16;
        m_imagenPregunta17.GetComponent<Image>().sprite = q.imagenPregunta17;
        m_imagenPregunta18.GetComponent<Image>().sprite = q.imagenPregunta18;
        m_imagenPregunta19.GetComponent<Image>().sprite = q.imagenPregunta19;
        m_imagenPregunta20.GetComponent<Image>().sprite = q.imagenPregunta20;
        m_imagenPregunta21.GetComponent<Image>().sprite = q.imagenPregunta21;

        m_imagenRespuesta.GetComponent<Image>().sprite = q.imagenRespuesta;
        m_audioSource.Stop();
        m_audioSource.PlayOneShot(q.sonidoPregunta);

        
        


    }

     void Update()
    {
    m_tiempoactual -= 1 * Time.deltaTime;
    m_timer.text = m_tiempoactual.ToString("0");
    
    }

    private void GameOver()
    {
        if(m_tiempoactual == 0)
        {juegoTerminado.gameObject.SetActive(true); }

    }

    

    

    
    
        
    



   
}
