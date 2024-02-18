 using UnityEngine;
 using System.Collections;
 using UnityEngine.UI;
 
 public class TestBox2 : MonoBehaviour {
 
     public bool filled;
     public int puntos;
     public int ocupantes;
     private Text Textscore;
     private Text Textprueba;
     public GameObject bloqueo;
     public DragAndDropa draganddropa;
     
     // Use this for initialization
     void Start () 
     {
         filled = false;
         bloqueo.gameObject.SetActive(false);
     }
 
     void OnTriggerEnter2D(Collider2D c)
     {   
         if(c.tag== "six") 
         {
             Debug.Log ("Objeto Entra");
             ocupantes = +1;
             //Textprueba.text =  ocupantes.ToString();
     
             if (filled == false) 
         {
             
             Debug.Log ("Question 2 is good");
             filled = true;
             {Invoke ("DesactivarCollider", 0.5f); }
             
             //Destroy(gameObject);
             
         }
         else{
             Debug.Log ("Question 2 is bad");
             filled = true;
             
         }

         }

         //if(Textscore != null){
             //Textscore.text =  puntos.ToString();
         //Textprueba.text =  ocupantes.ToString();
        //}
     }
    


     void OnTriggerExit2D (Collider2D c) 
     {
         if(c.gameObject.tag == ("six")) 
         {
             Debug.Log ("Objeto Sale");
             ocupantes--;
             //Textprueba.text =  ocupantes.ToString();
         if (filled == true) 
         {
            puntos--;
            //Textscore.text = puntos.ToString();
            filled = false;
         }
         }

        // if(Textscore != null){
             //Textscore.text =  puntos.ToString();
             //Textprueba.text =  ocupantes.ToString();}
    }


    void DesactivarCollider()
    {
        GetComponent<Collider2D>().enabled = false;
        puntos = +1;
        Bloquear();

    }

    void Bloquear()
    {
        bloqueo.gameObject.SetActive(true);

    }
 }