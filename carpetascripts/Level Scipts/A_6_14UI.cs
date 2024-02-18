using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class A_6_14UI : MonoBehaviour
{
    #region Singleton class: Registro

    public static A_6_14UI Instance;


    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    #endregion
    [SerializeField] TMP_Text[] A6141JUIText;
    [SerializeField] TMP_Text[] A6141SUIText;
    [SerializeField] TMP_Text[] A6142JUIText;
    [SerializeField] TMP_Text[] A6142SUIText;
    [SerializeField] TMP_Text[] A6143JUIText;
    [SerializeField] TMP_Text[] A6143SUIText;

     void Start()
    {
        ActualizarRegistro();
        
    }

    public void ActualizarRegistro()
    {

        for (int i = 0; i < A6141JUIText.Length; i++)
        {
            SetRegistroText(A6141JUIText[i], Neuro.GetA6141J());
        }

        for (int i = 0; i < A6141SUIText.Length; i++)
        {
            SetRegistroText(A6141SUIText[i], Neuro.Get6141S());
        }

        for (int i = 0; i < A6142JUIText.Length; i++)
        {
            SetRegistroText(A6142JUIText[i], Neuro.GetA6142J());
        }

        for (int i = 0; i < A6142SUIText.Length; i++)
        {
            SetRegistroText(A6142SUIText[i], Neuro.Get6142S());
        }

        for (int i = 0; i < A6143JUIText.Length; i++)
        {
            SetRegistroText(A6143JUIText[i], Neuro.GetA6143J());
        }

        for (int i = 0; i < A6143SUIText.Length; i++)
        {
            SetRegistroText(A6143SUIText[i], Neuro.Get6143S());
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
