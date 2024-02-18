using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class A_1_13UI : MonoBehaviour
{
    #region Singleton class: Registro

    public static A_1_13UI Instance;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }
    #endregion
    [SerializeField] TMP_Text[] A113JUIText;
    [SerializeField] TMP_Text[] A113SUIText;

    // Start is called before the first frame update
     void Start()
    {
        ActualizarRegistro();
        
    }

    public void ActualizarRegistro()
    {
        for (int i = 0; i < A113JUIText.Length; i++)
        {
            SetRegistroText(A113JUIText[i], Neuro.GetA1xceJ());
        }

        for (int i = 0; i < A113SUIText.Length; i++)
        {
            SetRegistroText(A113SUIText[i], Neuro.GetA1xceS());
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
