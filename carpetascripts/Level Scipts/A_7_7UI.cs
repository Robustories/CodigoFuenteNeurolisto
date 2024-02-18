using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class A_7_7UI : MonoBehaviour
{
    #region Singleton class: Registro

    public static A_7_7UI Instance;


    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    #endregion

    [SerializeField] TMP_Text[] A771JUIText;
    [SerializeField] TMP_Text[] A771SUIText;
    [SerializeField] TMP_Text[] A772JUIText;
    [SerializeField] TMP_Text[] A772SUIText;
    [SerializeField] TMP_Text[] A773JUIText;
    [SerializeField] TMP_Text[] A773SUIText;
    // Start is called before the first frame update
    void Start()
    {
        ActualizarRegistro();
        
    }

    public void ActualizarRegistro()
    {
        for (int i = 0; i < A771JUIText.Length; i++)
        {
            SetRegistroText(A771JUIText[i], Neuro.GetA771J());
        }

        for (int i = 0; i < A771SUIText.Length; i++)
        {
            SetRegistroText(A771SUIText[i], Neuro.GetA771S());
        }

        for (int i = 0; i < A772JUIText.Length; i++)
        {
            SetRegistroText(A772JUIText[i], Neuro.GetA772J());
        }

        for (int i = 0; i < A772SUIText.Length; i++)
        {
            SetRegistroText(A772SUIText[i], Neuro.GetA772S());
        }

        for (int i = 0; i < A773JUIText.Length; i++)
        {
            SetRegistroText(A773JUIText[i], Neuro.GetA773J());
        }

        for (int i = 0; i < A773SUIText.Length; i++)
        {
            SetRegistroText(A773SUIText[i], Neuro.GetA773S());
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
