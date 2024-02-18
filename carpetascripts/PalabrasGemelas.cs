using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PalabrasGemelas : MonoBehaviour
{
    public GameObject pantallaContinuarg;
    public GameObject textosRespuesta;
    public Sprite palabra1;
    public Sprite palabra2;
    public GameObject palabrad;
    public GameObject palabrai;
    public GameObject botonp1;
    public GameObject botonp2;
    public Renderer render11;
    public Renderer render12;
    // Start is called before the first frame update
    void Start()
    {
        pantallaContinuarg.gameObject.SetActive(false); 
        palabrad.gameObject.SetActive(false); 
        palabrai.gameObject.SetActive(false); 
        
    }

    public void RespuestaAcertada()
    {
        Invoke ("OcultarBotones", 0.1f);
        Invoke ("Continuar", 3.0f);

    }

    public void RespuestaEquivocada()
    {
        Invoke ("AvisoEquivocado", 0.1f);
        Invoke ("Retornar", 1.1f);

    }

    void AvisoEquivocado()
    {
        render11.material.color = Color.red;
        render12.material.color = Color.red;
    }

    void Retornar()
    {
        render11.material.color = Color.white;
        render12.material.color = Color.white;
    }

    void OcultarBotones()
    {
        botonp1.gameObject.SetActive(false); 
        botonp2.gameObject.SetActive(false); 
        palabrad.gameObject.SetActive(true); 
        palabrai.gameObject.SetActive(true); 
    }

    void Continuar()
    { 
        pantallaContinuarg.gameObject.SetActive(true); 
    }

    
}
