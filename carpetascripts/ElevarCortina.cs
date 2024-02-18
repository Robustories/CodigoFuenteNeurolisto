using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevarCortina : MonoBehaviour
{
    public float velocidadCortina = 1f;
    public float maxY;
    public GameObject cortina;
    public Transform telon;
    // Start is called before the first frame update
    void Start()
    {
        Invoke ("SubirCortina", 2f);
        
        
    }

    // Update is called once per frame
    void Update()
    {
        {float step = velocidadCortina * Time.deltaTime;
    transform.position = Vector3.MoveTowards(transform.position, telon.position, step);}
        
    }

    
}
