using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class A_4_3UI : MonoBehaviour
{
    #region Singleton class: Registro

    public static A_4_3UI Instance;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    #endregion
    [SerializeField] TMP_Text[] A43JUIText;
    [SerializeField] TMP_Text[] A43SUIText;
    [SerializeField] TMP_Text[] A44JUIText;
    [SerializeField] TMP_Text[] A44SUIText;
    // Start is called before the first frame update
    void Start()
    {
        ActualizarRegistro();
        
    }

    public void ActualizarRegistro()
    {
        for (int i = 0; i < A43JUIText.Length; i++)
        {
            SetRegistroText(A43JUIText[i], Neuro.GetA43J());
        }

        for (int i = 0; i < A43SUIText.Length; i++)
        {
            SetRegistroText(A43SUIText[i], Neuro.Get43S());
        }

        for (int i = 0; i < A44JUIText.Length; i++)
        {
            SetRegistroText(A44JUIText[i], Neuro.GetA44J());
        }

        for (int i = 0; i < A44SUIText.Length; i++)
        {
            SetRegistroText(A44SUIText[i], Neuro.Get44S());
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
