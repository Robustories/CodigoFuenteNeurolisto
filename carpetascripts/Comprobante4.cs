using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Comprobante4 : MonoBehaviour
{
    public bool filled;
    public int puntos;
    public Text Textscore;
    // Start is called before the first frame update
    void Start()
    {
        filled = false;
    }


    void OnTriggerEnter2D(Collider2D c)
     {    
     
             if (c.tag== "D") 
         {
             Debug.Log ("Question 2 is good");
             filled = true;
             puntos = +1;
         }
         else{
             Debug.Log ("Question 2 is bad");
             filled = true;
             
         }

         if(Textscore != null)
        {
            Textscore.text =  puntos.ToString();
        }
     
 
     }

     void OnTriggerExit2D (Collider2D c) 
     {
        if (c.tag== "D") 
         {
             Debug.Log ("Question 2 is good");
             filled = false;
             puntos = 0;
         }
         else{
             Debug.Log ("Question 2 is bad");
             filled = false;
             
         }

         if(Textscore != null)
        {
            Textscore.text =  puntos.ToString();
        }
    }
}
