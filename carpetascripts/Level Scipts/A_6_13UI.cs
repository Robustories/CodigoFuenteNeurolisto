using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class A_6_13UI : MonoBehaviour
{
    #region Singleton class: Registro

    public static A_6_13UI Instance;


    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    #endregion
    [SerializeField] TMP_Text[] A6131JUIText;
    [SerializeField] TMP_Text[] A6131SUIText;
    [SerializeField] TMP_Text[] A6132JUIText;
    [SerializeField] TMP_Text[] A6132SUIText;
    [SerializeField] TMP_Text[] A6133JUIText;
    [SerializeField] TMP_Text[] A6133SUIText;
    [SerializeField] TMP_Text[] A6134JUIText;
    [SerializeField] TMP_Text[] A6134SUIText;
    // Start is called before the first frame update
     void Start()
    {
        ActualizarRegistro();
        
    }

    public void ActualizarRegistro()
    {

        for (int i = 0; i < A6131JUIText.Length; i++)
        {
            SetRegistroText(A6131JUIText[i], Neuro.GetA6131J());
        }

        for (int i = 0; i < A6131SUIText.Length; i++)
        {
            SetRegistroText(A6131SUIText[i], Neuro.Get6131S());
        }

        for (int i = 0; i < A6132JUIText.Length; i++)
        {
            SetRegistroText(A6132JUIText[i], Neuro.GetA6132J());
        }

        for (int i = 0; i < A6132SUIText.Length; i++)
        {
            SetRegistroText(A6132SUIText[i], Neuro.Get6132S());
        }

        for (int i = 0; i < A6133JUIText.Length; i++)
        {
            SetRegistroText(A6133JUIText[i], Neuro.GetA6133J());
        }

        for (int i = 0; i < A6133SUIText.Length; i++)
        {
            SetRegistroText(A6133SUIText[i], Neuro.Get6133S());
        }

        for (int i = 0; i < A6134JUIText.Length; i++)
        {
            SetRegistroText(A6134JUIText[i], Neuro.GetA6134J());
        }

        for (int i = 0; i < A6134SUIText.Length; i++)
        {
            SetRegistroText(A6134SUIText[i], Neuro.Get6134S());
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
