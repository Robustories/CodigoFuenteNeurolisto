using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class A_3_6UI : MonoBehaviour
{
    #region Singleton class: Registro

    public static A_3_6UI Instance;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    #endregion
    [SerializeField] TMP_Text[] A36JUIText;
    [SerializeField] TMP_Text[] A36SUIText;
    [SerializeField] TMP_Text[] A37JUIText;
    [SerializeField] TMP_Text[] A37SUIText;
    // Start is called before the first frame update
    void Start()
    {
        ActualizarRegistro();
        
    }

    public void ActualizarRegistro()
    {
        for (int i = 0; i < A36JUIText.Length; i++)
        {
            SetRegistroText(A36JUIText[i], Neuro.GetA36J());
        }

        for (int i = 0; i < A36SUIText.Length; i++)
        {
            SetRegistroText(A36SUIText[i], Neuro.Get36S());
        }

        for (int i = 0; i < A37JUIText.Length; i++)
        {
            SetRegistroText(A37JUIText[i], Neuro.GetA37J());
        }

        for (int i = 0; i < A37SUIText.Length; i++)
        {
            SetRegistroText(A37SUIText[i], Neuro.Get37S());
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
