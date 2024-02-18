using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MA2 : MonoBehaviour
{
    public static bool mara;
    // Start is called before the first frame update
    void Start()
    {
        mara = false;
        
    }

    void OnTriggerEnter2D (Collider2D other) 
     {
         if (other.gameObject.tag == ("ra")) 
         {
            mara = true;
         }
    }
}
