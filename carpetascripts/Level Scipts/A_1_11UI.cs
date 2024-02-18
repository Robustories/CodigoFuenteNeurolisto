using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class A_1_11UI : MonoBehaviour
{
    #region Singleton class: Registro

    public static A_1_11UI Instance;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    #endregion

    [SerializeField] TMP_Text[] A1111JUIText;
    [SerializeField] TMP_Text[] A1111SUIText;
    [SerializeField] TMP_Text[] A1112JUIText;
    [SerializeField] TMP_Text[] A1112SUIText;
    [SerializeField] TMP_Text[] A1113JUIText;
    [SerializeField] TMP_Text[] A1113SUIText;
    // Start is called before the first frame update
    void Start()
    {
        ActualizarRegistro();
        
    }

    public void ActualizarRegistro()
    {
        for (int i = 0; i < A1111JUIText.Length; i++)
        {
            SetRegistroText(A1111JUIText[i], Neuro.GetA1111J());
        }

        for (int i = 0; i < A1111SUIText.Length; i++)
        {
            SetRegistroText(A1111SUIText[i], Neuro.GetA1111S());
        }

        for (int i = 0; i < A1112JUIText.Length; i++)
        {
            SetRegistroText(A1112JUIText[i], Neuro.GetA1112J());
        }

        for (int i = 0; i < A1112SUIText.Length; i++)
        {
            SetRegistroText(A1112SUIText[i], Neuro.GetA1112S());
        }

        for (int i = 0; i < A1113JUIText.Length; i++)
        {
            SetRegistroText(A1113JUIText[i], Neuro.GetA1113J());
        }

        for (int i = 0; i < A1113SUIText.Length; i++)
        {
            SetRegistroText(A1113SUIText[i], Neuro.GetA1113S());
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
