using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class A_6_9UI : MonoBehaviour
{
    #region Singleton class: Registro

    public static A_6_9UI Instance;


    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    #endregion
    [SerializeField] TMP_Text[] A691JUIText;
    [SerializeField] TMP_Text[] A691SUIText;
    [SerializeField] TMP_Text[] A692JUIText;
    [SerializeField] TMP_Text[] A692SUIText;
    [SerializeField] TMP_Text[] A693JUIText;
    [SerializeField] TMP_Text[] A693SUIText;
    [SerializeField] TMP_Text[] A610JUIText;
    [SerializeField] TMP_Text[] A610SUIText;
    [SerializeField] TMP_Text[] A6102JUIText;
    [SerializeField] TMP_Text[] A6102SUIText;
    [SerializeField] TMP_Text[] A6103JUIText;
    [SerializeField] TMP_Text[] A6103SUIText;
    // Start is called before the first frame update
    void Start()
    {
        ActualizarRegistro();
        
    }

    public void ActualizarRegistro()
    {

        for (int i = 0; i < A691JUIText.Length; i++)
        {
            SetRegistroText(A691JUIText[i], Neuro.GetA691J());
        }

        for (int i = 0; i < A691SUIText.Length; i++)
        {
            SetRegistroText(A691SUIText[i], Neuro.Get691S());
        }

        for (int i = 0; i < A692JUIText.Length; i++)
        {
            SetRegistroText(A692JUIText[i], Neuro.GetA692J());
        }

        for (int i = 0; i < A692SUIText.Length; i++)
        {
            SetRegistroText(A692SUIText[i], Neuro.Get692S());
        }

        for (int i = 0; i < A693JUIText.Length; i++)
        {
            SetRegistroText(A693JUIText[i], Neuro.GetA693J());
        }

        for (int i = 0; i < A693SUIText.Length; i++)
        {
            SetRegistroText(A693SUIText[i], Neuro.Get693S());
        }

        for (int i = 0; i < A610JUIText.Length; i++)
        {
            SetRegistroText(A610JUIText[i], Neuro.GetA610J());
        }

        for (int i = 0; i < A610SUIText.Length; i++)
        {
            SetRegistroText(A610SUIText[i], Neuro.Get610S());
        }

        for (int i = 0; i < A6102JUIText.Length; i++)
        {
            SetRegistroText(A6102JUIText[i], Neuro.GetA6102J());
        }

        for (int i = 0; i < A6102SUIText.Length; i++)
        {
            SetRegistroText(A6102SUIText[i], Neuro.Get6102S());
        }

        for (int i = 0; i < A6103JUIText.Length; i++)
        {
            SetRegistroText(A6103JUIText[i], Neuro.GetA6103J());
        }

        for (int i = 0; i < A6103SUIText.Length; i++)
        {
            SetRegistroText(A6103SUIText[i], Neuro.Get6103S());
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
