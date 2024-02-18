using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class A_1_2UI : MonoBehaviour
{
    #region Singleton class: Registro

    public static A_1_2UI Instance;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    #endregion

    [SerializeField] TMP_Text[] A12JUIText;
    [SerializeField] TMP_Text[] A12SUIText;
    
    // Start is called before the first frame update
    void Start()
    {
        ActualizarRegistro();
        
    }

    public void ActualizarRegistro()
    {
        for (int i = 0; i < A12JUIText.Length; i++)
        {
            SetRegistroText(A12JUIText[i], Neuro.GetA12J());
        }

        for (int i = 0; i < A12SUIText.Length; i++)
        {
            SetRegistroText(A12SUIText[i], Neuro.GetA12S());
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
