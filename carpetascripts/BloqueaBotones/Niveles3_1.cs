using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Niveles3_1 : MonoBehaviour
{
    public static Niveles3_1 niveles3_1;
    public Button E;
    public Button I;
    public Button O;
    public Button U;
    public Button D;
    public Button L;
    public Button M;
    public Button N;
    public Button P;
    public Button S;
    public Button F;
    public Button R;
    public Button T;
    private int marcadorA;
    private int marcadorE;
    private int marcadorI;
    private int marcadorO;
    private int marcadorU;
    private int marcadorD;
    private int marcadorL;
    private int marcadorM;
    private int marcadorN;
    private int marcadorP;
    private int marcadorS;
    private int marcadorF;
    private int marcadorR;
    private int marcadorT;
    private int marcador0;
    public GameObject n1;
    // Start is called before the first frame update
    void Awake()
    {
        niveles3_1 = this;
        E.interactable = false;
        I.interactable = false;
        O.interactable = false;
        U.interactable = false;
        D.interactable = false;
        L.interactable = false;
        M.interactable = false;
        N.interactable = false;       
        P.interactable = false;
        S.interactable = false;
        F.interactable = false;       
        R.interactable = false;
        T.interactable = false;
        

    }
    void Start()
    {
        GetValor3_1();
        Desbloquear3_1();
        EvitarAudio();
        
    }

    void GetValor3_1()
    {
        marcador0 = Neuro.GetA31A();
        marcadorA = Neuro.GetA31AS();
        marcadorE = Neuro.GetA31ES();
        marcadorI = Neuro.GetA31IS();
        marcadorO = Neuro.GetA31OS();
        marcadorU = Neuro.GetA31US();
        marcadorD = Neuro.GetA31DS();
        marcadorL = Neuro.GetA31LS();
        marcadorM = Neuro.GetA31MS();
        marcadorN = Neuro.GetA31NS();
        marcadorP = Neuro.GetA31PS();
        marcadorS = Neuro.GetA31SS();
        marcadorF = Neuro.GetA31FS();
        marcadorR = Neuro.GetA31RS();
        marcadorT = Neuro.GetA31TS();
        
        

    }

    void Desbloquear3_1()
    {
        if (marcadorA >= 1)
        {
            E.interactable = true;

        }

        if (marcadorE >= 1)
        {
            I.interactable = true;

        }

        if (marcadorI >= 1)
        {
            O.interactable = true;

        }

        if (marcadorO >= 1)
        {
            U.interactable = true;

        }

        if (marcadorU >= 1)
        {
            L.interactable = true;

        }

        if (marcadorL >= 1)
        {
            M.interactable = true;

        }

        if (marcadorM >= 1)
        {
            S.interactable = true;

        }

        if (marcadorS >= 1)
        {
            P.interactable = true;

        }

        if (marcadorP >= 1)
        {
            D.interactable = true;

        }

        if (marcadorD >= 1)
        {
            N.interactable = true;

        }

        if (marcadorN >= 1)
        {
            F.interactable = true;

        }

        if (marcadorF >= 1)
        {
            T.interactable = true;

        }

        if (marcadorT >= 1)
        {
            R.interactable = true;

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
