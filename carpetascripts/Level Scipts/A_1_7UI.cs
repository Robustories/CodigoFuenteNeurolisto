using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class A_1_7UI : MonoBehaviour
{
    #region Singleton class: Registro

    public static A_1_7UI Instance;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    #endregion

    [SerializeField] TMP_Text[] A17JUIText;
    [SerializeField] TMP_Text[] A17SUIText;

    // Start is called before the first frame update
     void Start()
    {
        ActualizarRegistro();
        
    }

    public void ActualizarRegistro()
    {
        for (int i = 0; i < A17JUIText.Length; i++)
        {
            SetRegistroText(A17JUIText[i], Neuro.GetA17J());
        }

        for (int i = 0; i < A17SUIText.Length; i++)
        {
            SetRegistroText(A17SUIText[i], Neuro.GetA17S());
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
