using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class A_2_6UI : MonoBehaviour
{
    #region Singleton class: Registro

    public static A_2_6UI Instance;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    #endregion

    [SerializeField] TMP_Text[] A26JUIText;
    [SerializeField] TMP_Text[] A26SUIText;
    [SerializeField] TMP_Text[] A27JUIText;
    [SerializeField] TMP_Text[] A27SUIText;
    // Start is called before the first frame update
    void Start()
    {
        ActualizarRegistro();
        
    }

    public void ActualizarRegistro()
    {
        for (int i = 0; i < A26JUIText.Length; i++)
        {
            SetRegistroText(A26JUIText[i], Neuro.GetA26J());
        }

        for (int i = 0; i < A26SUIText.Length; i++)
        {
            SetRegistroText(A26SUIText[i], Neuro.Get26S());
        }

        for (int i = 0; i < A27JUIText.Length; i++)
        {
            SetRegistroText(A27JUIText[i], Neuro.GetA27J());
        }

        for (int i = 0; i < A27SUIText.Length; i++)
        {
            SetRegistroText(A27SUIText[i], Neuro.Get27S());
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
