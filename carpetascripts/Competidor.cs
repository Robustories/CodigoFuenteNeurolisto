using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Competidor : MonoBehaviour
{
    
    
    public Meta meta;
    public Transform metas;
    public Transform metas2;
    public float speed;
    public Ruta ruta;
    
    private bool finCarrera;
    public bool puedeMoverseA = true;
    float repetirPatron = 10;
    private bool arrancar;
    private bool cpuntollegada1;
    public CambioDireccionC1 ccd1;
    public bool etapa1 = false;

    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("DetenerA", 5f, repetirPatron);
        InvokeRepeating("ArrancarA", 9f, repetirPatron);
        Meta variable = GetComponent<Meta>();
        Ruta variable2 = GetComponent<Ruta>();
        CambioDireccionC1 variable3 = GetComponent<CambioDireccionC1>();
        
        
         
    }

    // Update is called once per frame
    void Update()
    {
        
        
        finCarrera = Meta.llegada;
        arrancar = Ruta.iniciarCarrera;
        cpuntollegada1 = CambioDireccionC1.CambioEtapac1;

        {float step = speed * Time.deltaTime;
        if(etapa1 == false)
        transform.position = Vector3.MoveTowards(transform.position, metas.position, step);
        if(cpuntollegada1 == true){
            transform.eulerAngles = new Vector3(0, 0, 90);
            etapa1 = true;
            Debug.Log("llego");
        transform.position = Vector3.MoveTowards(transform.position, metas2.position, step);}
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
