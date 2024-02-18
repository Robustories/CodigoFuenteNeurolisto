using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class A_5_2UI : MonoBehaviour
{
    #region Singleton class: Registro

    public static A_5_2UI Instance;


    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    #endregion
    [SerializeField] TMP_Text[] A52JUIText;
    [SerializeField] TMP_Text[] A52SUIText;
    [SerializeField] TMP_Text[] A531JUIText;
    [SerializeField] TMP_Text[] A531SUIText;
    [SerializeField] TMP_Text[] A532JUIText;
    [SerializeField] TMP_Text[] A532SUIText;
    [SerializeField] TMP_Text[] A533JUIText;
    [SerializeField] TMP_Text[] A533SUIText;
    // Start is called before the first frame update
    void Start()
    {
        ActualizarRegistro();
        
    }

    public void ActualizarRegistro()
    {
        for (int i = 0; i < A52JUIText.Length; i++)
        {
            SetRegistroText(A52JUIText[i], Neuro.GetA52J());
        }

        for (int i = 0; i < A52SUIText.Length; i++)
        {
            SetRegistroText(A52SUIText[i], Neuro.Get52S());
        }

        for (int i = 0; i < A531JUIText.Length; i++)
        {
            SetRegistroText(A531JUIText[i], Neuro.GetA531J());
        }

        for (int i = 0; i < A531SUIText.Length; i++)
        {
            SetRegistroText(A531SUIText[i], Neuro.Get531S());
        }

        for (int i = 0; i < A532JUIText.Length; i++)
        {
            SetRegistroText(A532JUIText[i], Neuro.GetA532J());
        }

        for (int i = 0; i < A532SUIText.Length; i++)
        {
            SetRegistroText(A532SUIText[i], Neuro.Get532S());
        }

        for (int i = 0; i < A533JUIText.Length; i++)
        {
            SetRegistroText(A533JUIText[i], Neuro.GetA533J());
        }

        for (int i = 0; i < A533SUIText.Length; i++)
        {
            SetRegistroText(A533SUIText[i], Neuro.Get533S());
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
