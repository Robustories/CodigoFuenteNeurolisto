using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class A_2_5UI : MonoBehaviour
{
    #region Singleton class: Registro

    public static A_2_5UI Instance;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    #endregion

    [SerializeField] TMP_Text[] A25DAUIText;
    [SerializeField] TMP_Text[] A25DEUIText;
    [SerializeField] TMP_Text[] A25DIUIText;
    [SerializeField] TMP_Text[] A25DOUIText;
    [SerializeField] TMP_Text[] A25DUUIText;
    [SerializeField] TMP_Text[] A25LAUIText;
    [SerializeField] TMP_Text[] A25LEUIText;
    [SerializeField] TMP_Text[] A25LIUIText;
    [SerializeField] TMP_Text[] A25LOUIText;
    [SerializeField] TMP_Text[] A25LUUIText;
    [SerializeField] TMP_Text[] A25MAUIText;
    [SerializeField] TMP_Text[] A25MEUIText;
    [SerializeField] TMP_Text[] A25MIUIText;
    [SerializeField] TMP_Text[] A25MOUIText;
    [SerializeField] TMP_Text[] A25MUUIText;
    [SerializeField] TMP_Text[] A25NAUIText;
    [SerializeField] TMP_Text[] A25NEUIText;
    [SerializeField] TMP_Text[] A25NIUIText;
    [SerializeField] TMP_Text[] A25NOUIText;
    [SerializeField] TMP_Text[] A25NUUIText;
    [SerializeField] TMP_Text[] A25PAUIText;
    [SerializeField] TMP_Text[] A25PEUIText;
    [SerializeField] TMP_Text[] A25PIUIText;
    [SerializeField] TMP_Text[] A25POUIText;
    [SerializeField] TMP_Text[] A25PUUIText;
    [SerializeField] TMP_Text[] A25SAUIText;
    [SerializeField] TMP_Text[] A25SEUIText;
    [SerializeField] TMP_Text[] A25SIUIText;
    [SerializeField] TMP_Text[] A25SOUIText;
    [SerializeField] TMP_Text[] A25SUUIText;
    [SerializeField] TMP_Text[] A25DASUIText;
    [SerializeField] TMP_Text[] A25DESUIText;
    [SerializeField] TMP_Text[] A25DISUIText;
    [SerializeField] TMP_Text[] A25DOSUIText;
    [SerializeField] TMP_Text[] A25DUSUIText;
    [SerializeField] TMP_Text[] A25LASUIText;
    [SerializeField] TMP_Text[] A25LESUIText;
    [SerializeField] TMP_Text[] A25LISUIText;
    [SerializeField] TMP_Text[] A25LOSUIText;
    [SerializeField] TMP_Text[] A25LUSUIText;
    [SerializeField] TMP_Text[] A25MASUIText;
    [SerializeField] TMP_Text[] A25MESUIText;
    [SerializeField] TMP_Text[] A25MISUIText;
    [SerializeField] TMP_Text[] A25MOSUIText;
    [SerializeField] TMP_Text[] A25MUSUIText;
    [SerializeField] TMP_Text[] A25NASUIText;
    [SerializeField] TMP_Text[] A25NESUIText;
    [SerializeField] TMP_Text[] A25NISUIText;
    [SerializeField] TMP_Text[] A25NOSUIText;
    [SerializeField] TMP_Text[] A25NUSUIText;
    [SerializeField] TMP_Text[] A25PASUIText;
    [SerializeField] TMP_Text[] A25PESUIText;
    [SerializeField] TMP_Text[] A25PISUIText;
    [SerializeField] TMP_Text[] A25POSUIText;
    [SerializeField] TMP_Text[] A25PUSUIText;
    [SerializeField] TMP_Text[] A25SASUIText;
    [SerializeField] TMP_Text[] A25SESUIText;
    [SerializeField] TMP_Text[] A25SISUIText;
    [SerializeField] TMP_Text[] A25SOSUIText;
    [SerializeField] TMP_Text[] A25SUSUIText;


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
        for (int i = 0; i < A25DASUIText.Length; i++)
        {
            SetRegistroText(A25DASUIText[i], Neuro.GetA25DAS());
        }

        for (int i = 0; i < A25DESUIText.Length; i++)
        {
            SetRegistroText(A25DESUIText[i], Neuro.GetA25DES());
        }

        for (int i = 0; i < A25DISUIText.Length; i++)
        {
            SetRegistroText(A25DISUIText[i], Neuro.GetA25DIS());
        }

        for (int i = 0; i < A25DOSUIText.Length; i++)
        {
            SetRegistroText(A25DOSUIText[i], Neuro.GetA25DOS());
        }

        for (int i = 0; i < A25DUSUIText.Length; i++)
        {
            SetRegistroText(A25DUSUIText[i], Neuro.GetA25DUS());
        }

        for (int i = 0; i < A25LASUIText.Length; i++)
        {
            SetRegistroText(A25LASUIText[i], Neuro.GetA25LAS());
        }

        for (int i = 0; i < A25LESUIText.Length; i++)
        {
            SetRegistroText(A25LESUIText[i], Neuro.GetA25LES());
        }

        for (int i = 0; i < A25LISUIText.Length; i++)
        {
            SetRegistroText(A25LISUIText[i], Neuro.GetA25LIS());
        }

        for (int i = 0; i < A25LOSUIText.Length; i++)
        {
            SetRegistroText(A25LOSUIText[i], Neuro.GetA25LOS());
        }

        for (int i = 0; i < A25LUSUIText.Length; i++)
        {
            SetRegistroText(A25LUSUIText[i], Neuro.GetA25LUS());
        }

        for (int i = 0; i < A25MASUIText.Length; i++)
        {
            SetRegistroText(A25MASUIText[i], Neuro.GetA25MAS());
        }

        for (int i = 0; i < A25MESUIText.Length; i++)
        {
            SetRegistroText(A25MESUIText[i], Neuro.GetA25MES());
        }

        for (int i = 0; i < A25MISUIText.Length; i++)
        {
            SetRegistroText(A25MISUIText[i], Neuro.GetA25MIS());
        }

        for (int i = 0; i < A25MOSUIText.Length; i++)
        {
            SetRegistroText(A25MOSUIText[i], Neuro.GetA25MOS());
        }

        for (int i = 0; i < A25MUSUIText.Length; i++)
        {
            SetRegistroText(A25MUSUIText[i], Neuro.GetA25MUS());
        }

        for (int i = 0; i < A25NASUIText.Length; i++)
        {
            SetRegistroText(A25NASUIText[i], Neuro.GetA25NAS());
        }

        for (int i = 0; i < A25NESUIText.Length; i++)
        {
            SetRegistroText(A25NESUIText[i], Neuro.GetA25NES());
        }

        for (int i = 0; i < A25NISUIText.Length; i++)
        {
            SetRegistroText(A25NISUIText[i], Neuro.GetA25NIS());
        }

        for (int i = 0; i < A25NOSUIText.Length; i++)
        {
            SetRegistroText(A25NOSUIText[i], Neuro.GetA25NOS());
        }

        for (int i = 0; i < A25NUSUIText.Length; i++)
        {
            SetRegistroText(A25NUSUIText[i], Neuro.GetA25NUS());
        }

        for (int i = 0; i < A25PASUIText.Length; i++)
        {
            SetRegistroText(A25PASUIText[i], Neuro.GetA25PAS());
        }

        for (int i = 0; i < A25PESUIText.Length; i++)
        {
            SetRegistroText(A25PESUIText[i], Neuro.GetA25PES());
        }

        for (int i = 0; i < A25PISUIText.Length; i++)
        {
            SetRegistroText(A25PISUIText[i], Neuro.GetA25PIS());
        }

        for (int i = 0; i < A25POSUIText.Length; i++)
        {
            SetRegistroText(A25POSUIText[i], Neuro.GetA25POS());
        }

        for (int i = 0; i < A25PUSUIText.Length; i++)
        {
            SetRegistroText(A25PUSUIText[i], Neuro.GetA25PUS());
        }

        for (int i = 0; i < A25SASUIText.Length; i++)
        {
            SetRegistroText(A25SASUIText[i], Neuro.GetA25SAS());
        }

        for (int i = 0; i < A25SESUIText.Length; i++)
        {
            SetRegistroText(A25SESUIText[i], Neuro.GetA25SES());
        }

        for (int i = 0; i < A25SISUIText.Length; i++)
        {
            SetRegistroText(A25SISUIText[i], Neuro.GetA25SIS());
        }

        for (int i = 0; i < A25SOSUIText.Length; i++)
        {
            SetRegistroText(A25SOSUIText[i], Neuro.GetA25SOS());
        }

        for (int i = 0; i < A25SUSUIText.Length; i++)
        {
            SetRegistroText(A25SUSUIText[i], Neuro.GetA25SUS());
        }

        for (int i = 0; i < A25DAUIText.Length; i++)
        {
            SetRegistroText(A25DAUIText[i], Neuro.GetA25DA());
        }

        for (int i = 0; i < A25DEUIText.Length; i++)
        {
            SetRegistroText(A25DEUIText[i], Neuro.GetA25DE());
        }

        for (int i = 0; i < A25DIUIText.Length; i++)
        {
            SetRegistroText(A25DIUIText[i], Neuro.GetA25DI());
        }

        for (int i = 0; i < A25DOUIText.Length; i++)
        {
            SetRegistroText(A25DOUIText[i], Neuro.GetA25DO());
        }

        for (int i = 0; i < A25DUUIText.Length; i++)
        {
            SetRegistroText(A25DUUIText[i], Neuro.GetA25DU());
        }

        for (int i = 0; i < A25LAUIText.Length; i++)
        {
            SetRegistroText(A25LAUIText[i], Neuro.GetA25LA());
        }

        for (int i = 0; i < A25LEUIText.Length; i++)
        {
            SetRegistroText(A25LEUIText[i], Neuro.GetA25LE());
        }

        for (int i = 0; i < A25LIUIText.Length; i++)
        {
            SetRegistroText(A25LIUIText[i], Neuro.GetA25LI());
        }

        for (int i = 0; i < A25LOUIText.Length; i++)
        {
            SetRegistroText(A25LOUIText[i], Neuro.GetA25LO());
        }

        for (int i = 0; i < A25LUUIText.Length; i++)
        {
            SetRegistroText(A25LUUIText[i], Neuro.GetA25LU());
        }

        for (int i = 0; i < A25MAUIText.Length; i++)
        {
            SetRegistroText(A25MAUIText[i], Neuro.GetA25MA());
        }

        for (int i = 0; i < A25MEUIText.Length; i++)
        {
            SetRegistroText(A25MEUIText[i], Neuro.GetA25ME());
        }

        for (int i = 0; i < A25MIUIText.Length; i++)
        {
            SetRegistroText(A25MIUIText[i], Neuro.GetA25MI());
        }

        for (int i = 0; i < A25MOUIText.Length; i++)
        {
            SetRegistroText(A25MOUIText[i], Neuro.GetA25MO());
        }

        for (int i = 0; i < A25MUUIText.Length; i++)
        {
            SetRegistroText(A25MUUIText[i], Neuro.GetA25MU());
        }

        for (int i = 0; i < A25NAUIText.Length; i++)
        {
            SetRegistroText(A25NAUIText[i], Neuro.GetA25NA());
        }

        for (int i = 0; i < A25NEUIText.Length; i++)
        {
            SetRegistroText(A25NEUIText[i], Neuro.GetA25NE());
        }

        for (int i = 0; i < A25NIUIText.Length; i++)
        {
            SetRegistroText(A25NIUIText[i], Neuro.GetA25NI());
        }

        for (int i = 0; i < A25NOUIText.Length; i++)
        {
            SetRegistroText(A25NOUIText[i], Neuro.GetA25NO());
        }

        for (int i = 0; i < A25NUUIText.Length; i++)
        {
            SetRegistroText(A25NUUIText[i], Neuro.GetA25NU());
        }

        for (int i = 0; i < A25PAUIText.Length; i++)
        {
            SetRegistroText(A25PAUIText[i], Neuro.GetA25PA());
        }

        for (int i = 0; i < A25PEUIText.Length; i++)
        {
            SetRegistroText(A25PEUIText[i], Neuro.GetA25PE());
        }

        for (int i = 0; i < A25PIUIText.Length; i++)
        {
            SetRegistroText(A25PIUIText[i], Neuro.GetA25PI());
        }

        for (int i = 0; i < A25POUIText.Length; i++)
        {
            SetRegistroText(A25POUIText[i], Neuro.GetA25PO());
        }

        for (int i = 0; i < A25PUUIText.Length; i++)
        {
            SetRegistroText(A25PUUIText[i], Neuro.GetA25PU());
        }

        for (int i = 0; i < A25SAUIText.Length; i++)
        {
            SetRegistroText(A25SAUIText[i], Neuro.GetA25SA());
        }

        for (int i = 0; i < A25SEUIText.Length; i++)
        {
            SetRegistroText(A25SEUIText[i], Neuro.GetA25SE());
        }

        for (int i = 0; i < A25SIUIText.Length; i++)
        {
            SetRegistroText(A25SIUIText[i], Neuro.GetA25SI());
        }

        for (int i = 0; i < A25SOUIText.Length; i++)
        {
            SetRegistroText(A25SOUIText[i], Neuro.GetA25SO());
        }

        for (int i = 0; i < A25SUUIText.Length; i++)
        {
            SetRegistroText(A25SUUIText[i], Neuro.GetA25SU());
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
