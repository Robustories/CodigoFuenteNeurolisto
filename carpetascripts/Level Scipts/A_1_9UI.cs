using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class A_1_9UI : MonoBehaviour
{
    #region Singleton class: Registro

    public static A_1_9UI Instance;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    #endregion
    [SerializeField] TMP_Text[] A19JUIText;
    [SerializeField] TMP_Text[] A19SUIText;

    // Start is called before the first frame update
     void Start()
    {
        ActualizarRegistro();
        
    }

    public void ActualizarRegistro()
    {
        for (int i = 0; i < A19JUIText.Length; i++)
        {
            SetRegistroText(A19JUIText[i], Neuro.GetA19J());
        }

        for (int i = 0; i < A19SUIText.Length; i++)
        {
            SetRegistroText(A19SUIText[i], Neuro.GetA19S());
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
