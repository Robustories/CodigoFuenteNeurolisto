using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class A_4_8UI : MonoBehaviour
{
    #region Singleton class: Registro

    public static A_4_8UI Instance;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    #endregion
    [SerializeField] TMP_Text[] A481JUIText;
    [SerializeField] TMP_Text[] A481SUIText;
    [SerializeField] TMP_Text[] A482JUIText;
    [SerializeField] TMP_Text[] A482SUIText;
    [SerializeField] TMP_Text[] A483JUIText;
    [SerializeField] TMP_Text[] A483SUIText;
    // Start is called before the first frame update
    void Start()
    {
        ActualizarRegistro();
        
    }

    public void ActualizarRegistro()
    {
        for (int i = 0; i < A481JUIText.Length; i++)
        {
            SetRegistroText(A481JUIText[i], Neuro.GetA481J());
        }

        for (int i = 0; i < A481SUIText.Length; i++)
        {
            SetRegistroText(A481SUIText[i], Neuro.Get481S());
        }

        for (int i = 0; i < A482JUIText.Length; i++)
        {
            SetRegistroText(A482JUIText[i], Neuro.GetA482J());
        }

        for (int i = 0; i < A482SUIText.Length; i++)
        {
            SetRegistroText(A482SUIText[i], Neuro.Get482S());
        }

        for (int i = 0; i < A483JUIText.Length; i++)
        {
            SetRegistroText(A483JUIText[i], Neuro.GetA483J());
        }

        for (int i = 0; i < A483SUIText.Length; i++)
        {
            SetRegistroText(A483SUIText[i], Neuro.Get483S());
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
