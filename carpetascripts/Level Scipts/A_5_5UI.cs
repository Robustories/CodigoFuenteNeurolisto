using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class A_5_5UI : MonoBehaviour
{
    #region Singleton class: Registro

    public static A_5_5UI Instance;


    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    #endregion
    [SerializeField] TMP_Text[] A551JUIText;
    [SerializeField] TMP_Text[] A551SUIText;
    [SerializeField] TMP_Text[] A552JUIText;
    [SerializeField] TMP_Text[] A552SUIText;
    [SerializeField] TMP_Text[] A553JUIText;
    [SerializeField] TMP_Text[] A553SUIText;
    [SerializeField] TMP_Text[] A554JUIText;
    [SerializeField] TMP_Text[] A554SUIText;
    // Start is called before the first frame update
    void Start()
    {
        ActualizarRegistro();
        
    }

    public void ActualizarRegistro()
    {

        for (int i = 0; i < A551JUIText.Length; i++)
        {
            SetRegistroText(A551JUIText[i], Neuro.GetA551J());
        }

        for (int i = 0; i < A551SUIText.Length; i++)
        {
            SetRegistroText(A551SUIText[i], Neuro.Get551S());
        }

        for (int i = 0; i < A552JUIText.Length; i++)
        {
            SetRegistroText(A552JUIText[i], Neuro.GetA552J());
        }

        for (int i = 0; i < A552SUIText.Length; i++)
        {
            SetRegistroText(A552SUIText[i], Neuro.Get552S());
        }

        for (int i = 0; i < A553JUIText.Length; i++)
        {
            SetRegistroText(A553JUIText[i], Neuro.GetA553J());
        }

        for (int i = 0; i < A553SUIText.Length; i++)
        {
            SetRegistroText(A553SUIText[i], Neuro.Get553S());
        }

        for (int i = 0; i < A554JUIText.Length; i++)
        {
            SetRegistroText(A554JUIText[i], Neuro.GetA554J());
        }

        for (int i = 0; i < A554SUIText.Length; i++)
        {
            SetRegistroText(A554SUIText[i], Neuro.Get554S());
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
