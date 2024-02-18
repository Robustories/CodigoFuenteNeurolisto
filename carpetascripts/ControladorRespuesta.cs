using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ControladorRespuesta : MonoBehaviour
{
    public AudioClip m_correctSound = null;
    public AudioClip m_incorrectSound = null;
    public Color m_correctColor =Color.black;
    public Color m_incorrectColor =Color.black;
    public GameObject pantallaContinuar;
    public SeleccionarRespuesta seleccionarRespuesta;

    // Start is called before the first frame update
    void Start()
    {
        seleccionarRespuesta = GameObject.FindObjectOfType<SeleccionarRespuesta>();
        
    }

    // Update is called once per frame
    public void GenerarRespuesta()
    {
        seleccionarRespuesta.SetColor(seleccionarRespuesta.Option.correct ? m_correctColor : m_incorrectColor);
    }
}
