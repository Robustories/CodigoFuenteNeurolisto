using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class A_5_6UI : MonoBehaviour
{
    #region Singleton class: Registro

    public static A_5_6UI Instance;


    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    #endregion
    [SerializeField] TMP_Text[] A56JUIText;
    [SerializeField] TMP_Text[] A56SUIText;
    [SerializeField] TMP_Text[] A57JUIText;
    [SerializeField] TMP_Text[] A57SUIText;

    void Start()
    {
        ActualizarRegistro();
        
    }

    public void ActualizarRegistro()
    {

        for (int i = 0; i < A56JUIText.Length; i++)
        {
            SetRegistroText(A56JUIText[i], Neuro.GetA56J());
        }

        for (int i = 0; i < A56SUIText.Length; i++)
        {
            SetRegistroText(A56SUIText[i], Neuro.Get56S());
        }

        for (int i = 0; i < A57JUIText.Length; i++)
        {
            SetRegistroText(A57JUIText[i], Neuro.GetA57J());
        }

        for (int i = 0; i < A57SUIText.Length; i++)
        {
            SetRegistroText(A57SUIText[i], Neuro.Get57S());
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
