using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class A_6_1UI : MonoBehaviour
{
    #region Singleton class: Registro

    public static A_6_1UI Instance;


    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    #endregion
    
    [SerializeField] TMP_Text[] A611JUIText;
    [SerializeField] TMP_Text[] A611SUIText;
    [SerializeField] TMP_Text[] A612JUIText;
    [SerializeField] TMP_Text[] A612SUIText;
    [SerializeField] TMP_Text[] A62JUIText;
    [SerializeField] TMP_Text[] A62SUIText;

    void Start()
    {
        ActualizarRegistro();
        
    }

    public void ActualizarRegistro()
    {

        for (int i = 0; i < A611JUIText.Length; i++)
        {
            SetRegistroText(A611JUIText[i], Neuro.GetA611J());
        }

        for (int i = 0; i < A611SUIText.Length; i++)
        {
            SetRegistroText(A611SUIText[i], Neuro.Get611S());
        }

        for (int i = 0; i < A612JUIText.Length; i++)
        {
            SetRegistroText(A612JUIText[i], Neuro.GetA612J());
        }

        for (int i = 0; i < A612SUIText.Length; i++)
        {
            SetRegistroText(A612SUIText[i], Neuro.Get612S());
        }

        for (int i = 0; i < A62JUIText.Length; i++)
        {
            SetRegistroText(A62JUIText[i], Neuro.GetA62J());
        }

        for (int i = 0; i < A62SUIText.Length; i++)
        {
            SetRegistroText(A62SUIText[i], Neuro.Get62S());
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
