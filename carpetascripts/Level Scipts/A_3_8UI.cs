using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class A_3_8UI : MonoBehaviour
{
    #region Singleton class: Registro

    public static A_3_8UI Instance;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    #endregion
    [SerializeField] TMP_Text[] A381JUIText;
    [SerializeField] TMP_Text[] A381SUIText;
    [SerializeField] TMP_Text[] A382JUIText;
    [SerializeField] TMP_Text[] A382SUIText;
    [SerializeField] TMP_Text[] A383JUIText;
    [SerializeField] TMP_Text[] A383SUIText;
    // Start is called before the first frame update
    void Start()
    {
        ActualizarRegistro();
        
    }

    public void ActualizarRegistro()
    {
        for (int i = 0; i < A381JUIText.Length; i++)
        {
            SetRegistroText(A381JUIText[i], Neuro.GetA381J());
        }

        for (int i = 0; i < A381SUIText.Length; i++)
        {
            SetRegistroText(A381SUIText[i], Neuro.Get381S());
        }

        for (int i = 0; i < A382JUIText.Length; i++)
        {
            SetRegistroText(A382JUIText[i], Neuro.GetA382J());
        }

        for (int i = 0; i < A382SUIText.Length; i++)
        {
            SetRegistroText(A382SUIText[i], Neuro.Get382S());
        }

        for (int i = 0; i < A383JUIText.Length; i++)
        {
            SetRegistroText(A383JUIText[i], Neuro.GetA383J());
        }

        for (int i = 0; i < A383SUIText.Length; i++)
        {
            SetRegistroText(A383SUIText[i], Neuro.Get383S());
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
