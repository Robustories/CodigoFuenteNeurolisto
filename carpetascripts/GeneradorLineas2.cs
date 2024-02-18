using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorLineas2 : MonoBehaviour
{
   public GameObject lineaGenerada2;


   Linea2 lineas2;

   

   private void Update()
   {
       if(Input.GetKeyDown(KeyCode.Mouse0))
       {
           Vector3 dondeGenerar = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y, 0);
           GameObject lineaActual2 = Instantiate(lineaGenerada2, dondeGenerar, transform.rotation);
           lineas2 = lineaActual2.GetComponent<Linea2>();
           
       }

       if(Input.GetKeyUp(KeyCode.Mouse0))
       {
           
           lineas2 = null;
                     
       }

       if(lineas2 != null){Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
           lineas2.DibujarLinea2(mousePos);

       }

       


       
   }

   

   
}
