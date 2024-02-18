using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class PadreSeleccionar : MonoBehaviour  

{
    //[SerializeField] private List<SeleccionarRespuesta> m_buttonList = null;
    public SeleccionarRespuesta seleccionarRespuesta;
    public GameObject pantallaContinuar;
    public Button button1;
    public Button button2;
    public Button button3;

    // Start is called before the first frame update
    void Start()
    {
        seleccionarRespuesta = GameObject.FindObjectOfType<SeleccionarRespuesta>();
    }

    

    // Update is called once per frame
    void Update()
    {
        ComprobarRespuesta();
    }

    void OnEnable()
    {
        //Register Button Events
        button1.onClick.AddListener(() => buttonCallBack(button1));
        button2.onClick.AddListener(() => buttonCallBack(button2));
        button3.onClick.AddListener(() => buttonCallBack(button3));
    }

    public void ComprobarRespuesta()
    {
        if(seleccionarRespuesta.Option.correct)
        {
            pantallaContinuar.gameObject.SetActive(true);
        }
        else
        {

        }
    }

    public void buttonCallBack(Button buttonPressed)
    {
        if (buttonPressed == button1)
    {
        //Your code for button 1
        Debug.Log("Clicked: " + button1.name);
    }
    
    }

    void OnDisable()
    
    {
        //Un-Register Button Events
        //button1.onClick.RemoveAllListeners();
        button2.onClick.RemoveAllListeners();button3.onClick.RemoveAllListeners();
    }

    public void OnPointerUp(BaseEventData eventData)
    {
        Debug.Log("Mouse Up");
    }

    public void OnPointerExit(BaseEventData eventData)
    {
        Debug.Log("Mouse Exit");
    }

    public void Lastpress(BaseEventData eventData)
    {
        Debug.Log(name);
    }


    
}


