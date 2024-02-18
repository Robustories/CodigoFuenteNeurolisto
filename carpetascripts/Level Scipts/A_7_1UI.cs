using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class A_7_1UI : MonoBehaviour
{
    #region Singleton class: Registro

    public static A_7_1UI Instance;


    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }
    // Start is called before the first frame update
    #endregion
    [SerializeField] TMP_Text[] A711JUIText;
    [SerializeField] TMP_Text[] A711SUIText;
    [SerializeField] TMP_Text[] A712JUIText;
    [SerializeField] TMP_Text[] A712SUIText;
    [SerializeField] TMP_Text[] A713JUIText;
    [SerializeField] TMP_Text[] A713SUIText;
    [SerializeField] TMP_Text[] A714JUIText;
    [SerializeField] TMP_Text[] A714SUIText;
    [SerializeField] TMP_Text[] A715JUIText;
    [SerializeField] TMP_Text[] A715SUIText;
    // Start is called before the first frame update
     void Start()
    {
        ActualizarRegistro();
        
    }

    public void ActualizarRegistro()
    {

        for (int i = 0; i < A711JUIText.Length; i++)
        {
            SetRegistroText(A711JUIText[i], Neuro.GetA711J());
        }

        for (int i = 0; i < A711SUIText.Length; i++)
        {
            SetRegistroText(A711SUIText[i], Neuro.GetA711S());
        }

        for (int i = 0; i < A712JUIText.Length; i++)
        {
            SetRegistroText(A712JUIText[i], Neuro.GetA712J());
        }

        for (int i = 0; i < A712SUIText.Length; i++)
        {
            SetRegistroText(A712SUIText[i], Neuro.GetA712S());
        }

        for (int i = 0; i < A713JUIText.Length; i++)
        {
            SetRegistroText(A713JUIText[i], Neuro.GetA713J());
        }

        for (int i = 0; i < A713SUIText.Length; i++)
        {
            SetRegistroText(A713SUIText[i], Neuro.GetA713S());
        }

        for (int i = 0; i < A714JUIText.Length; i++)
        {
            SetRegistroText(A714JUIText[i], Neuro.GetA714J());
        }

        for (int i = 0; i < A714SUIText.Length; i++)
        {
            SetRegistroText(A714SUIText[i], Neuro.GetA714S());
        }

        for (int i = 0; i < A715JUIText.Length; i++)
        {
            SetRegistroText(A715JUIText[i], Neuro.GetA715J());
        }

        for (int i = 0; i < A715SUIText.Length; i++)
        {
            SetRegistroText(A715SUIText[i], Neuro.GetA715S());
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

