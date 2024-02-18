using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Competidor2 : MonoBehaviour
{
    public Meta meta;
    public Transform metas_2;
    public Transform metas2_2;
    public float speed;
    public Ruta ruta;
    
    private bool finCarrera;
    public bool puedeMoverseA = true;
    float repetirPatron = 10;
    private bool arrancar;
    private bool cpuntollegada1;
    public CambioDireccionC2 ccd2;
    public bool etapa21 = false;

    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("DetenerA", 5f, repetirPatron);
        InvokeRepeating("ArrancarA", 9f, repetirPatron);
        Meta variable = GetComponent<Meta>();
        Ruta variable2 = GetComponent<Ruta>();
        CambioDireccionC2 variable3 = GetComponent<CambioDireccionC2>();
        
        
         
    }

    // Update is called once per frame
    void Update()
    {
        
        
        finCarrera = Meta.llegada;
        arrancar = Ruta.iniciarCarrera;
        cpuntollegada1 = CambioDireccionC2.CambioEtapac2;

        {float step = speed * Time.deltaTime;
        if(etapa21 == false)
        transform.position = Vector3.MoveTowards(transform.position, metas_2.position, step);
        if(cpuntollegada1 == true){
            transform.eulerAngles = new Vector3(0, 0, 90);
            etapa21 = true;
            Debug.Log("llego");
        transform.position = Vector3.MoveTowards(transform.position, metas2_2.position, step);}
        }

       
        if (finCarrera == true){
        Debug.Log("Se ha detenido");
        DetenerA();}

        
    }

    public void DetenerA()
    {
    speed = 0;
    puedeMoverseA = false;
    }
    
    public void ArrancarA()
    {
    speed = 0.7f;
    puedeMoverseA = true;
    }

   

}
