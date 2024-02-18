using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuntajeRetro: MonoBehaviour
{
    public GameObject AB1, AB2, AB3, AB4, AB5, AB6;
    Vector2 AB1InitialPos, AB2InitialPos, AB3InitialPos, AB4InitialPos, AB5InitialPos, AB6InitialPos;
    public TestBox2 testbox2;
    public TestBox2 testbox2_1;
    public TestBox2 testbox2_2;
    public TestBox2 testbox2_3;
    public TestBox2 testbox2_4;
    public TestBox2 testbox2_5;
    
    public int puntosVictoria;
    public GameObject cVictoria;
    public int puntajeAcumulado;
    public int prueba;
    public Text texts;
    public Text texts2;
    

    // Start is called before the first frame update
    void Start()
    {
        TestBox2[] yourObjects = FindObjectsOfType<TestBox2>();
        cVictoria.gameObject.SetActive(false);
        AB1InitialPos = AB1.transform.position;
        AB2InitialPos = AB2.transform.position;
        AB3InitialPos = AB3.transform.position;
        AB4InitialPos = AB4.transform.position;
        AB5InitialPos = AB5.transform.position;
        AB6InitialPos = AB6.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        TestBox2 variable = GetComponent<TestBox2>();
        puntajeAcumulado = testbox2.puntos + testbox2_1.puntos + testbox2_2.puntos + testbox2_3.puntos + testbox2_4.puntos + testbox2_5.puntos;
        prueba = testbox2.ocupantes + testbox2_1.ocupantes + testbox2_2.ocupantes + testbox2_3.ocupantes + testbox2_4.ocupantes + testbox2_5.ocupantes;

         if(texts != null)
        {
            texts.text = puntajeAcumulado.ToString();
            texts2.text = prueba.ToString();
        }

        if(puntajeAcumulado == puntosVictoria)
        {
            {Invoke ("Victoria", 0.1f);}
            AB1.transform.position = AB1InitialPos;
            AB2.transform.position = AB2InitialPos;
            AB3.transform.position = AB3InitialPos;
            AB4.transform.position = AB4InitialPos;
            AB5.transform.position = AB5InitialPos;
            AB6.transform.position = AB6InitialPos;

        }

        
    }

    void Victoria()
    { 
        cVictoria.SetActive(true);
    }
}
