using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class A_4_11UI : MonoBehaviour
{
    #region Singleton class: Registro

    public static A_4_11UI Instance;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    #endregion
    [SerializeField] TMP_Text[] A4111JUIText;
    [SerializeField] TMP_Text[] A4111SUIText;
    [SerializeField] TMP_Text[] A4112JUIText;
    [SerializeField] TMP_Text[] A4112SUIText;
    [SerializeField] TMP_Text[] A4113JUIText;
    [SerializeField] TMP_Text[] A4113SUIText;
    // Start is called before the first frame update
    void Start()
    {
        ActualizarRegistro();
        
    }

    public void ActualizarRegistro()
    {
        for (int i = 0; i < A4111JUIText.Length; i++)
        {
            SetRegistroText(A4111JUIText[i], Neuro.GetA4111J());
        }

        for (int i = 0; i < A4111SUIText.Length; i++)
        {
            SetRegistroText(A4111SUIText[i], Neuro.Get4111S());
        }

        for (int i = 0; i < A4112JUIText.Length; i++)
        {
            SetRegistroText(A4112JUIText[i], Neuro.GetA4112J());
        }

        for (int i = 0; i < A4112SUIText.Length; i++)
        {
            SetRegistroText(A4112SUIText[i], Neuro.Get4112S());
        }

        for (int i = 0; i < A4113JUIText.Length; i++)
        {
            SetRegistroText(A4113JUIText[i], Neuro.GetA4113J());
        }

        for (int i = 0; i < A4113SUIText.Length; i++)
        {
            SetRegistroText(A4113SUIText[i], Neuro.Get4113S());
        }

        
    }

    void SetRegistroText (TMP_Text textMesh, int value)
    {
        if (value >= 1000)
        textMesh.text = string.Format ("{0}K.{1}", (value/1000), GetFirstDigitFromNumber(value % 1000));
        else
        textMesh.text = value.ToString();
    }

    int GetFirstDigitFromNumber(int num)
    {
        return int.Parse (num.ToString() [0].ToString());
    }


    // Update is called once per frame
  
}
