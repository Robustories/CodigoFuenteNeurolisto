using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class A_1_10UI : MonoBehaviour
{
    #region Singleton class: Registro

    public static A_1_10UI Instance;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    #endregion
    [SerializeField] TMP_Text[] A110JUIText;
    [SerializeField] TMP_Text[] A110SUIText;

    // Start is called before the first frame update
     void Start()
    {
        ActualizarRegistro();
        
    }

    public void ActualizarRegistro()
    {
        for (int i = 0; i < A110JUIText.Length; i++)
        {
            SetRegistroText(A110JUIText[i], Neuro.GetA110J());
        }

        for (int i = 0; i < A110SUIText.Length; i++)
        {
            SetRegistroText(A110SUIText[i], Neuro.GetA110S());
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
