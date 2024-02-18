using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RetomarPosicion : MonoBehaviour
{
    Vector2 InitialPos;
    public GameObject AA1;
    // Start is called before the first frame update
    void Start()
    {
        InitialPos = AA1.transform.position;
        
    }


    void OnTriggerEnter2D (Collider2D other) 
    {
        if (other.gameObject.tag == ("Contenedores1")) 
         {
            AA1.transform.position = InitialPos;
         }
    }
}
