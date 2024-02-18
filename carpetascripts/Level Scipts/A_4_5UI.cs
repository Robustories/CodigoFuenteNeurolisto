using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class A_4_5UI : MonoBehaviour
{
    #region Singleton class: Registro

    public static A_4_5UI Instance;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    #endregion
    [SerializeField] TMP_Text[] A451JUIText;
    [SerializeField] TMP_Text[] A451SUIText;
    [SerializeField] TMP_Text[] A452JUIText;
    [SerializeField] TMP_Text[] A452SUIText;
    [SerializeField] TMP_Text[] A453JUIText;
    [SerializeField] TMP_Text[] A453SUIText;
    // Start is called before the first frame update
    void Start()
    {
        ActualizarRegistro();
        
    }

    public void ActualizarRegistro()
    {
        for (int i = 0; i < A451JUIText.Length; i++)
        {
            SetRegistroText(A451JUIText[i], Neuro.GetA451J());
        }

        for (int i = 0; i < A451SUIText.Length; i++)
        {
            SetRegistroText(A451SUIText[i], Neuro.Get451S());
        }

        for (int i = 0; i < A452JUIText.Length; i++)
        {
            SetRegistroText(A452JUIText[i], Neuro.GetA452J());
        }

        for (int i = 0; i < A452SUIText.Length; i++)
        {
            SetRegistroText(A452SUIText[i], Neuro.Get452S());
        }

        for (int i = 0; i < A453JUIText.Length; i++)
        {
            SetRegistroText(A453JUIText[i], Neuro.GetA453J());
        }

        for (int i = 0; i < A453SUIText.Length; i++)
        {
            SetRegistroText(A453SUIText[i], Neuro.Get453S());
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
