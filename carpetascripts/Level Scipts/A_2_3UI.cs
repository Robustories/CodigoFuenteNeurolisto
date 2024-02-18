using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class A_2_3UI : MonoBehaviour
{
    #region Singleton class: Registro

    public static A_2_3UI Instance;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    #endregion
    
    [SerializeField] TMP_Text[] A23JUIText;
    [SerializeField] TMP_Text[] A23SUIText;
    [SerializeField] TMP_Text[] A241JUIText;
    [SerializeField] TMP_Text[] A241SUIText;
    [SerializeField] TMP_Text[] A242JUIText;
    [SerializeField] TMP_Text[] A242SUIText;
    [SerializeField] TMP_Text[] A243JUIText;
    [SerializeField] TMP_Text[] A243SUIText;
    // Start is called before the first frame update
    void Start()
    {
        ActualizarRegistro();
        
    }

    public void ActualizarRegistro()
    {
        for (int i = 0; i < A23JUIText.Length; i++)
        {
            SetRegistroText(A23JUIText[i], Neuro.GetA23J());
        }

        for (int i = 0; i < A23SUIText.Length; i++)
        {
            SetRegistroText(A23SUIText[i], Neuro.Get23S());
        }

        for (int i = 0; i < A241JUIText.Length; i++)
        {
            SetRegistroText(A241JUIText[i], Neuro.GetA241J());
        }

        for (int i = 0; i < A241SUIText.Length; i++)
        {
            SetRegistroText(A241SUIText[i], Neuro.Get241S());
        }

        for (int i = 0; i < A242JUIText.Length; i++)
        {
            SetRegistroText(A242JUIText[i], Neuro.GetA242J());
        }

        for (int i = 0; i < A242SUIText.Length; i++)
        {
            SetRegistroText(A242SUIText[i], Neuro.Get242S());
        }

        for (int i = 0; i < A243JUIText.Length; i++)
        {
            SetRegistroText(A243JUIText[i], Neuro.GetA243J());
        }

        for (int i = 0; i < A243SUIText.Length; i++)
        {
            SetRegistroText(A243SUIText[i], Neuro.Get243S());
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
