using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiempoDeAparicion : MonoBehaviour
{
    public int tiempoAparicion;
    public int tiempoAparicion2;
    public int tiempoAparicion3;
    public int tiempoAparicion4;
    public int tiempoAparicion5;
    public int tiempoAparicion6;
    public int tiempoAparicion7;
    public int tiempoAparicion8;
    public int tiempoAparicion9;
    public int tiempoAparicion10;
    public int tiempoAparicion11;
    public int tiempoAparicion12;
    public int tiempoAparicion13;
    public int tiempoAparicion14;
    public int tiempoAparicion15;
    public int tiempoAparicion16;
    public int tiempoAparicion17;
    public int tiempoAparicion18;
    public GameObject objetoEjercicio;
    public GameObject objetoEjercicio2;
    public GameObject objetoEjercicio3;
    public GameObject objetoEjercicio4;
    public GameObject objetoEjercicio5;
    public GameObject objetoEjercicio6;
    public GameObject objetoEjercicio7;
    public GameObject objetoEjercicio8;
    public GameObject objetoEjercicio9;
    public GameObject objetoEjercicio10;
    public GameObject objetoEjercicio11;
    public GameObject objetoEjercicio12;
    public GameObject objetoEjercicio13;
    public GameObject objetoEjercicio14;
    public GameObject objetoEjercicio15;
    public GameObject objetoEjercicio16;
    public GameObject objetoEjercicio17;
    public GameObject objetoEjercicio18;
    private GameObject createdObjec;
    private GameObject createdObjec2;
    private GameObject createdObjec3;
    private GameObject createdObjec4;
    private GameObject createdObjec5;
    private GameObject createdObjec6;
    private GameObject createdObjec7;
    private GameObject createdObjec8;
    private GameObject createdObjec9;
    private GameObject createdObjec10;
    private GameObject createdObjec11;
    private GameObject createdObjec12;
    private GameObject createdObjec13;
    private GameObject createdObjec14;
    private GameObject createdObjec15;
    private GameObject createdObjec16;
    private GameObject createdObjec17;
    private GameObject createdObjec18;
    // Start is called before the first frame update
    void Start()
    {
        //gameObject.SetActive(false);
        //Invoke("DestruirObjeto", tiempoAparicion);
        Invoke("Aparecer", tiempoAparicion);
        Invoke("Aparecer2", tiempoAparicion2);
        Invoke("Aparecer3", tiempoAparicion3);
        Invoke("Aparecer4", tiempoAparicion4);
        Invoke("Aparecer5", tiempoAparicion5);
        Invoke("Aparecer6", tiempoAparicion6);
        Invoke("Aparecer7", tiempoAparicion7);
        Invoke("Aparecer8", tiempoAparicion8);
        Invoke("Aparecer9", tiempoAparicion9);
        Invoke("Aparecer10", tiempoAparicion10);
        Invoke("Aparecer11", tiempoAparicion11);
        Invoke("Aparecer12", tiempoAparicion12);
        Invoke("Aparecer13", tiempoAparicion13);
        Invoke("Aparecer14", tiempoAparicion14);
        Invoke("Aparecer15", tiempoAparicion15);
        Invoke("Aparecer16", tiempoAparicion16);
        Invoke("Aparecer17", tiempoAparicion17);
        Invoke("Aparecer18", tiempoAparicion18);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Aparecer()
    {
        //gameObject.SetActive(true);
        Vector3 position = new Vector3(-4,2,0);
        createdObjec = Instantiate(objetoEjercicio, position, Quaternion.identity);
    }

    void Aparecer2()
    {
        //gameObject.SetActive(true);
        Vector3 position = new Vector3(-2,2,0);
        createdObjec2 = Instantiate(objetoEjercicio2, position, Quaternion.identity);
    }

    void Aparecer3()
    {
        //gameObject.SetActive(true);
        Vector3 position = new Vector3(-4,0,0);
        createdObjec3 = Instantiate(objetoEjercicio3, position, Quaternion.identity);
    }

    void Aparecer4()
    {
        //gameObject.SetActive(true);
        Vector3 position = new Vector3(-2,0,0);
        createdObjec4 = Instantiate(objetoEjercicio4, position, Quaternion.identity);
    }

    void Aparecer5()
    {
        //gameObject.SetActive(true);
        Vector3 position = new Vector3(-4,-2,0);
        createdObjec5 = Instantiate(objetoEjercicio5, position, Quaternion.identity);
    }

    void Aparecer6()
    {
        //gameObject.SetActive(true);
        Vector3 position = new Vector3(-2,-2,0);
        createdObjec6 = Instantiate(objetoEjercicio6, position, Quaternion.identity);
    }

    void Aparecer7()
    {
        //gameObject.SetActive(true);
        Vector3 position = new Vector3(2,2,0);
        createdObjec7 = Instantiate(objetoEjercicio7, position, Quaternion.identity);
    }

    void Aparecer8()
    {
        //gameObject.SetActive(true);
        Vector3 position = new Vector3(4,2,0);
        createdObjec8 = Instantiate(objetoEjercicio8, position, Quaternion.identity);
    }

    void Aparecer9()
    {
        //gameObject.SetActive(true);
        Vector3 position = new Vector3(2,0,0);
        createdObjec9 = Instantiate(objetoEjercicio9, position, Quaternion.identity);
    }

    void Aparecer10()
    {
        //gameObject.SetActive(true);
        Vector3 position = new Vector3(4,0,0);
        createdObjec10 = Instantiate(objetoEjercicio10, position, Quaternion.identity);
    }

    void Aparecer11()
    {
        //gameObject.SetActive(true);
        Vector3 position = new Vector3(2,-2,0);
        createdObjec11 = Instantiate(objetoEjercicio11, position, Quaternion.identity);
    }

    void Aparecer12()
    {
        //gameObject.SetActive(true);
        Vector3 position = new Vector3(4,-2,0);
        createdObjec12 = Instantiate(objetoEjercicio12, position, Quaternion.identity);
    }

    void Aparecer13()
    {
        //gameObject.SetActive(true);
        Vector3 position = new Vector3(-6,-4,0);
        createdObjec13 = Instantiate(objetoEjercicio13, position, Quaternion.identity);
    }

    void Aparecer14()
    {
        //gameObject.SetActive(true);
        Vector3 position = new Vector3(-4,-4,0);
        createdObjec14 = Instantiate(objetoEjercicio14, position, Quaternion.identity);
    }

    void Aparecer15()
    {
        //gameObject.SetActive(true);
        Vector3 position = new Vector3(-2,-4,0);
        createdObjec15 = Instantiate(objetoEjercicio15, position, Quaternion.identity);
    }

    void Aparecer16()
    {
        //gameObject.SetActive(true);
        Vector3 position = new Vector3(2,-4,0);
        createdObjec16 = Instantiate(objetoEjercicio16, position, Quaternion.identity);
    }

      void Aparecer17()
    {
        //gameObject.SetActive(true);
        Vector3 position = new Vector3(4,-4,0);
        createdObjec17 = Instantiate(objetoEjercicio17, position, Quaternion.identity);
    }

    void Aparecer18()
    {
        //gameObject.SetActive(true);
        Vector3 position = new Vector3(6,-4,0);
        createdObjec18 = Instantiate(objetoEjercicio18, position, Quaternion.identity);
    }

    

    void DestruirObjeto()
    {

    }
}
