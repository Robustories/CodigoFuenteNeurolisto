using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comer : MonoBehaviour
{
    public static int Score;
    public GameObject pantallaPerder;
    // Start is called before the first frame update
    void Start()
    {
        pantallaPerder.gameObject.SetActive(false);
        Score = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
          
    
        //Destroy(other.gameObject);
        //Score = Score + 1;
        
        if (other.gameObject.tag ==("Chocar")) 
         {
            pantallaPerder.gameObject.SetActive(true);

         }
         else
         {
             Destroy(other.gameObject);
             Score = Score + 1;

         }
    }
}
