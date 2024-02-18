using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class A_8_9UI : MonoBehaviour
{
    #region Singleton class: Registro

    public static A_8_9UI Instance;


    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    #endregion

    [SerializeField] TMP_Text[] A891JUIText;
    [SerializeField] TMP_Text[] A892JUIText;
    [SerializeField] TMP_Text[] A893JUIText;
    [SerializeField] TMP_Text[] A810JUIText;
    // Start is called before the first frame update
    void Start()
    {
        ActualizarRegistro();
        
    }

    public void ActualizarRegistro()
    {

        for (int i = 0; i < A891JUIText.Length; i++)
        {
            SetRegistroText(A891JUIText[i], Neuro.GetA891());
        }

        for (int i = 0; i < A892JUIText.Length; i++)
        {
            SetRegistroText(A892JUIText[i], Neuro.GetA892());
        }

        for (int i = 0; i < A893JUIText.Length; i++)
        {
            SetRegistroText(A893JUIText[i], Neuro.GetA893());
        }

        for (int i = 0; i < A810JUIText.Length; i++)
        {
            SetRegistroText(A810JUIText[i], Neuro.GetA810());
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
}
