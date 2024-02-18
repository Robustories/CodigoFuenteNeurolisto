using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class A_3_1UI : MonoBehaviour
{
    #region Singleton class: Registro

    public static A_3_1UI Instance;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    #endregion

    [SerializeField] TMP_Text[] A31AUIText;
    [SerializeField] TMP_Text[] A31DUIText;
    [SerializeField] TMP_Text[] A31EUIText;
    [SerializeField] TMP_Text[] A31FUIText;
    [SerializeField] TMP_Text[] A31IUIText;
    [SerializeField] TMP_Text[] A31LUIText;
    [SerializeField] TMP_Text[] A31MUIText;
    [SerializeField] TMP_Text[] A31NUIText;
    [SerializeField] TMP_Text[] A31OUIText;
    [SerializeField] TMP_Text[] A31PUIText;
    [SerializeField] TMP_Text[] A31RUIText;
    [SerializeField] TMP_Text[] A31SUIText;
    [SerializeField] TMP_Text[] A31TUIText;
    [SerializeField] TMP_Text[] A31UUIText;
    [SerializeField] TMP_Text[] A31ASUIText;
    [SerializeField] TMP_Text[] A31DSUIText;
    [SerializeField] TMP_Text[] A31ESUIText;
    [SerializeField] TMP_Text[] A31FSUIText;
    [SerializeField] TMP_Text[] A31ISUIText;
    [SerializeField] TMP_Text[] A31LSUIText;
    [SerializeField] TMP_Text[] A31MSUIText;
    [SerializeField] TMP_Text[] A31NSUIText;
    [SerializeField] TMP_Text[] A31OSUIText;
    [SerializeField] TMP_Text[] A31PSUIText;
    [SerializeField] TMP_Text[] A31RSUIText;
    [SerializeField] TMP_Text[] A31SSUIText;
    [SerializeField] TMP_Text[] A31TSUIText;
    [SerializeField] TMP_Text[] A31USUIText;
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
        for (int i = 0; i < A31AUIText.Length; i++)
        {
            SetRegistroText(A31AUIText[i], Neuro.GetA31A());
        }

        for (int i = 0; i < A31DUIText.Length; i++)
        {
            SetRegistroText(A31DUIText[i], Neuro.GetA31D());
        }

        for (int i = 0; i < A31EUIText.Length; i++)
        {
            SetRegistroText(A31EUIText[i], Neuro.GetA31E());
        }

        for (int i = 0; i < A31FUIText.Length; i++)
        {
            SetRegistroText(A31FUIText[i], Neuro.GetA31F());
        }

        for (int i = 0; i < A31IUIText.Length; i++)
        {
            SetRegistroText(A31IUIText[i], Neuro.GetA31I());
        }

        for (int i = 0; i < A31LUIText.Length; i++)
        {
            SetRegistroText(A31LUIText[i], Neuro.GetA31L());
        }

        for (int i = 0; i < A31MUIText.Length; i++)
        {
            SetRegistroText(A31MUIText[i], Neuro.GetA31M());
        }

        for (int i = 0; i < A31NUIText.Length; i++)
        {
            SetRegistroText(A31NUIText[i], Neuro.GetA31N());
        }

        for (int i = 0; i < A31OUIText.Length; i++)
        {
            SetRegistroText(A31OUIText[i], Neuro.GetA31O());
        }

        for (int i = 0; i < A31PUIText.Length; i++)
        {
            SetRegistroText(A31PUIText[i], Neuro.GetA31P());
        }

        for (int i = 0; i < A31RUIText.Length; i++)
        {
            SetRegistroText(A31RUIText[i], Neuro.GetA31R());
        }

        for (int i = 0; i < A31SUIText.Length; i++)
        {
            SetRegistroText(A31SUIText[i], Neuro.GetA31S());
        }

        for (int i = 0; i < A31TUIText.Length; i++)
        {
            SetRegistroText(A31TUIText[i], Neuro.GetA31T());
        }

        for (int i = 0; i < A31UUIText.Length; i++)
        {
            SetRegistroText(A31UUIText[i], Neuro.GetA31U());
        }

        for (int i = 0; i < A31ASUIText.Length; i++)
        {
            SetRegistroText(A31ASUIText[i], Neuro.GetA31AS());
        }

        for (int i = 0; i < A31DSUIText.Length; i++)
        {
            SetRegistroText(A31DSUIText[i], Neuro.GetA31DS());
        }

        for (int i = 0; i < A31ESUIText.Length; i++)
        {
            SetRegistroText(A31ESUIText[i], Neuro.GetA31ES());
        }

        for (int i = 0; i < A31FSUIText.Length; i++)
        {
            SetRegistroText(A31FSUIText[i], Neuro.GetA31FS());
        }

        for (int i = 0; i < A31ISUIText.Length; i++)
        {
            SetRegistroText(A31ISUIText[i], Neuro.GetA31IS());
        }

        for (int i = 0; i < A31LSUIText.Length; i++)
        {
            SetRegistroText(A31LSUIText[i], Neuro.GetA31LS());
        }

        for (int i = 0; i < A31MSUIText.Length; i++)
        {
            SetRegistroText(A31MSUIText[i], Neuro.GetA31MS());
        }

        for (int i = 0; i < A31NSUIText.Length; i++)
        {
            SetRegistroText(A31NSUIText[i], Neuro.GetA31NS());
        }

        for (int i = 0; i < A31OSUIText.Length; i++)
        {
            SetRegistroText(A31OSUIText[i], Neuro.GetA31OS());
        }

        for (int i = 0; i < A31PSUIText.Length; i++)
        {
            SetRegistroText(A31PSUIText[i], Neuro.GetA31PS());
        }

        for (int i = 0; i < A31RSUIText.Length; i++)
        {
            SetRegistroText(A31RSUIText[i], Neuro.GetA31RS());
        }

        for (int i = 0; i < A31SSUIText.Length; i++)
        {
            SetRegistroText(A31SSUIText[i], Neuro.GetA31SS());
        }

        for (int i = 0; i < A31TSUIText.Length; i++)
        {
            SetRegistroText(A31TSUIText[i], Neuro.GetA31TS());
        }

        for (int i = 0; i < A31USUIText.Length; i++)
        {
            SetRegistroText(A31USUIText[i], Neuro.GetA31US());
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
