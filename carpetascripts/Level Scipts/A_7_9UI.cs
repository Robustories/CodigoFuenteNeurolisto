using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class A_7_9UI : MonoBehaviour
{
    #region Singleton class: Registro

    public static A_7_9UI Instance;


    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    #endregion
    [SerializeField] TMP_Text[] A7101JUIText;
    [SerializeField] TMP_Text[] A7101SUIText;
    [SerializeField] TMP_Text[] A7102JUIText;
    [SerializeField] TMP_Text[] A7102SUIText;
    [SerializeField] TMP_Text[] A7103JUIText;
    [SerializeField] TMP_Text[] A7103SUIText;
    [SerializeField] TMP_Text[] A79JUIText;
    [SerializeField] TMP_Text[] A79SUIText;
    // Start is called before the first frame update
    void Start()
    {
        ActualizarRegistro();
        
    }

    public void ActualizarRegistro()
    {

        for (int i = 0; i < A7101JUIText.Length; i++)
        {
            SetRegistroText(A7101JUIText[i], Neuro.GetA7101J());
        }

        for (int i = 0; i < A7101SUIText.Length; i++)
        {
            SetRegistroText(A7101SUIText[i], Neuro.GetA7101S());
        }

        for (int i = 0; i < A7102JUIText.Length; i++)
        {
            SetRegistroText(A7102JUIText[i], Neuro.GetA7102J());
        }

        for (int i = 0; i < A7102SUIText.Length; i++)
        {
            SetRegistroText(A7102SUIText[i], Neuro.GetA7102S());
        }

        for (int i = 0; i < A7103JUIText.Length; i++)
        {
            SetRegistroText(A7103JUIText[i], Neuro.GetA7103J());
        }

        for (int i = 0; i < A7103SUIText.Length; i++)
        {
            SetRegistroText(A7103SUIText[i], Neuro.GetA7103S());
        }

        for (int i = 0; i < A79JUIText.Length; i++)
        {
            SetRegistroText(A79JUIText[i], Neuro.GetA79J());
        }

        for (int i = 0; i < A79SUIText.Length; i++)
        {
            SetRegistroText(A79SUIText[i], Neuro.GetA79S());
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
    
    
