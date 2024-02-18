using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class A_2_1UI : MonoBehaviour
{
    #region Singleton class: Registro

    public static A_2_1UI Instance;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    #endregion

    [SerializeField] TMP_Text[] A211JUIText;
    [SerializeField] TMP_Text[] A211SUIText;
    [SerializeField] TMP_Text[] A212JUIText;
    [SerializeField] TMP_Text[] A212SUIText;
    [SerializeField] TMP_Text[] A213JUIText;
    [SerializeField] TMP_Text[] A213SUIText;
    [SerializeField] TMP_Text[] A214JUIText;
    [SerializeField] TMP_Text[] A214SUIText;
    // Start is called before the first frame update
    void Start()
    {
        ActualizarRegistro();
        
    }

    public void ActualizarRegistro()
    {
        for (int i = 0; i < A211JUIText.Length; i++)
        {
            SetRegistroText(A211JUIText[i], Neuro.GetA211J());
        }

        for (int i = 0; i < A211SUIText.Length; i++)
        {
            SetRegistroText(A211SUIText[i], Neuro.Get211S());
        }

        for (int i = 0; i < A212JUIText.Length; i++)
        {
            SetRegistroText(A212JUIText[i], Neuro.GetA212J());
        }

        for (int i = 0; i < A212SUIText.Length; i++)
        {
            SetRegistroText(A212SUIText[i], Neuro.Get212S());
        }

        for (int i = 0; i < A213JUIText.Length; i++)
        {
            SetRegistroText(A213JUIText[i], Neuro.GetA213J());
        }

        for (int i = 0; i < A213SUIText.Length; i++)
        {
            SetRegistroText(A213SUIText[i], Neuro.Get213S());
        }

        for (int i = 0; i < A214JUIText.Length; i++)
        {
            SetRegistroText(A214JUIText[i], Neuro.GetA214J());
        }

        for (int i = 0; i < A214SUIText.Length; i++)
        {
            SetRegistroText(A214SUIText[i], Neuro.Get214S());
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
