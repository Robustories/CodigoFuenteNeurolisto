using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class A_6_11UI : MonoBehaviour
{
    #region Singleton class: Registro

    public static A_6_11UI Instance;


    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    #endregion
    [SerializeField] TMP_Text[] A6111JUIText;
    [SerializeField] TMP_Text[] A6111SUIText;
    [SerializeField] TMP_Text[] A6112JUIText;
    [SerializeField] TMP_Text[] A6112SUIText;
    [SerializeField] TMP_Text[] A6113JUIText;
    [SerializeField] TMP_Text[] A6113SUIText;

    // Start is called before the first frame update
     void Start()
    {
        ActualizarRegistro();
        
    }

    public void ActualizarRegistro()
    {

        for (int i = 0; i < A6111JUIText.Length; i++)
        {
            SetRegistroText(A6111JUIText[i], Neuro.GetA6111J());
        }

        for (int i = 0; i < A6111SUIText.Length; i++)
        {
            SetRegistroText(A6111SUIText[i], Neuro.Get6111S());
        }

        for (int i = 0; i < A6112JUIText.Length; i++)
        {
            SetRegistroText(A6112JUIText[i], Neuro.GetA6112J());
        }

        for (int i = 0; i < A6112SUIText.Length; i++)
        {
            SetRegistroText(A6112SUIText[i], Neuro.Get6112S());
        }

        for (int i = 0; i < A6113JUIText.Length; i++)
        {
            SetRegistroText(A6113JUIText[i], Neuro.GetA6113J());
        }

        for (int i = 0; i < A6113SUIText.Length; i++)
        {
            SetRegistroText(A6113SUIText[i], Neuro.Get6113S());
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
