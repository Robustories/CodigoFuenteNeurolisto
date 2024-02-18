using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class A_7_2_UI : MonoBehaviour
{
    #region Singleton class: Registro

    public static A_7_2_UI Instance;


    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    #endregion

    [SerializeField] TMP_Text[] A721JUIText;
    [SerializeField] TMP_Text[] A721SUIText;
    [SerializeField] TMP_Text[] A722JUIText;
    [SerializeField] TMP_Text[] A722SUIText;
    [SerializeField] TMP_Text[] A723JUIText;
    [SerializeField] TMP_Text[] A723SUIText;

    // Start is called before the first frame update
    void Start()
    {
        ActualizarRegistro();
        
    }

    public void ActualizarRegistro()
    {

        for (int i = 0; i < A721JUIText.Length; i++)
        {
            SetRegistroText(A721JUIText[i], Neuro.GetA721J());
        }

        for (int i = 0; i < A721SUIText.Length; i++)
        {
            SetRegistroText(A721SUIText[i], Neuro.GetA721S());
        }

        for (int i = 0; i < A722JUIText.Length; i++)
        {
            SetRegistroText(A722JUIText[i], Neuro.GetA722J());
        }

        for (int i = 0; i < A722SUIText.Length; i++)
        {
            SetRegistroText(A722SUIText[i], Neuro.GetA722S());
        }

        for (int i = 0; i < A723JUIText.Length; i++)
        {
            SetRegistroText(A723JUIText[i], Neuro.GetA723J());
        }

        for (int i = 0; i < A723SUIText.Length; i++)
        {
            SetRegistroText(A723SUIText[i], Neuro.GetA723S());
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
