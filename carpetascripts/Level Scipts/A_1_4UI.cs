using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class A_1_4UI : MonoBehaviour
{
    #region Singleton class: Registro

    public static A_1_4UI Instance;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    #endregion
    
    [SerializeField] TMP_Text[] A14JUIText;
    [SerializeField] TMP_Text[] A14SUIText;
    
    // Start is called before the first frame update
    void Start()
    {
        ActualizarRegistro();
        
    }

    public void ActualizarRegistro()
    {
        for (int i = 0; i < A14JUIText.Length; i++)
        {
            SetRegistroText(A14JUIText[i], Neuro.GetA14J());
        }

        for (int i = 0; i < A14SUIText.Length; i++)
        {
            SetRegistroText(A14SUIText[i], Neuro.GetA14S());
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

