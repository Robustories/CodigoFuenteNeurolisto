using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class A_2_8UI : MonoBehaviour
{
    #region Singleton class: Registro

    public static A_2_8UI Instance;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    #endregion

    [SerializeField] TMP_Text[] A281JUIText;
    [SerializeField] TMP_Text[] A281SUIText;
    [SerializeField] TMP_Text[] A282JUIText;
    [SerializeField] TMP_Text[] A282SUIText;
    [SerializeField] TMP_Text[] A283JUIText;
    [SerializeField] TMP_Text[] A283SUIText;
    // Start is called before the first frame update
    void Start()
    {
        ActualizarRegistro();
        
    }

    public void ActualizarRegistro()
    {
        for (int i = 0; i < A281JUIText.Length; i++)
        {
            SetRegistroText(A281JUIText[i], Neuro.GetA281J());
        }

        for (int i = 0; i < A281SUIText.Length; i++)
        {
            SetRegistroText(A281SUIText[i], Neuro.Get281S());
        }

        for (int i = 0; i < A282JUIText.Length; i++)
        {
            SetRegistroText(A282JUIText[i], Neuro.GetA282J());
        }

        for (int i = 0; i < A282SUIText.Length; i++)
        {
            SetRegistroText(A282SUIText[i], Neuro.Get282S());
        }

        for (int i = 0; i < A283JUIText.Length; i++)
        {
            SetRegistroText(A283JUIText[i], Neuro.GetA283J());
        }

        for (int i = 0; i < A283SUIText.Length; i++)
        {
            SetRegistroText(A283SUIText[i], Neuro.Get283S());
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
