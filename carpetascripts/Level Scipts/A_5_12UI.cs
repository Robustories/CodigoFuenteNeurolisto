using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class A_5_12UI : MonoBehaviour
{
    #region Singleton class: Registro

    public static A_5_12UI Instance;


    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    #endregion
    [SerializeField] TMP_Text[] A5121JUIText;
    [SerializeField] TMP_Text[] A5121SUIText;
    [SerializeField] TMP_Text[] A5122JUIText;
    [SerializeField] TMP_Text[] A5122SUIText;
    [SerializeField] TMP_Text[] A5123JUIText;
    [SerializeField] TMP_Text[] A5123SUIText;
    [SerializeField] TMP_Text[] A5124JUIText;
    [SerializeField] TMP_Text[] A5124SUIText;
    // Start is called before the first frame update
    void Start()
    {
        ActualizarRegistro();
        
    }

    public void ActualizarRegistro()
    {

        for (int i = 0; i < A5121JUIText.Length; i++)
        {
            SetRegistroText(A5121JUIText[i], Neuro.GetA5121J());
        }

        for (int i = 0; i < A5121SUIText.Length; i++)
        {
            SetRegistroText(A5121SUIText[i], Neuro.Get5121S());
        }

        for (int i = 0; i < A5122JUIText.Length; i++)
        {
            SetRegistroText(A5122JUIText[i], Neuro.GetA5122J());
        }

        for (int i = 0; i < A5122SUIText.Length; i++)
        {
            SetRegistroText(A5122SUIText[i], Neuro.Get5122S());
        }

        for (int i = 0; i < A5123JUIText.Length; i++)
        {
            SetRegistroText(A5123JUIText[i], Neuro.GetA5123J());
        }

        for (int i = 0; i < A5123SUIText.Length; i++)
        {
            SetRegistroText(A5123SUIText[i], Neuro.Get5123S());
        }

        for (int i = 0; i < A5124JUIText.Length; i++)
        {
            SetRegistroText(A5124JUIText[i], Neuro.GetA5123J());
        }

        for (int i = 0; i < A5124SUIText.Length; i++)
        {
            SetRegistroText(A5124SUIText[i], Neuro.Get5123S());
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
