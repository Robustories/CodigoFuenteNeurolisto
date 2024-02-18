using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Detener_Avanzar : MonoBehaviour

{
    public Ruta ruta;
    public float spid;
    // Start is called before the first frame update
    void Start()
    {
        Ruta variable = GetComponent<Ruta>();
        
    }

    void Update()
    {
        spid = ruta.speed;

        
        
        if (Input.GetMouseButtonDown(0))
        {
            spid= 5;
            print ("Pressed");
        }
        if (Input.GetMouseButtonUp(0))
        {
            spid = 1;
            print ("Released");
        }

    


    // Update is called once per frame
    

    


}
}
