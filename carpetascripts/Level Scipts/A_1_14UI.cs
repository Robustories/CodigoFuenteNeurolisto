using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class A_1_14UI : MonoBehaviour
{
    #region Singleton class: Registro

    public static A_1_14UI Instance;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }
    #endregion
    [SerializeField] TMP_Text[] A114JUIText;
    [SerializeField] TMP_Text[] A114SUIText;

    // Start is called before the first frame update
     void Start()
    {
        ActualizarRegistro();
        
    }

    public void ActualizarRegistro()
    {
        for (int i = 0; i < A114JUIText.Length; i++)
        {
            SetRegistroText(A114JUIText[i], Neuro.GetA1catorceJ());
        }

        for (int i = 0; i < A114SUIText.Length; i++)
        {
            SetRegistroText(A114SUIText[i], Neuro.GetA1catorceS());
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
