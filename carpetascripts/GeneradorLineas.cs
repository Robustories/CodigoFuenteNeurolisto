using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorLineas : MonoBehaviour
{
   public GameObject lineaGenerada;

   Linea lineas;
   

   private void Update()
   {
       if(Input.GetKeyDown(KeyCode.Mouse0))
       {
           Vector3 dondeGenerar = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y, 0);
           GameObject lineaActual = Instantiate(lineaGenerada, dondeGenerar, transform.rotation);
           lineas = lineaActual.GetComponent<Linea>();
           
       }

       if(Input.GetKeyUp(KeyCode.Mouse0))
       {
           
           lineas.BorrarLineas();
           
           lineas = null;
           
           
       }

       if(lineas != null)
       {
           Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
           lineas.DibujarLinea(mousePos);

       }

       
   }

   

   
}
