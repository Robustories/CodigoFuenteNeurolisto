using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Niveles2_5 : MonoBehaviour
{
    public static Niveles2_5 niveles2_5;
    public Button DA;
    public Button DE;
    public Button DI;
    public Button DO;
    public Button DU;
    public Button LA;
    public Button LE;
    public Button LO;
    public Button LU;
    public Button MA;
    public Button ME;
    public Button MI;
    public Button MO;
    public Button MU;
    public Button NA;
    public Button NE;
    public Button NI;
    public Button NO;
    public Button NU;
    public Button PA;
    public Button PE;
    public Button PI;
    public Button PO;
    public Button PU;
    public Button SA;
    public Button SE;
    public Button SI;
    public Button SO;
    public Button SU;
    private int marcadorDA;
    private int marcadorDE;
    private int marcadorDI;
    private int marcadorDO;
    private int marcadorDU;
    private int marcadorLA;
    private int marcadorLE;
    private int marcadorLI;
    private int marcadorLO;
    private int marcadorLU;
    private int marcadorMA;
    private int marcadorME;
    private int marcadorMI;
    private int marcadorMO;
    private int marcadorMU;
    private int marcadorNA;
    private int marcadorNE;
    private int marcadorNI;
    private int marcadorNO;
    private int marcadorNU;
    private int marcadorPA;
    private int marcadorPE;
    private int marcadorPI;
    private int marcadorPO;
    private int marcadorPU;
    private int marcadorSA;
    private int marcadorSE;
    private int marcadorSI;
    private int marcadorSO;
    private int marcadorSU;
    private int marcador0;
    public GameObject n1;

    void Awake()
    {
        niveles2_5 = this;
        DA.interactable = false;
        DE.interactable = false;
        DI.interactable = false;
        DO.interactable = false;
        DU.interactable = false;
        LA.interactable = false;
        LE.interactable = false;
        LO.interactable = false;
        LU.interactable = false;
        MA.interactable = false;
        ME.interactable = false;
        MI.interactable = false;
        MO.interactable = false;
        MU.interactable = false;
        NA.interactable = false;
        NE.interactable = false;
        NI.interactable = false;
        NO.interactable = false;
        NU.interactable = false;
        PA.interactable = false;
        PE.interactable = false;
        PI.interactable = false;
        PO.interactable = false;
        PU.interactable = false;
        SA.interactable = false;
        SE.interactable = false;
        SI.interactable = false;
        SO.interactable = false;
        SU.interactable = false;

    }

    // Start is called before the first frame update
    void Start()
    {
        GetValor2_5();
        Desbloquear2_5();
        EvitarAudio();
        
    }

    void GetValor2_5()
    {
        marcador0 = Neuro.GetA25DA();
        marcadorDA = Neuro.GetA25DA();
        marcadorDE = Neuro.GetA25DE();
        marcadorDI = Neuro.GetA25DI();
        marcadorDO = Neuro.GetA25DO();
        marcadorDU = Neuro.GetA25DU();
        marcadorLA = Neuro.GetA25LA();
        marcadorLE = Neuro.GetA25LE();
        marcadorLI = Neuro.GetA25LI();
        marcadorLO = Neuro.GetA25LO();
        marcadorLU = Neuro.GetA25LU();
        marcadorMA = Neuro.GetA25MA();
        marcadorME = Neuro.GetA25ME();
        marcadorMI = Neuro.GetA25MI();
        marcadorMO = Neuro.GetA25MO();
        marcadorMU = Neuro.GetA25MU();
        marcadorNA = Neuro.GetA25NA();
        marcadorNE = Neuro.GetA25NE();
        marcadorNI = Neuro.GetA25NI();
        marcadorNO = Neuro.GetA25NO();
        marcadorNU = Neuro.GetA25NU();
        marcadorPA = Neuro.GetA25PA();
        marcadorPE = Neuro.GetA25PE();
        marcadorPI = Neuro.GetA25PI();
        marcadorPO = Neuro.GetA25PO();
        marcadorPU = Neuro.GetA25PU();
        marcadorSA = Neuro.GetA25SA();
        marcadorSE = Neuro.GetA25SE();
        marcadorSI = Neuro.GetA25SI();
        marcadorSO = Neuro.GetA25SO();
        marcadorSU = Neuro.GetA25SU();
        

    }

    void Desbloquear2_5()
    {
        if (marcadorDA >= 1)
        {
            MA.interactable = true;

        }

        if (marcadorDE >= 1)
        {
            MU.interactable = true;

        }

        if (marcadorDI >= 1)
        {
            NE.interactable = true;

        }

        if (marcadorDO >= 1)
        {
            NA.interactable = true;

        }

        if (marcadorDU >= 1)
        {
            SI.interactable = true;

        }

        if (marcadorLA >= 1)
        {
            DI.interactable = true;

        }

        if (marcadorLE >= 1)
        {
            DA.interactable = true;

        }

        if (marcadorLI >= 1)
        {
            MO.interactable = true;

        }

        if (marcadorLO >= 1)
        {
            NU.interactable = true;

        }

        if (marcadorLU >= 1)
        {
            NO.interactable = true;

        }

        if (marcadorMA >= 1)
        {
            PE.interactable = true;

        }

        if (marcadorME >= 1)
        {
            DO.interactable = true;

        }

        if (marcadorMI >= 1)
        {
            LA.interactable = true;

        }

        if (marcadorMO >= 1)
        {
            DE.interactable = true;

        }

        if (marcadorMU >= 1)
        {
            SA.interactable = true;

        }

        if (marcadorNA >= 1)
        {
            PU.interactable = true;

        }

        if (marcadorNE >= 1)
        {
            PO.interactable = true;

        }

        if (marcadorNI >= 1)
        {
            LO.interactable = true;

        }

        if (marcadorNU >= 1)
        {
            LU.interactable = true;

        }

        if (marcadorPA >= 1)
        {
            SU.interactable = true;

        }

        if (marcadorPE >= 1)
        {
            DU.interactable = true;

        }

        if (marcadorPI >= 1)
        {
            ME.interactable = true;

        }

        if (marcadorPO >= 1)
        {
            LE.interactable = true;

        }

        if (marcadorPU >= 1)
        {
            MI.interactable = true;

        }

        if (marcadorSA >= 1)
        {
            SO.interactable = true;

        }

        if (marcadorSE >= 1)
        {
            PI.interactable = true;

        }

        if (marcadorSI >= 1)
        {
            NI.interactable = true;

        }

        if (marcadorSO >= 1)
        {
            PA.interactable = true;

        }

        if (marcadorSU >= 1)
        {
            SE.interactable = true;

        }


        

    }

    void EvitarAudio()
    {
        if (marcador0 >= 1)
        {
            n1.gameObject.SetActive(false);

        }

    }
}
