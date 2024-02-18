using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class A_6_15UI : MonoBehaviour
{
    #region Singleton class: Registro

    public static A_6_15UI Instance;


    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    #endregion
    [SerializeField] TMP_Text[] A6151JUIText;
    [SerializeField] TMP_Text[] A6151SUIText;
    [SerializeField] TMP_Text[] A6152JUIText;
    [SerializeField] TMP_Text[] A6152SUIText;
    [SerializeField] TMP_Text[] A6153JUIText;
    [SerializeField] TMP_Text[] A6153SUIText;
    // Start is called before the first frame update
     void Start()
    {
        ActualizarRegistro();
        
    }

    public void ActualizarRegistro()
    {

        for (int i = 0; i < A6151JUIText.Length; i++)
        {
            SetRegistroText(A6151JUIText[i], Neuro.GetA6151J());
        }

        for (int i = 0; i < A6151SUIText.Length; i++)
        {
            SetRegistroText(A6151SUIText[i], Neuro.Get6151S());
        }

        for (int i = 0; i < A6152JUIText.Length; i++)
        {
            SetRegistroText(A6152JUIText[i], Neuro.GetA6152J());
        }

        for (int i = 0; i < A6152SUIText.Length; i++)
        {
            SetRegistroText(A6152SUIText[i], Neuro.Get6152S());
        }

        for (int i = 0; i < A6153JUIText.Length; i++)
        {
            SetRegistroText(A6153JUIText[i], Neuro.GetA6153J());
        }

        for (int i = 0; i < A6153SUIText.Length; i++)
        {
            SetRegistroText(A6153SUIText[i], Neuro.Get6153S());
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
