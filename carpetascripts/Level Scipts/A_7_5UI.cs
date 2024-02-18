using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class A_7_5UI : MonoBehaviour
{
    #region Singleton class: Registro

    public static A_7_5UI Instance;


    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    #endregion
    [SerializeField] TMP_Text[] A751JUIText;
    [SerializeField] TMP_Text[] A751SUIText;
    [SerializeField] TMP_Text[] A752JUIText;
    [SerializeField] TMP_Text[] A752SUIText;
    [SerializeField] TMP_Text[] A753JUIText;
    [SerializeField] TMP_Text[] A753SUIText;
    [SerializeField] TMP_Text[] A76JUIText;
    [SerializeField] TMP_Text[] A76SUIText;
    // Start is called before the first frame update
    void Start()
    {
        ActualizarRegistro();
        
    }

    public void ActualizarRegistro()
    {

        for (int i = 0; i < A751JUIText.Length; i++)
        {
            SetRegistroText(A751JUIText[i], Neuro.GetA751J());
        }

        for (int i = 0; i < A751SUIText.Length; i++)
        {
            SetRegistroText(A751SUIText[i], Neuro.GetA751S());
        }

        for (int i = 0; i < A752JUIText.Length; i++)
        {
            SetRegistroText(A752JUIText[i], Neuro.GetA752J());
        }

        for (int i = 0; i < A752SUIText.Length; i++)
        {
            SetRegistroText(A752SUIText[i], Neuro.GetA752S());
        }

        for (int i = 0; i < A753JUIText.Length; i++)
        {
            SetRegistroText(A753JUIText[i], Neuro.GetA753J());
        }

        for (int i = 0; i < A753SUIText.Length; i++)
        {
            SetRegistroText(A753SUIText[i], Neuro.GetA753S());
        }

        for (int i = 0; i < A76JUIText.Length; i++)
        {
            SetRegistroText(A76JUIText[i], Neuro.GetA76J());
        }

        for (int i = 0; i < A76SUIText.Length; i++)
        {
            SetRegistroText(A76SUIText[i], Neuro.GetA76S());
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
