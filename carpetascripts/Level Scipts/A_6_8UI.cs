using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class A_6_8UI : MonoBehaviour
{
    #region Singleton class: Registro

    public static A_6_8UI Instance;


    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    #endregion
    [SerializeField] TMP_Text[] A681JUIText;
    [SerializeField] TMP_Text[] A681SUIText;
    [SerializeField] TMP_Text[] A682JUIText;
    [SerializeField] TMP_Text[] A682SUIText;
    [SerializeField] TMP_Text[] A683JUIText;
    [SerializeField] TMP_Text[] A683SUIText;
    // Start is called before the first frame update
     void Start()
    {
        ActualizarRegistro();
        
    }

    public void ActualizarRegistro()
    {

        for (int i = 0; i < A681JUIText.Length; i++)
        {
            SetRegistroText(A681JUIText[i], Neuro.GetA681J());
        }

        for (int i = 0; i < A681SUIText.Length; i++)
        {
            SetRegistroText(A681SUIText[i], Neuro.Get681S());
        }

        for (int i = 0; i < A682JUIText.Length; i++)
        {
            SetRegistroText(A682JUIText[i], Neuro.GetA682J());
        }

        for (int i = 0; i < A682SUIText.Length; i++)
        {
            SetRegistroText(A682SUIText[i], Neuro.Get682S());
        }

        for (int i = 0; i < A683JUIText.Length; i++)
        {
            SetRegistroText(A683JUIText[i], Neuro.GetA683J());
        }

        for (int i = 0; i < A683SUIText.Length; i++)
        {
            SetRegistroText(A683SUIText[i], Neuro.Get683S());
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
