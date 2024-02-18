using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class A_5_1UI : MonoBehaviour
{
    #region Singleton class: Registro

    public static A_5_1UI Instance;


    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    #endregion
    [SerializeField] TMP_Text[] A511JUIText;
    [SerializeField] TMP_Text[] A511SUIText;
    [SerializeField] TMP_Text[] A512JUIText;
    [SerializeField] TMP_Text[] A512SUIText;
    [SerializeField] TMP_Text[] A513JUIText;
    [SerializeField] TMP_Text[] A513SUIText;
    [SerializeField] TMP_Text[] A514JUIText;
    [SerializeField] TMP_Text[] A514SUIText;
    [SerializeField] TMP_Text[] A515JUIText;
    [SerializeField] TMP_Text[] A515SUIText;
    [SerializeField] TMP_Text[] A516JUIText;
    [SerializeField] TMP_Text[] A516SUIText;
    // Start is called before the first frame update
    void Start()
    {
        ActualizarRegistro();
        
    }

    public void ActualizarRegistro()
    {
        for (int i = 0; i < A511JUIText.Length; i++)
        {
            SetRegistroText(A511JUIText[i], Neuro.GetA511J());
        }

        for (int i = 0; i < A511SUIText.Length; i++)
        {
            SetRegistroText(A511SUIText[i], Neuro.Get511S());
        }

        for (int i = 0; i < A512JUIText.Length; i++)
        {
            SetRegistroText(A512JUIText[i], Neuro.GetA512J());
        }

        for (int i = 0; i < A512SUIText.Length; i++)
        {
            SetRegistroText(A512SUIText[i], Neuro.Get512S());
        }

        for (int i = 0; i < A513JUIText.Length; i++)
        {
            SetRegistroText(A513JUIText[i], Neuro.GetA513J());
        }

        for (int i = 0; i < A513SUIText.Length; i++)
        {
            SetRegistroText(A513SUIText[i], Neuro.Get513S());
        }

        for (int i = 0; i < A514JUIText.Length; i++)
        {
            SetRegistroText(A514JUIText[i], Neuro.GetA514J());
        }

        for (int i = 0; i < A514SUIText.Length; i++)
        {
            SetRegistroText(A514SUIText[i], Neuro.Get514S());
        }

        for (int i = 0; i < A515JUIText.Length; i++)
        {
            SetRegistroText(A515JUIText[i], Neuro.GetA515J());
        }

        for (int i = 0; i < A515SUIText.Length; i++)
        {
            SetRegistroText(A515SUIText[i], Neuro.Get515S());
        }

        for (int i = 0; i < A516JUIText.Length; i++)
        {
            SetRegistroText(A516JUIText[i], Neuro.GetA516J());
        }

        for (int i = 0; i < A516SUIText.Length; i++)
        {
            SetRegistroText(A516SUIText[i], Neuro.Get516S());
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
