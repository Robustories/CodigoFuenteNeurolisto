using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class A_5_11UI : MonoBehaviour
{
    #region Singleton class: Registro

    public static A_5_11UI Instance;


    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    #endregion
    [SerializeField] TMP_Text[] A5111JUIText;
    [SerializeField] TMP_Text[] A5111SUIText;
    [SerializeField] TMP_Text[] A5112JUIText;
    [SerializeField] TMP_Text[] A5112SUIText;
    [SerializeField] TMP_Text[] A5113JUIText;
    [SerializeField] TMP_Text[] A5113SUIText;
    // Start is called before the first frame update
    void Start()
    {
        ActualizarRegistro();
        
    }

    public void ActualizarRegistro()
    {

        for (int i = 0; i < A5111JUIText.Length; i++)
        {
            SetRegistroText(A5111JUIText[i], Neuro.GetA5111J());
        }

        for (int i = 0; i < A5111SUIText.Length; i++)
        {
            SetRegistroText(A5111SUIText[i], Neuro.Get5111S());
        }

        for (int i = 0; i < A5112JUIText.Length; i++)
        {
            SetRegistroText(A5112JUIText[i], Neuro.GetA5112J());
        }

        for (int i = 0; i < A5112SUIText.Length; i++)
        {
            SetRegistroText(A5112SUIText[i], Neuro.Get5112S());
        }

        for (int i = 0; i < A5113JUIText.Length; i++)
        {
            SetRegistroText(A5113JUIText[i], Neuro.GetA5113J());
        }

        for (int i = 0; i < A5113SUIText.Length; i++)
        {
            SetRegistroText(A5113SUIText[i], Neuro.Get5113S());
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
