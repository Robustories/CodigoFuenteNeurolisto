using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comer2 : MonoBehaviour
{
    public static int Score2;
    public GameObject pantallaPerder2;
    // Start is called before the first frame update
    void Start()
    {
        pantallaPerder2.gameObject.SetActive(false);
        Score2 = 0;
        
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        
        
        if (other.gameObject.tag ==("Chocar")) 
         {
            pantallaPerder2.gameObject.SetActive(true);

         }
         else
         {
             Destroy(other.gameObject);
             Score2 = Score2 + 1;

         }
    }
}
