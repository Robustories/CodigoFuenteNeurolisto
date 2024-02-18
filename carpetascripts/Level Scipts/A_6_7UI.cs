using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class A_6_7UI : MonoBehaviour
{
    #region Singleton class: Registro

    public static A_6_7UI Instance;


    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    #endregion
    [SerializeField] TMP_Text[] A671JUIText;
    [SerializeField] TMP_Text[] A671SUIText;
    [SerializeField] TMP_Text[] A672JUIText;
    [SerializeField] TMP_Text[] A672SUIText;
    [SerializeField] TMP_Text[] A673JUIText;
    [SerializeField] TMP_Text[] A673SUIText;
    [SerializeField] TMP_Text[] A674JUIText;
    [SerializeField] TMP_Text[] A674SUIText;
    // Start is called before the first frame update
     void Start()
    {
        ActualizarRegistro();
        
    }

    public void ActualizarRegistro()
    {

        for (int i = 0; i < A671JUIText.Length; i++)
        {
            SetRegistroText(A671JUIText[i], Neuro.GetA671J());
        }

        for (int i = 0; i < A671SUIText.Length; i++)
        {
            SetRegistroText(A671SUIText[i], Neuro.Get671S());
        }

        for (int i = 0; i < A672JUIText.Length; i++)
        {
            SetRegistroText(A672JUIText[i], Neuro.GetA672J());
        }

        for (int i = 0; i < A672SUIText.Length; i++)
        {
            SetRegistroText(A672SUIText[i], Neuro.Get672S());
        }

        for (int i = 0; i < A673JUIText.Length; i++)
        {
            SetRegistroText(A673JUIText[i], Neuro.GetA673J());
        }

        for (int i = 0; i < A673SUIText.Length; i++)
        {
            SetRegistroText(A673SUIText[i], Neuro.Get673S());
        }

        for (int i = 0; i < A674JUIText.Length; i++)
        {
            SetRegistroText(A674JUIText[i], Neuro.GetA674J());
        }

        for (int i = 0; i < A674SUIText.Length; i++)
        {
            SetRegistroText(A674SUIText[i], Neuro.Get674S());
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
