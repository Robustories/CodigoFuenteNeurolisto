using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorLineas22 : MonoBehaviour
{
    public GameObject lineaGenerada22;
    Linea2 lineas22;
    // Start is called before the first frame update
    
    private void Update()
   {
       if(Input.GetKeyDown(KeyCode.Mouse0))
       {
           Vector3 dondeGenerar = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y, 0);
           GameObject lineaActual22 = Instantiate(lineaGenerada22, dondeGenerar, transform.rotation);
           lineas22 = lineaActual22.GetComponent<Linea2>();
           
       }

       if(Input.GetKeyUp(KeyCode.Mouse0))
       {
           
           lineas22 = null;
           
       }

      


       if(lineas22 != null)
       {
           Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
           lineas22.DibujarLinea22(mousePos);

       }


       
   }

   

   
}

