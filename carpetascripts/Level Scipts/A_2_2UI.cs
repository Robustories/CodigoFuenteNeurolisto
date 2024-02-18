using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class A_2_2UI : MonoBehaviour
{
    #region Singleton class: Registro

    public static A_2_2UI Instance;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    #endregion
    [SerializeField] TMP_Text[] A221JUIText;
    [SerializeField] TMP_Text[] A221SUIText;
    [SerializeField] TMP_Text[] A222JUIText;
    [SerializeField] TMP_Text[] A222SUIText;
    [SerializeField] TMP_Text[] A223JUIText;
    [SerializeField] TMP_Text[] A223SUIText;
    [SerializeField] TMP_Text[] A224JUIText;
    [SerializeField] TMP_Text[] A224SUIText;
    // Start is called before the first frame update
    void Start()
    {
        ActualizarRegistro();
        
    }

    public void ActualizarRegistro()
    {
        for (int i = 0; i < A221JUIText.Length; i++)
        {
            SetRegistroText(A221JUIText[i], Neuro.GetA221J());
        }

        for (int i = 0; i < A221SUIText.Length; i++)
        {
            SetRegistroText(A221SUIText[i], Neuro.Get221S());
        }

        for (int i = 0; i < A222JUIText.Length; i++)
        {
            SetRegistroText(A222JUIText[i], Neuro.GetA222J());
        }

        for (int i = 0; i < A222SUIText.Length; i++)
        {
            SetRegistroText(A222SUIText[i], Neuro.Get222S());
        }

        for (int i = 0; i < A223JUIText.Length; i++)
        {
            SetRegistroText(A223JUIText[i], Neuro.GetA223J());
        }

        for (int i = 0; i < A223SUIText.Length; i++)
        {
            SetRegistroText(A223SUIText[i], Neuro.Get223S());
        }

        for (int i = 0; i < A224JUIText.Length; i++)
        {
            SetRegistroText(A224JUIText[i], Neuro.GetA224J());
        }

        for (int i = 0; i < A224SUIText.Length; i++)
        {
            SetRegistroText(A224SUIText[i], Neuro.Get224S());
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
