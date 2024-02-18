using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class A_3_2UI : MonoBehaviour
{
    #region Singleton class: Registro

    public static A_3_2UI Instance;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    #endregion

    [SerializeField] TMP_Text[] A321UIText;
    [SerializeField] TMP_Text[] A322UIText;
    [SerializeField] TMP_Text[] A323UIText;
    [SerializeField] TMP_Text[] A324UIText;
    [SerializeField] TMP_Text[] A325UIText;
    [SerializeField] TMP_Text[] A326UIText;
    [SerializeField] TMP_Text[] A327UIText;
    [SerializeField] TMP_Text[] A328UIText;
    [SerializeField] TMP_Text[] A329UIText;
    [SerializeField] TMP_Text[] A3210UIText;
    [SerializeField] TMP_Text[] A3211UIText;
    [SerializeField] TMP_Text[] A3212UIText;
    [SerializeField] TMP_Text[] A3213UIText;
    [SerializeField] TMP_Text[] A3214UIText;
    [SerializeField] TMP_Text[] A3215UIText;
    [SerializeField] TMP_Text[] A321SUIText;
    [SerializeField] TMP_Text[] A322SUIText;
    [SerializeField] TMP_Text[] A323SUIText;
    [SerializeField] TMP_Text[] A324SUIText;
    [SerializeField] TMP_Text[] A325SUIText;
    [SerializeField] TMP_Text[] A326SUIText;
    [SerializeField] TMP_Text[] A327SUIText;
    [SerializeField] TMP_Text[] A328SUIText;
    [SerializeField] TMP_Text[] A329SUIText;
    [SerializeField] TMP_Text[] A3210SUIText;
    [SerializeField] TMP_Text[] A3211SUIText;
    [SerializeField] TMP_Text[] A3212SUIText;
    [SerializeField] TMP_Text[] A3213SUIText;
    [SerializeField] TMP_Text[] A3214SUIText;
    [SerializeField] TMP_Text[] A3215SUIText;
    // Start is called before the first frame update
    void Start()
    {
        ActualizarRegistro();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActualizarRegistro()
    {
        for (int i = 0; i < A321UIText.Length; i++)
        {
            SetRegistroText(A321UIText[i], Neuro.GetA321());
        }

        for (int i = 0; i < A322UIText.Length; i++)
        {
            SetRegistroText(A322UIText[i], Neuro.GetA322());
        }

        for (int i = 0; i < A323UIText.Length; i++)
        {
            SetRegistroText(A323UIText[i], Neuro.GetA323());
        }

        for (int i = 0; i < A324UIText.Length; i++)
        {
            SetRegistroText(A324UIText[i], Neuro.GetA324());
        }

        for (int i = 0; i < A325UIText.Length; i++)
        {
            SetRegistroText(A325UIText[i], Neuro.GetA325());
        }

        for (int i = 0; i < A326UIText.Length; i++)
        {
            SetRegistroText(A326UIText[i], Neuro.GetA326());
        }

        for (int i = 0; i < A327UIText.Length; i++)
        {
            SetRegistroText(A327UIText[i], Neuro.GetA327());
        }

        for (int i = 0; i < A328UIText.Length; i++)
        {
            SetRegistroText(A328UIText[i], Neuro.GetA328());
        }

        for (int i = 0; i < A329UIText.Length; i++)
        {
            SetRegistroText(A329UIText[i], Neuro.GetA329());
        }

        for (int i = 0; i < A3210UIText.Length; i++)
        {
            SetRegistroText(A3210UIText[i], Neuro.GetA3210());
        }

        for (int i = 0; i < A3211UIText.Length; i++)
        {
            SetRegistroText(A3211UIText[i], Neuro.GetA3211());
        }

        for (int i = 0; i < A3212UIText.Length; i++)
        {
            SetRegistroText(A3212UIText[i], Neuro.GetA3212());
        }

        for (int i = 0; i < A3213UIText.Length; i++)
        {
            SetRegistroText(A3213UIText[i], Neuro.GetA3213());
        }

        for (int i = 0; i < A3214UIText.Length; i++)
        {
            SetRegistroText(A3214UIText[i], Neuro.GetA3214());
        }

        for (int i = 0; i < A3215UIText.Length; i++)
        {
            SetRegistroText(A3215UIText[i], Neuro.GetA3215());
        }

        for (int i = 0; i < A321SUIText.Length; i++)
        {
            SetRegistroText(A321SUIText[i], Neuro.GetA321S());
        }

        for (int i = 0; i < A322SUIText.Length; i++)
        {
            SetRegistroText(A322SUIText[i], Neuro.GetA322S());
        }

        for (int i = 0; i < A323SUIText.Length; i++)
        {
            SetRegistroText(A323SUIText[i], Neuro.GetA323S());
        }

        for (int i = 0; i < A324SUIText.Length; i++)
        {
            SetRegistroText(A324SUIText[i], Neuro.GetA324S());
        }

        for (int i = 0; i < A325SUIText.Length; i++)
        {
            SetRegistroText(A325SUIText[i], Neuro.GetA325S());
        }

        for (int i = 0; i < A326SUIText.Length; i++)
        {
            SetRegistroText(A326SUIText[i], Neuro.GetA326S());
        }

        for (int i = 0; i < A327SUIText.Length; i++)
        {
            SetRegistroText(A327SUIText[i], Neuro.GetA327S());
        }

        for (int i = 0; i < A328SUIText.Length; i++)
        {
            SetRegistroText(A328SUIText[i], Neuro.GetA328S());
        }

        for (int i = 0; i < A329SUIText.Length; i++)
        {
            SetRegistroText(A329SUIText[i], Neuro.GetA329S());
        }

        for (int i = 0; i < A3210SUIText.Length; i++)
        {
            SetRegistroText(A3210SUIText[i], Neuro.GetA3210S());
        }

        for (int i = 0; i < A3211SUIText.Length; i++)
        {
            SetRegistroText(A3211SUIText[i], Neuro.GetA3211S());
        }

        for (int i = 0; i < A3212SUIText.Length; i++)
        {
            SetRegistroText(A3212SUIText[i], Neuro.GetA3212S());
        }

        for (int i = 0; i < A3213SUIText.Length; i++)
        {
            SetRegistroText(A3213SUIText[i], Neuro.GetA3213S());
        }

        for (int i = 0; i < A3214SUIText.Length; i++)
        {
            SetRegistroText(A3214SUIText[i], Neuro.GetA3214S());
        }

        for (int i = 0; i < A3215SUIText.Length; i++)
        {
            SetRegistroText(A3215SUIText[i], Neuro.GetA3215S());
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
