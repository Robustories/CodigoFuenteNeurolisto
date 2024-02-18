using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciarCarros : MonoBehaviour
{
    [SerializeField]
    public GameObject carrito;
    private GameObject carritoCreado;
    public GameObject carrito2;
    private GameObject carritoCreado2;
    private int numeroazar;
    public enum DerechaOIzquierda
    {
        Derecha,
        Izquierda
    }
    
    

    // Start is called before the first frame update
    void Start()
    {
        NumeroAlAzar();
        //createCarrito();
        //Invoke("createCarrito2", 4);
        
    }

    void createCarrito()
    {
        //GameObject carritoCreado = Instantiate(carrito) as GameObject; 
        //carritoCreado.transform.position = vias[Random.Range(0, vias.Length)].transform.position;

        Vector3 position = new Vector3(3, 4, Random.Range(-10.0f, 10.0f));

        //Vector3 position = vias[Random.Range(0, vias.Length)].transform.position;
        carritoCreado = Instantiate(carrito, position, Quaternion.identity);
        Invoke ("destroyCarrito", 2f);
        
    }

    void createCarrito2()
    {
        

        Vector3 position = new Vector3(7, 4, Random.Range(-10.0f, 10.0f));

        
        carritoCreado2 = Instantiate(carrito2, position, Quaternion.identity);
        Invoke ("destroyCarrito2", 2f);
        
    }



    private void destroyCarrito()
    {
        Destroy (carritoCreado);
        Invoke ("NumeroAlAzar", 1f);
    }

    private void destroyCarrito2()
    {
        Destroy (carritoCreado2);
        Invoke ("NumeroAlAzar", 6f);
    }

    private void NumeroAlAzar()
    {
        numeroazar = Random.Range(1,3);
        Procedimiento();

    }

    private void Procedimiento()
    {
        switch(numeroazar)
        {
            case 1:
            createCarrito();
            break;

            case 2:
            createCarrito2();
            break;
        }
    }
}
