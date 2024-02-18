using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class A_3_5UI : MonoBehaviour
{
    #region Singleton class: Registro

    public static A_3_5UI Instance;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    #endregion
    [SerializeField] TMP_Text[] A351JUIText;
    [SerializeField] TMP_Text[] A351SUIText;
    [SerializeField] TMP_Text[] A352JUIText;
    [SerializeField] TMP_Text[] A352SUIText;
    [SerializeField] TMP_Text[] A353JUIText;
    [SerializeField] TMP_Text[] A353SUIText;
    [SerializeField] TMP_Text[] A354JUIText;
    [SerializeField] TMP_Text[] A354SUIText;
    // Start is called before the first frame update
    void Start()
    {
        ActualizarRegistro();
        
    }

    public void ActualizarRegistro()
    {
        for (int i = 0; i < A351JUIText.Length; i++)
        {
            SetRegistroText(A351JUIText[i], Neuro.GetA351J());
        }

        for (int i = 0; i < A351SUIText.Length; i++)
        {
            SetRegistroText(A351SUIText[i], Neuro.Get351S());
        }

        for (int i = 0; i < A352JUIText.Length; i++)
        {
            SetRegistroText(A352JUIText[i], Neuro.GetA352J());
        }

        for (int i = 0; i < A352SUIText.Length; i++)
        {
            SetRegistroText(A352SUIText[i], Neuro.Get352S());
        }

        for (int i = 0; i < A353JUIText.Length; i++)
        {
            SetRegistroText(A353JUIText[i], Neuro.GetA353J());
        }

        for (int i = 0; i < A353SUIText.Length; i++)
        {
            SetRegistroText(A353SUIText[i], Neuro.Get353S());
        }

        for (int i = 0; i < A354JUIText.Length; i++)
        {
            SetRegistroText(A354JUIText[i], Neuro.GetA354J());
        }

        for (int i = 0; i < A354SUIText.Length; i++)
        {
            SetRegistroText(A354SUIText[i], Neuro.Get354S());
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