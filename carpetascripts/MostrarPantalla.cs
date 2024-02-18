using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MostrarPantalla : MonoBehaviour
{
    public GameObject pantallaMostrable;
    Linea referencia;
    MoverObjetoConLinea mocl;
    public GameObject Buscalineas;
    //public GameObject BuscaPlayer;
    public bool contacto;
    
    void Start()
    {
        pantallaMostrable.gameObject.SetActive(false);
        MoverObjetoConLinea variable2 = GetComponent<MoverObjetoConLinea>();
        
    }

    void Update()
    {
        Buscalineas = GameObject.FindGameObjectWithTag("Linea");
        Linea variable = GetComponent<Linea>();
        //BuscaPlayer = GameObject.FindGameObjectWithTag("LineController");
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        pantallaMostrable.gameObject.SetActive(true);
        //BuscaPlayer.transform.position = new Vector3(0,0,0);
        contacto = true;
        //DesactivarCollider();
        
    }

    void DesactivarCollider()
    {
        GetComponent<BoxCollider2D>().enabled = false;
        Destroy(GetComponent<BoxCollider2D>());
    }
}
