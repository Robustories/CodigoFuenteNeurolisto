using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CentroCollider : MonoBehaviour
{
    public bool Suelto = true; 

    void OnTriggerEnter2D(Collider2D centro)
     {   
         if(centro.tag== "Enganche") 
         {
           Suelto = false;

         }

         
     }
}
