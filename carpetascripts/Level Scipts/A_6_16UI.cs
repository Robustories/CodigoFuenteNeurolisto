using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class A_6_16UI : MonoBehaviour
{
     #region Singleton class: Registro

    public static A_6_16UI Instance;


    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    #endregion
    [SerializeField] TMP_Text[] A6161JUIText;
    [SerializeField] TMP_Text[] A6161SUIText;
    [SerializeField] TMP_Text[] A6162JUIText;
    [SerializeField] TMP_Text[] A6162SUIText;
    [SerializeField] TMP_Text[] A6163JUIText;
    [SerializeField] TMP_Text[] A6163SUIText;
    // Start is called before the first frame update
     void Start()
    {
        ActualizarRegistro();
        
    }

    public void ActualizarRegistro()
    {

        for (int i = 0; i < A6161JUIText.Length; i++)
        {
            SetRegistroText(A6161JUIText[i], Neuro.GetA6161J());
        }

        for (int i = 0; i < A6161SUIText.Length; i++)
        {
            SetRegistroText(A6161SUIText[i], Neuro.Get6161S());
        }

        for (int i = 0; i < A6162JUIText.Length; i++)
        {
            SetRegistroText(A6162JUIText[i], Neuro.GetA6162J());
        }

        for (int i = 0; i < A6162SUIText.Length; i++)
        {
            SetRegistroText(A6162SUIText[i], Neuro.Get6162S());
        }

        for (int i = 0; i < A6163JUIText.Length; i++)
        {
            SetRegistroText(A6163JUIText[i], Neuro.GetA6163J());
        }

        for (int i = 0; i < A6163SUIText.Length; i++)
        {
            SetRegistroText(A6163SUIText[i], Neuro.GetA6163S());
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
