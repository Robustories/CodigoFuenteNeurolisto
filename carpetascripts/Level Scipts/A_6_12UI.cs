using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class A_6_12UI : MonoBehaviour
{
    #region Singleton class: Registro

    public static A_6_12UI Instance;


    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    #endregion
    [SerializeField] TMP_Text[] A6121JUIText;
    [SerializeField] TMP_Text[] A6121SUIText;
    [SerializeField] TMP_Text[] A6122JUIText;
    [SerializeField] TMP_Text[] A6122SUIText;
    [SerializeField] TMP_Text[] A6123JUIText;
    [SerializeField] TMP_Text[] A6123SUIText;
    [SerializeField] TMP_Text[] A6124JUIText;
    [SerializeField] TMP_Text[] A6124SUIText;
    

     void Start()
    {
        ActualizarRegistro();
        
    }

    public void ActualizarRegistro()
    {

        for (int i = 0; i < A6121JUIText.Length; i++)
        {
            SetRegistroText(A6121JUIText[i], Neuro.GetA6121J());
        }

        for (int i = 0; i < A6121SUIText.Length; i++)
        {
            SetRegistroText(A6121SUIText[i], Neuro.Get6121S());
        }

        for (int i = 0; i < A6122JUIText.Length; i++)
        {
            SetRegistroText(A6122JUIText[i], Neuro.GetA6122J());
        }

        for (int i = 0; i < A6122SUIText.Length; i++)
        {
            SetRegistroText(A6122SUIText[i], Neuro.Get6122S());
        }

        for (int i = 0; i < A6121JUIText.Length; i++)
        {
            SetRegistroText(A6121JUIText[i], Neuro.GetA6123J());
        }

        for (int i = 0; i < A6123SUIText.Length; i++)
        {
            SetRegistroText(A6123SUIText[i], Neuro.Get6123S());
        }

        for (int i = 0; i < A6124JUIText.Length; i++)
        {
            SetRegistroText(A6124JUIText[i], Neuro.GetA6124J());
        }

        for (int i = 0; i < A6124SUIText.Length; i++)
        {
            SetRegistroText(A6124SUIText[i], Neuro.Get6124S());
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
