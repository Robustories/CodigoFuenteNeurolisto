using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuntosLetra : MonoBehaviour
{
    public int puntos;
    public int puntospasar;
    public GameObject pantallaSuperar;
    public Comer a1;
    public Comer2 a2;
    private int puntos1;
    private int puntos2;
    // Start is called before the first frame update
    void Start()
    {
        pantallaSuperar.gameObject.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        Comer variable = GetComponent<Comer>();
        Comer2 variable2 = GetComponent<Comer2>();
        puntos1 = Comer.Score;
        puntos2 = Comer2.Score2;

        puntos = puntos1 + puntos2;


        if(puntos >= puntospasar)
        {
            pantallaSuperar.gameObject.SetActive(true);

        }
        
        
    }
}
