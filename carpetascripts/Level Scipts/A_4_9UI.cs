using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class A_4_9UI : MonoBehaviour
{
    #region Singleton class: Registro

    public static A_4_9UI Instance;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    #endregion
    [SerializeField] TMP_Text[] A491JUIText;
    [SerializeField] TMP_Text[] A491SUIText;
    [SerializeField] TMP_Text[] A492JUIText;
    [SerializeField] TMP_Text[] A492SUIText;
    [SerializeField] TMP_Text[] A493JUIText;
    [SerializeField] TMP_Text[] A493SUIText;
    [SerializeField] TMP_Text[] A410JUIText;
    [SerializeField] TMP_Text[] A410SUIText;
    // Start is called before the first frame update
    void Start()
    {
        ActualizarRegistro();
        
    }

    public void ActualizarRegistro()
    {
        for (int i = 0; i < A491JUIText.Length; i++)
        {
            SetRegistroText(A491JUIText[i], Neuro.GetA491J());
        }

        for (int i = 0; i < A491SUIText.Length; i++)
        {
            SetRegistroText(A491SUIText[i], Neuro.Get491S());
        }

        for (int i = 0; i < A492JUIText.Length; i++)
        {
            SetRegistroText(A492JUIText[i], Neuro.GetA492J());
        }

        for (int i = 0; i < A492SUIText.Length; i++)
        {
            SetRegistroText(A492SUIText[i], Neuro.Get492S());
        }

        for (int i = 0; i < A493JUIText.Length; i++)
        {
            SetRegistroText(A493JUIText[i], Neuro.GetA493J());
        }

        for (int i = 0; i < A493SUIText.Length; i++)
        {
            SetRegistroText(A493SUIText[i], Neuro.Get493S());
        }

        for (int i = 0; i < A410JUIText.Length; i++)
        {
            SetRegistroText(A410JUIText[i], Neuro.GetA410J());
        }

        for (int i = 0; i < A410SUIText.Length; i++)
        {
            SetRegistroText(A410SUIText[i], Neuro.Get410S());
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
