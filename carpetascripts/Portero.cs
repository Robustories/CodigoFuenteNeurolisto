using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portero : MonoBehaviour
{
    Rigidbody2D rbTapar;

    public GameObject balont;
    private GameObject balonTapado;
    public Porteria porteria;

    public static int tapado = 1; 
    private int destapadoa;

    

    
    public static Portero Porterro;
    // Start is called before the first frame update
    void Awake()
    {
        Porterro = this;
        rbTapar = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Porteria variable = GetComponent<Porteria>();
        destapadoa = Porteria.destapado;

        if(destapadoa != 0){tapado = 1;}

        

        
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);
        //Destroy(gameObject);
        tapado = 0;
        

        Vector3 position = new Vector3(0, -3, 1);
        balonTapado = Instantiate(balont, position, Quaternion.identity);



    }
}
