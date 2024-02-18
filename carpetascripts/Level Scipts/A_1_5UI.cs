using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class A_1_5UI : MonoBehaviour
{
    #region Singleton class: Registro

    public static A_1_5UI Instance;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    #endregion
    
    [SerializeField] TMP_Text[] A15JUIText;
    [SerializeField] TMP_Text[] A15SUIText;
    [SerializeField] TMP_Text[] A1502JUIText;
    [SerializeField] TMP_Text[] A1502SUIText;
    
    // Start is called before the first frame update
    void Start()
    {
        ActualizarRegistro();
        
    }

    public void ActualizarRegistro()
    {
        for (int i = 0; i < A15JUIText.Length; i++)
        {
            SetRegistroText(A15JUIText[i], Neuro.GetA15J());
        }

        for (int i = 0; i < A15SUIText.Length; i++)
        {
            SetRegistroText(A15SUIText[i], Neuro.GetA15S());
        }

        for (int i = 0; i < A1502JUIText.Length; i++)
        {
            SetRegistroText(A1502JUIText[i], Neuro.GetA1502J());
        }

        for (int i = 0; i < A1502SUIText.Length; i++)
        {
            SetRegistroText(A1502SUIText[i], Neuro.GetA1502S());
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
