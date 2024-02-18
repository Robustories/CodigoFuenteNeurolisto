using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class A_4_1UI : MonoBehaviour
{
    #region Singleton class: Registro

    public static A_4_1UI Instance;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    #endregion
    [SerializeField] TMP_Text[] A41JUIText;
    [SerializeField] TMP_Text[] A41SUIText;
    [SerializeField] TMP_Text[] A42JUIText;
    [SerializeField] TMP_Text[] A42SUIText;
    // Start is called before the first frame update
    void Start()
    {
        ActualizarRegistro();
        
    }

    public void ActualizarRegistro()
    {
        for (int i = 0; i < A41JUIText.Length; i++)
        {
            SetRegistroText(A41JUIText[i], Neuro.GetA41J());
        }

        for (int i = 0; i < A41SUIText.Length; i++)
        {
            SetRegistroText(A41SUIText[i], Neuro.Get41S());
        }

        for (int i = 0; i < A42JUIText.Length; i++)
        {
            SetRegistroText(A42JUIText[i], Neuro.GetA42J());
        }

        for (int i = 0; i < A42SUIText.Length; i++)
        {
            SetRegistroText(A42SUIText[i], Neuro.Get42S());
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
