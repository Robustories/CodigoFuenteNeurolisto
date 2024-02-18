using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Question : MonoBehaviour
{

   public string text = null;
   public List<Option> options = null;
   public Sprite imagenPregunta = null; 
   public Sprite imagenPregunta2 = null; 
   public Sprite imagenPregunta3 = null;
   public Sprite imagenPregunta4 = null; 
   public Sprite imagenPregunta5 = null; 
   public Sprite imagenPregunta6 = null;
   public Sprite imagenPregunta7 = null; 
   public Sprite imagenPregunta8 = null; 
   public Sprite imagenPregunta9 = null;
   public Sprite imagenPregunta10 = null; 
   public Sprite imagenPregunta11 = null; 
   public Sprite imagenPregunta12 = null;  
   public Sprite imagenPregunta13 = null; 
   public Sprite imagenPregunta14 = null; 
   public Sprite imagenPregunta15 = null;
   public Sprite imagenPregunta16 = null; 
   public Sprite imagenPregunta17 = null; 
   public Sprite imagenPregunta18 = null;
   public Sprite imagenPregunta19 = null; 
   public Sprite imagenPregunta20 = null; 
   public Sprite imagenPregunta21 = null; 
 
   public Sprite imagenRespuesta = null;
   public AudioClip sonidoPregunta = null;
   public float timer;
   public float tiempoPregunta;

   

   void Start()
   {
      timer = tiempoPregunta;
           
   }

   void Update()
   {
      timer -= 1 * Time.deltaTime;
   }

   

   
}
