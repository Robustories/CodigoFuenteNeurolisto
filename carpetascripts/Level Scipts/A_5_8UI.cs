using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class A_5_8UI : MonoBehaviour
{
    #region Singleton class: Registro

    public static A_5_8UI Instance;


    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    #endregion
    [SerializeField] TMP_Text[] A581JUIText;
    [SerializeField] TMP_Text[] A581SUIText;
    [SerializeField] TMP_Text[] A582JUIText;
    [SerializeField] TMP_Text[] A582SUIText;
    [SerializeField] TMP_Text[] A583JUIText;
    [SerializeField] TMP_Text[] A583SUIText;
    [SerializeField] TMP_Text[] A584JUIText;
    [SerializeField] TMP_Text[] A584SUIText;
    // Start is called before the first frame update
    void Start()
    {
        ActualizarRegistro();
        
    }

    public void ActualizarRegistro()
    {

        for (int i = 0; i < A581JUIText.Length; i++)
        {
            SetRegistroText(A581JUIText[i], Neuro.GetA581J());
        }

        for (int i = 0; i < A581SUIText.Length; i++)
        {
            SetRegistroText(A581SUIText[i], Neuro.Get581S());
        }

        for (int i = 0; i < A582JUIText.Length; i++)
        {
            SetRegistroText(A582JUIText[i], Neuro.GetA582J());
        }

        for (int i = 0; i < A582SUIText.Length; i++)
        {
            SetRegistroText(A582SUIText[i], Neuro.Get582S());
        }

        for (int i = 0; i < A583JUIText.Length; i++)
        {
            SetRegistroText(A583JUIText[i], Neuro.GetA583J());
        }

        for (int i = 0; i < A583SUIText.Length; i++)
        {
            SetRegistroText(A583SUIText[i], Neuro.Get583S());
        }

        for (int i = 0; i < A584JUIText.Length; i++)
        {
            SetRegistroText(A584JUIText[i], Neuro.GetA584J());
        }

        for (int i = 0; i < A584SUIText.Length; i++)
        {
            SetRegistroText(A584SUIText[i], Neuro.Get584S());
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
