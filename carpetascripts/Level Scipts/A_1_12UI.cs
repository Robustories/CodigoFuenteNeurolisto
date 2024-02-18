using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class A_1_12UI : MonoBehaviour
{
    #region Singleton class: Registro

    public static A_1_12UI Instance;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    #endregion
    [SerializeField] TMP_Text[] A112JUIText;
    [SerializeField] TMP_Text[] A112SUIText;

    // Start is called before the first frame update
     void Start()
    {
        ActualizarRegistro();
        
    }

    public void ActualizarRegistro()
    {
        for (int i = 0; i < A112JUIText.Length; i++)
        {
            SetRegistroText(A112JUIText[i], Neuro.GetAdoceJ());
        }

        for (int i = 0; i < A112SUIText.Length; i++)
        {
            SetRegistroText(A112SUIText[i], Neuro.GetA1doceS());
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
