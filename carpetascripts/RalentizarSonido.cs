using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RalentizarSonido : MonoBehaviour
{
    public Toggle Lento;
    public AudioSource source;
    //private bool _isOn = false;
    public delegate void ValueChanged(bool value);
    //public event ValueChanged valueChanged;
    
    // Start is called before the first frame update
    void Start()
    {
       
        
    }



    public void ToggleValueChangedOcurred(bool tglValue)
    {
        if (tglValue)
        {
        source.pitch = 0.5f;
        }
        else
        {
        source.pitch = 1f;
        }

    }

    public void OnChangeValue()
    {
        bool lento = gameObject.GetComponent<Toggle>().isOn;
         if (lento)
        {
        source.pitch = 0.5f;
        }
        else
        {
        source.pitch = 1f;
        }

    }

}
