using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class A_1_6UI : MonoBehaviour
{
    #region Singleton class: Registro

    public static A_1_6UI Instance;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    #endregion

    [SerializeField] TMP_Text[] A161JUIText;
    [SerializeField] TMP_Text[] A161SUIText;
    [SerializeField] TMP_Text[] A162JUIText;
    [SerializeField] TMP_Text[] A162SUIText;
    [SerializeField] TMP_Text[] A163JUIText;
    [SerializeField] TMP_Text[] A163SUIText;
    // Start is called before the first frame update
    void Start()
    {
        ActualizarRegistro();
        
    }

    public void ActualizarRegistro()
    {
        for (int i = 0; i < A161JUIText.Length; i++)
        {
            SetRegistroText(A161JUIText[i], Neuro.GetA161J());
        }

        for (int i = 0; i < A161SUIText.Length; i++)
        {
            SetRegistroText(A161SUIText[i], Neuro.GetA161S());
        }

        for (int i = 0; i < A162JUIText.Length; i++)
        {
            SetRegistroText(A162JUIText[i], Neuro.GetA162J());
        }

        for (int i = 0; i < A162SUIText.Length; i++)
        {
            SetRegistroText(A162SUIText[i], Neuro.GetA162S());
        }

        for (int i = 0; i < A163JUIText.Length; i++)
        {
            SetRegistroText(A163JUIText[i], Neuro.GetA163J());
        }

        for (int i = 0; i < A163SUIText.Length; i++)
        {
            SetRegistroText(A163SUIText[i], Neuro.GetA163S());
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
