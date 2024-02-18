using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class A_5_9UI : MonoBehaviour
{
    #region Singleton class: Registro

    public static A_5_9UI Instance;


    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    #endregion
    [SerializeField] TMP_Text[] A59JUIText;
    [SerializeField] TMP_Text[] A59SUIText;
    [SerializeField] TMP_Text[] A5101JUIText;
    [SerializeField] TMP_Text[] A5101SUIText;
    [SerializeField] TMP_Text[] A5102JUIText;
    [SerializeField] TMP_Text[] A5102SUIText;
    [SerializeField] TMP_Text[] A5103JUIText;
    [SerializeField] TMP_Text[] A5103SUIText;
    // Start is called before the first frame update
    void Start()
    {
        ActualizarRegistro();
        
    }

    public void ActualizarRegistro()
    {

        for (int i = 0; i < A59JUIText.Length; i++)
        {
            SetRegistroText(A59JUIText[i], Neuro.GetA59J());
        }

        for (int i = 0; i < A59SUIText.Length; i++)
        {
            SetRegistroText(A59SUIText[i], Neuro.Get59S());
        }

        for (int i = 0; i < A5101JUIText.Length; i++)
        {
            SetRegistroText(A5101JUIText[i], Neuro.GetA5101J());
        }

        for (int i = 0; i < A5101SUIText.Length; i++)
        {
            SetRegistroText(A5101SUIText[i], Neuro.Get5101S());
        }

        for (int i = 0; i < A5102JUIText.Length; i++)
        {
            SetRegistroText(A5102JUIText[i], Neuro.GetA5102J());
        }

        for (int i = 0; i < A5102SUIText.Length; i++)
        {
            SetRegistroText(A5102SUIText[i], Neuro.Get5102S());
        }

        for (int i = 0; i < A5103JUIText.Length; i++)
        {
            SetRegistroText(A5103JUIText[i], Neuro.GetA5103J());
        }

        for (int i = 0; i < A5103SUIText.Length; i++)
        {
            SetRegistroText(A5103SUIText[i], Neuro.Get5103S());
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
