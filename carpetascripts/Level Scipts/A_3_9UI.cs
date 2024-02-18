using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class A_3_9UI : MonoBehaviour
{
    #region Singleton class: Registro

    public static A_3_9UI Instance;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    #endregion
    [SerializeField] TMP_Text[] A39JUIText;
    [SerializeField] TMP_Text[] A39SUIText;
    [SerializeField] TMP_Text[] A310JUIText;
    [SerializeField] TMP_Text[] A310SUIText;
    // Start is called before the first frame update
    void Start()
    {
        ActualizarRegistro();
        
    }

    public void ActualizarRegistro()
    {
        for (int i = 0; i < A39JUIText.Length; i++)
        {
            SetRegistroText(A39JUIText[i], Neuro.GetA39J());
        }

        for (int i = 0; i < A39SUIText.Length; i++)
        {
            SetRegistroText(A39SUIText[i], Neuro.Get39S());
        }

        for (int i = 0; i < A310JUIText.Length; i++)
        {
            SetRegistroText(A310JUIText[i], Neuro.GetA310J());
        }

        for (int i = 0; i < A310SUIText.Length; i++)
        {
            SetRegistroText(A310SUIText[i], Neuro.Get310S());
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
