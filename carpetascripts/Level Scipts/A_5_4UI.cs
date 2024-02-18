using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class A_5_4UI : MonoBehaviour
{
    #region Singleton class: Registro

    public static A_5_4UI Instance;


    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    #endregion
    [SerializeField] TMP_Text[] A541JUIText;
    [SerializeField] TMP_Text[] A541SUIText;
    [SerializeField] TMP_Text[] A542JUIText;
    [SerializeField] TMP_Text[] A542SUIText;
    [SerializeField] TMP_Text[] A543JUIText;
    [SerializeField] TMP_Text[] A543SUIText;
    // Start is called before the first frame update
    void Start()
    {
        ActualizarRegistro();
        
    }

    public void ActualizarRegistro()
    {

        for (int i = 0; i < A541JUIText.Length; i++)
        {
            SetRegistroText(A541JUIText[i], Neuro.GetA541J());
        }

        for (int i = 0; i < A541SUIText.Length; i++)
        {
            SetRegistroText(A541SUIText[i], Neuro.Get541S());
        }

        for (int i = 0; i < A542JUIText.Length; i++)
        {
            SetRegistroText(A542JUIText[i], Neuro.GetA542J());
        }

        for (int i = 0; i < A542SUIText.Length; i++)
        {
            SetRegistroText(A542SUIText[i], Neuro.Get542S());
        }

        for (int i = 0; i < A543JUIText.Length; i++)
        {
            SetRegistroText(A543JUIText[i], Neuro.GetA543J());
        }

        for (int i = 0; i < A543SUIText.Length; i++)
        {
            SetRegistroText(A543SUIText[i], Neuro.Get543S());
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
