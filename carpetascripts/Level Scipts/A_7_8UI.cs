using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class A_7_8UI : MonoBehaviour
{
    #region Singleton class: Registro

    public static A_7_8UI Instance;


    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    #endregion

    [SerializeField] TMP_Text[] A781JUIText;
    [SerializeField] TMP_Text[] A782JUIText;
    [SerializeField] TMP_Text[] A783JUIText;
    [SerializeField] TMP_Text[] A784JUIText;
    [SerializeField] TMP_Text[] A785JUIText;
    [SerializeField] TMP_Text[] A781SUIText;
    [SerializeField] TMP_Text[] A782SUIText;
    [SerializeField] TMP_Text[] A783SUIText;
    [SerializeField] TMP_Text[] A784SUIText;
    [SerializeField] TMP_Text[] A785SUIText;
    // Start is called before the first frame update
    void Start()
    {
        ActualizarRegistro();
        
    }

    public void ActualizarRegistro()
    {

        for (int i = 0; i < A781JUIText.Length; i++)
        {
            SetRegistroText(A781JUIText[i], Neuro.GetA781());
        }

        for (int i = 0; i < A782JUIText.Length; i++)
        {
            SetRegistroText(A782JUIText[i], Neuro.GetA782());
        }

        for (int i = 0; i < A783JUIText.Length; i++)
        {
            SetRegistroText(A783JUIText[i], Neuro.GetA783());
        }

        for (int i = 0; i < A784JUIText.Length; i++)
        {
            SetRegistroText(A784JUIText[i], Neuro.GetA784());
        }

        for (int i = 0; i < A785JUIText.Length; i++)
        {
            SetRegistroText(A785JUIText[i], Neuro.GetA785());
        }

        for (int i = 0; i < A781SUIText.Length; i++)
        {
            SetRegistroText(A781SUIText[i], Neuro.GetA781S());
        }

        for (int i = 0; i < A782SUIText.Length; i++)
        {
            SetRegistroText(A782SUIText[i], Neuro.GetA782S());
        }

        for (int i = 0; i < A783SUIText.Length; i++)
        {
            SetRegistroText(A783SUIText[i], Neuro.GetA783S());
        }

        for (int i = 0; i < A784SUIText.Length; i++)
        {
            SetRegistroText(A784SUIText[i], Neuro.GetA784S());
        }

        for (int i = 0; i < A785SUIText.Length; i++)
        {
            SetRegistroText(A785SUIText[i], Neuro.GetA785S());
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
}
