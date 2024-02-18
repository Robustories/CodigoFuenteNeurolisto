using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class A_1_15UI : MonoBehaviour
{
     #region Singleton class: Registro

    public static A_1_15UI Instance;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    #endregion
    [SerializeField] TMP_Text[] A1151JUIText;
    [SerializeField] TMP_Text[] A1151SUIText;
    [SerializeField] TMP_Text[] A1152JUIText;
    [SerializeField] TMP_Text[] A1152SUIText;
    [SerializeField] TMP_Text[] A1153JUIText;
    [SerializeField] TMP_Text[] A1153SUIText;
    // Start is called before the first frame update
    void Start()
    {
        ActualizarRegistro();
        
    }

    public void ActualizarRegistro()
    {
        for (int i = 0; i < A1151JUIText.Length; i++)
        {
            SetRegistroText(A1151JUIText[i], Neuro.GetA1151J());
        }

        for (int i = 0; i < A1151SUIText.Length; i++)
        {
            SetRegistroText(A1151SUIText[i], Neuro.GetA1151S());
        }

        for (int i = 0; i < A1152JUIText.Length; i++)
        {
            SetRegistroText(A1152JUIText[i], Neuro.GetA1152J());
        }

        for (int i = 0; i < A1152SUIText.Length; i++)
        {
            SetRegistroText(A1152SUIText[i], Neuro.GetA1152S());
        }

        for (int i = 0; i < A1153JUIText.Length; i++)
        {
            SetRegistroText(A1153JUIText[i], Neuro.GetA1153J());
        }

        for (int i = 0; i < A1153SUIText.Length; i++)
        {
            SetRegistroText(A1153SUIText[i], Neuro.GetA1153S());
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

}
