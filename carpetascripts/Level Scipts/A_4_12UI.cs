using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class A_4_12UI : MonoBehaviour
{
    #region Singleton class: Registro

    public static A_4_12UI Instance;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    #endregion
    [SerializeField] TMP_Text[] A4121JUIText;
    [SerializeField] TMP_Text[] A4121SUIText;
    [SerializeField] TMP_Text[] A4122JUIText;
    [SerializeField] TMP_Text[] A4122SUIText;
    [SerializeField] TMP_Text[] A4123JUIText;
    [SerializeField] TMP_Text[] A4123SUIText;
    // Start is called before the first frame update
    void Start()
    {
        ActualizarRegistro();
        
    }

    public void ActualizarRegistro()
    {
        for (int i = 0; i < A4121JUIText.Length; i++)
        {
            SetRegistroText(A4121JUIText[i], Neuro.GetA4121J());
        }

        for (int i = 0; i < A4121SUIText.Length; i++)
        {
            SetRegistroText(A4121SUIText[i], Neuro.Get4121S());
        }

        for (int i = 0; i < A4122JUIText.Length; i++)
        {
            SetRegistroText(A4122JUIText[i], Neuro.GetA4122J());
        }

        for (int i = 0; i < A4122SUIText.Length; i++)
        {
            SetRegistroText(A4122SUIText[i], Neuro.Get4122S());
        }

        for (int i = 0; i < A4123JUIText.Length; i++)
        {
            SetRegistroText(A4123JUIText[i], Neuro.GetA4123J());
        }

        for (int i = 0; i < A4123SUIText.Length; i++)
        {
            SetRegistroText(A4123SUIText[i], Neuro.Get4123S());
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
