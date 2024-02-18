using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Registro : MonoBehaviour
{
    #region Singleton class: Registro

    public static Registro Instance;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    #endregion

    [SerializeField] TMP_Text[] A111JUIText;
    [SerializeField] TMP_Text[] A111SUIText;
    [SerializeField] TMP_Text[] A112JUIText;
    [SerializeField] TMP_Text[] A112SUIText;
    [SerializeField] TMP_Text[] A113JUIText;
    [SerializeField] TMP_Text[] A113SUIText;
    [SerializeField] TMP_Text[] A114JUIText;
    [SerializeField] TMP_Text[] A114SUIText;
    [SerializeField] TMP_Text[] NombreText;
    // Start is called before the first frame update
    void Start()
    {
        ActualizarRegistro();
        
    }

    public void ActualizarRegistro()
    {
        for (int i = 0; i < A111JUIText.Length; i++)
        {
            SetRegistroText(A111JUIText[i], Neuro.GetA111J());
        }

        for (int i = 0; i < A111SUIText.Length; i++)
        {
            SetRegistroText(A111SUIText[i], Neuro.GetA111S());
        }

        for (int i = 0; i < A112JUIText.Length; i++)
        {
            SetRegistroText(A112JUIText[i], Neuro.GetA112J());
        }

        for (int i = 0; i < A112SUIText.Length; i++)
        {
            SetRegistroText(A112SUIText[i], Neuro.GetA112S());
        }

        for (int i = 0; i < A113JUIText.Length; i++)
        {
            SetRegistroText(A113JUIText[i], Neuro.GetA113J());
        }

        for (int i = 0; i < A113SUIText.Length; i++)
        {
            SetRegistroText(A113SUIText[i], Neuro.GetA113S());
        }

        for (int i = 0; i < A114JUIText.Length; i++)
        {
            SetRegistroText(A114JUIText[i], Neuro.GetA114J());
        }

        for (int i = 0; i < A114SUIText.Length; i++)
        {
            SetRegistroText(A114SUIText[i], Neuro.GetA114S());
        }

        for (int i = 0; i < NombreText.Length; i++)
        {
            SetNombre(NombreText[i], Neuro.GetNombre());
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

    void SetNombre (TMP_Text textMesh, string nombrea)
    {
        textMesh.text = nombrea.ToString();
    }


    // Update is called once per frame
  
}
