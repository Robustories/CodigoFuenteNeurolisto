using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class A_6_4UI : MonoBehaviour
{
    #region Singleton class: Registro

    public static A_6_4UI Instance;


    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    #endregion
    [SerializeField] TMP_Text[] A64JUIText;
    [SerializeField] TMP_Text[] A64SUIText;
    [SerializeField] TMP_Text[] A65JUIText;
    [SerializeField] TMP_Text[] A65SUIText;
    [SerializeField] TMP_Text[] A66JUIText;
    [SerializeField] TMP_Text[] A66SUIText;
     void Start()
    {
        ActualizarRegistro();
        
    }

    public void ActualizarRegistro()
    {

        for (int i = 0; i < A64JUIText.Length; i++)
        {
            SetRegistroText(A64JUIText[i], Neuro.GetA64J());
        }

        for (int i = 0; i < A64SUIText.Length; i++)
        {
            SetRegistroText(A64SUIText[i], Neuro.Get64S());
        }

        for (int i = 0; i < A65JUIText.Length; i++)
        {
            SetRegistroText(A65JUIText[i], Neuro.GetA65J());
        }

        for (int i = 0; i < A65SUIText.Length; i++)
        {
            SetRegistroText(A65SUIText[i], Neuro.Get65S());
        }

        for (int i = 0; i < A66JUIText.Length; i++)
        {
            SetRegistroText(A66JUIText[i], Neuro.GetA66J());
        }

        for (int i = 0; i < A66SUIText.Length; i++)
        {
            SetRegistroText(A66SUIText[i], Neuro.Get66S());
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
