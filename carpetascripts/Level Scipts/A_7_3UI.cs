using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class A_7_3UI : MonoBehaviour
{
    #region Singleton class: Registro

    public static A_7_3UI Instance;


    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    #endregion

    [SerializeField] TMP_Text[] A731JUIText;
    [SerializeField] TMP_Text[] A731SUIText;
    [SerializeField] TMP_Text[] A732JUIText;
    [SerializeField] TMP_Text[] A732SUIText;
    [SerializeField] TMP_Text[] A733JUIText;
    [SerializeField] TMP_Text[] A733SUIText;
    [SerializeField] TMP_Text[] A74JUIText;
    [SerializeField] TMP_Text[] A74SUIText;
    // Start is called before the first frame update
    void Start()
    {
        ActualizarRegistro();
        
    }

    public void ActualizarRegistro()
    {

        for (int i = 0; i < A731JUIText.Length; i++)
        {
            SetRegistroText(A731JUIText[i], Neuro.GetA731J());
        }

        for (int i = 0; i < A731SUIText.Length; i++)
        {
            SetRegistroText(A731SUIText[i], Neuro.GetA731S());
        }

        for (int i = 0; i < A732JUIText.Length; i++)
        {
            SetRegistroText(A732JUIText[i], Neuro.GetA732J());
        }

        for (int i = 0; i < A732SUIText.Length; i++)
        {
            SetRegistroText(A732SUIText[i], Neuro.GetA732S());
        }

        for (int i = 0; i < A733JUIText.Length; i++)
        {
            SetRegistroText(A733JUIText[i], Neuro.GetA733J());
        }

        for (int i = 0; i < A733SUIText.Length; i++)
        {
            SetRegistroText(A733SUIText[i], Neuro.GetA733S());
        }

        for (int i = 0; i < A74JUIText.Length; i++)
        {
            SetRegistroText(A74JUIText[i], Neuro.GetA74J());
        }

        for (int i = 0; i < A74SUIText.Length; i++)
        {
            SetRegistroText(A74SUIText[i], Neuro.GetA74S());
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
