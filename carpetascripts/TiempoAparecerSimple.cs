using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiempoAparecerSimple : MonoBehaviour
{
    public GameObject o;
    public float t; 
    // Start is called before the first frame update
    void Start()
    {
        o.SetActive(false);
        Invoke("Ap", t);
        
    }

    void Ap()
    
    {
        o.SetActive(true);

    }
}
