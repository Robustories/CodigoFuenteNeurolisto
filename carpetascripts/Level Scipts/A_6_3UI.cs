using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class A_6_3UI : MonoBehaviour
{
    #region Singleton class: Registro

    public static A_6_3UI Instance;


    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    #endregion
    [SerializeField] TMP_Text[] A631JUIText;
    [SerializeField] TMP_Text[] A631SUIText;
    [SerializeField] TMP_Text[] A632JUIText;
    [SerializeField] TMP_Text[] A632SUIText;
    [SerializeField] TMP_Text[] A633JUIText;
    [SerializeField] TMP_Text[] A633SUIText;
    [SerializeField] TMP_Text[] A634JUIText;
    [SerializeField] TMP_Text[] A634SUIText;
    [SerializeField] TMP_Text[] A635JUIText;
    [SerializeField] TMP_Text[] A635SUIText;
    // Start is called before the first frame update
     void Start()
    {
        ActualizarRegistro();
        
    }

    public void ActualizarRegistro()
    {

        for (int i = 0; i < A631JUIText.Length; i++)
        {
            SetRegistroText(A631JUIText[i], Neuro.GetA631J());
        }

        for (int i = 0; i < A631SUIText.Length; i++)
        {
            SetRegistroText(A631SUIText[i], Neuro.Get631S());
        }

        for (int i = 0; i < A632JUIText.Length; i++)
        {
            SetRegistroText(A632JUIText[i], Neuro.GetA632J());
        }

        for (int i = 0; i < A632SUIText.Length; i++)
        {
            SetRegistroText(A632SUIText[i], Neuro.Get632S());
        }

        for (int i = 0; i < A633JUIText.Length; i++)
        {
            SetRegistroText(A633JUIText[i], Neuro.GetA633J());
        }

        for (int i = 0; i < A633SUIText.Length; i++)
        {
            SetRegistroText(A633SUIText[i], Neuro.Get633S());
        }

        for (int i = 0; i < A634JUIText.Length; i++)
        {
            SetRegistroText(A634JUIText[i], Neuro.GetA634J());
        }

        for (int i = 0; i < A634SUIText.Length; i++)
        {
            SetRegistroText(A634SUIText[i], Neuro.Get634S());
        }

        for (int i = 0; i < A635JUIText.Length; i++)
        {
            SetRegistroText(A635JUIText[i], Neuro.GetA635J());
        }

        for (int i = 0; i < A635SUIText.Length; i++)
        {
            SetRegistroText(A635SUIText[i], Neuro.Get635S());
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

