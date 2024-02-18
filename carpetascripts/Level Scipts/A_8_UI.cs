using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class A_8_UI : MonoBehaviour
{
    #region Singleton class: Registro

    public static A_8_UI Instance;


    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    #endregion

    [SerializeField] TMP_Text[] A81JUIText;
    [SerializeField] TMP_Text[] A82JUIText;
    [SerializeField] TMP_Text[] A83JUIText;
    [SerializeField] TMP_Text[] A84JUIText;
    [SerializeField] TMP_Text[] A85JUIText;
    [SerializeField] TMP_Text[] A86JUIText;
    [SerializeField] TMP_Text[] A87JUIText;
    [SerializeField] TMP_Text[] A88JUIText;

    // Start is called before the first frame update
    void Start()
    {
        ActualizarRegistro();
        
    }

    public void ActualizarRegistro()
    {

        for (int i = 0; i < A81JUIText.Length; i++)
        {
            SetRegistroText(A81JUIText[i], Neuro.GetA81());
        }

        for (int i = 0; i < A82JUIText.Length; i++)
        {
            SetRegistroText(A82JUIText[i], Neuro.GetA82());
        }

        for (int i = 0; i < A83JUIText.Length; i++)
        {
            SetRegistroText(A83JUIText[i], Neuro.GetA83());
        }

        for (int i = 0; i < A84JUIText.Length; i++)
        {
            SetRegistroText(A84JUIText[i], Neuro.GetA84());
        }

        for (int i = 0; i < A85JUIText.Length; i++)
        {
            SetRegistroText(A85JUIText[i], Neuro.GetA85());
        }

        for (int i = 0; i < A86JUIText.Length; i++)
        {
            SetRegistroText(A86JUIText[i], Neuro.GetA86());
        }

        for (int i = 0; i < A87JUIText.Length; i++)
        {
            SetRegistroText(A87JUIText[i], Neuro.GetA85());
        }

        for (int i = 0; i < A88JUIText.Length; i++)
        {
            SetRegistroText(A88JUIText[i], Neuro.GetA86());
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
