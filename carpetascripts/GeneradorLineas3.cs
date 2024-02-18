using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorLineas3 : MonoBehaviour
{
    public GameObject lineaGenerada3;

   Linea lineas;
   public ComerEnOrden ceo;
   bool borrar;
   

   private void Update()
   {
       ComerEnOrden variable = GetComponent<ComerEnOrden>();
       borrar = ComerEnOrden.fallo;

       if(Input.GetKeyDown(KeyCode.Mouse0))
       {
           Vector3 dondeGenerar = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y, 0);
           GameObject lineaActual3 = Instantiate(lineaGenerada3, dondeGenerar, transform.rotation);
           lineas = lineaActual3.GetComponent<Linea>();
           
       }

       if(Input.GetKeyUp(KeyCode.Mouse0))
       {
           lineas = null;
           
           
       }

       if(lineas != null)
       {
           Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
           lineas.DibujarLinea(mousePos);

       }

       if(borrar == true)
       {
           lineas.BorrarLineas();
           Invoke ("Nulllineas", 0.002f);
       }

       





       
   }

   void Nulllineas()
   {
       lineas = null;

   }

   

   
}
