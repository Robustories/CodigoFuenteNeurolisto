using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class A_3_3UI : MonoBehaviour
{
    #region Singleton class: Registro

    public static A_3_3UI Instance;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    #endregion

    [SerializeField] TMP_Text[] A33JUIText;
    [SerializeField] TMP_Text[] A33SUIText;
    [SerializeField] TMP_Text[] A34JUIText;
    [SerializeField] TMP_Text[] A34SUIText;
    // Start is called before the first frame update
    void Start()
    {
        ActualizarRegistro();
        
    }

    public void ActualizarRegistro()
    {
        for (int i = 0; i < A33JUIText.Length; i++)
        {
            SetRegistroText(A33JUIText[i], Neuro.GetA33J());
        }

        for (int i = 0; i < A33SUIText.Length; i++)
        {
            SetRegistroText(A33SUIText[i], Neuro.Get33S());
        }

        for (int i = 0; i < A34JUIText.Length; i++)
        {
            SetRegistroText(A34JUIText[i], Neuro.GetA34J());
        }

        for (int i = 0; i < A34SUIText.Length; i++)
        {
            SetRegistroText(A34SUIText[i], Neuro.Get34S());
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
