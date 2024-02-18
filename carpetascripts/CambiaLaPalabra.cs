using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CambiaLaPalabra : MonoBehaviour
{
    public CE1 ra1;
    public CE2 pe2;
    public LO1 lo1;
    public LO2 ta2;
    public LU1 lu1;
    public LU2 lu2;
    public MA1 ma1;
    public MA2 ma2;
    public GO2 go2;
    private bool logrado;
    private bool pecea;
    private bool ceraa;
    private bool peloa;
    private bool lotaa;
    private bool loboa;
    private bool pelua;
    private bool lucaa;
    private bool lunaa;
    private bool camaa;
    private bool maraa;
    private bool gotaa;
    private bool pecera;
    private bool pelota;
    private bool peluca;
    private bool camara;
    private bool cama;
    private bool gota;
    private bool lobo;
    private bool luna;
    public GameObject cuadroLograrActividad;
    public Text peceraTexto;
    public Text pelotaTexto;
    public Text pelucaTexto;
    public Text camaraTexto;
    public Text camaTexto;
    public Text gotaTexto;
    public Text loboTexto;
    public Text lunaTexto;

    // Start is called before the first frame update
    void Start()
    {
        cuadroLograrActividad.gameObject.SetActive(false);
        CE1 variable = GetComponent<CE1>();
        CE2 variable2 = GetComponent<CE2>();
        LO1 variable3 = GetComponent<LO1>();
        LO2 variable4 = GetComponent<LO2>();
        LO2 variable4_2 = GetComponent<LO2>();
        LU1 variable5 = GetComponent<LU1>();
        LU2 variable6 = GetComponent<LU2>();
        LU2 variable6_2 = GetComponent<LU2>();
        MA1 variable7 = GetComponent<MA1>();
        MA2 variable8 = GetComponent<MA2>();
        GO2 variable9 = GetComponent<GO2>();

        
        
    }

    // Update is called once per frame
    void Update()
    {
        
        pecea = CE1.pece;
        ceraa = CE2.cera;
        peloa = LO1.pelo;
        lotaa = LO2.lota;
        loboa = LO2.lobo;
        pelua = LU1.pelu;
        lucaa = LU2.luca;
        lunaa = LU2.luna;
        camaa = MA1.cama;
        maraa = MA2.mara;
        gotaa = GO2.gota;
        
        
        


        if(pecea && ceraa == true)
        {
            pecera = true;
            peceraTexto.text = "Pecera";
        }

        if(peloa && lotaa == true)
        {
            pelota = true;
            pelotaTexto.text = "Pelota";
        }

        if(loboa == true)
        {
            lobo = true;
            loboTexto.text = "Lobo";
        }

        if(pelua && lucaa == true)
        {
            peluca = true;
            pelucaTexto.text = "Peluca";
        }

        if(lunaa == true)
        {
            luna = true;
            lunaTexto.text = "Luna";
        }

        if(camaa == true)
        {
            cama = true;
            camaTexto.text = "Cama";
        }

        if(camaa && maraa == true)
        {
            camara = true;
            camaraTexto.text = "Camara";
        }

        if(gotaa == true)
        {
            gota = true;
            gotaTexto.text = "Gota";
        }

        if(pecera && pelota && peluca && cama && camara && gota && lobo && luna == true)
        {
            {Invoke ("Continuar2", 0.8f); }
        }


        
    }

    void Continuar2()
    { 
        cuadroLograrActividad.gameObject.SetActive(true);
    }

   
}
