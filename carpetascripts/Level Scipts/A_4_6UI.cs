using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class A_4_6UI : MonoBehaviour
{
    #region Singleton class: Registro

    public static A_4_6UI Instance;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    #endregion
    [SerializeField] TMP_Text[] A46JUIText;
    [SerializeField] TMP_Text[] A46SUIText;
    [SerializeField] TMP_Text[] A471JUIText;
    [SerializeField] TMP_Text[] A471SUIText;
    [SerializeField] TMP_Text[] A472JUIText;
    [SerializeField] TMP_Text[] A472SUIText;
    [SerializeField] TMP_Text[] A473JUIText;
    [SerializeField] TMP_Text[] A473SUIText;
    // Start is called before the first frame update
    void Start()
    {
        ActualizarRegistro();
        
    }

    public void ActualizarRegistro()
    {
        for (int i = 0; i < A46JUIText.Length; i++)
        {
            SetRegistroText(A46JUIText[i], Neuro.GetA46J());
        }

        for (int i = 0; i < A46SUIText.Length; i++)
        {
            SetRegistroText(A46SUIText[i], Neuro.Get46S());
        }

        for (int i = 0; i < A471JUIText.Length; i++)
        {
            SetRegistroText(A471JUIText[i], Neuro.GetA471J());
        }

        for (int i = 0; i < A471SUIText.Length; i++)
        {
            SetRegistroText(A471SUIText[i], Neuro.Get471S());
        }

        for (int i = 0; i < A472JUIText.Length; i++)
        {
            SetRegistroText(A472JUIText[i], Neuro.GetA472J());
        }

        for (int i = 0; i < A472SUIText.Length; i++)
        {
            SetRegistroText(A472SUIText[i], Neuro.Get472S());
        }

        for (int i = 0; i < A473JUIText.Length; i++)
        {
            SetRegistroText(A473JUIText[i], Neuro.GetA473J());
        }

        for (int i = 0; i < A473SUIText.Length; i++)
        {
            SetRegistroText(A473SUIText[i], Neuro.Get473S());
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
