using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciarLineas : MonoBehaviour
{
    public GameObject linea;
    private GameObject createdLinea;
    public GameObject lineaAparecida;
    // Start is called before the first frame update
    void Start()
    {
        CreateLinea();
        lineaAparecida.gameObject.SetActive(false);
        
    }

    private void CreateLinea()
    {
        
        Vector3 position = new Vector3(0,0,0);
        createdLinea = Instantiate(linea, position, Quaternion.identity)as GameObject;
        Invoke ("DestroyLinea", 1f);

        
    }

    private void DestroyLinea()
    {
        Debug.Log("ObjetoDestruido");
        Destroy (createdLinea);
        Invoke ("CreateLinea", 2f);
    }

    public void ActivarLinea()
    {
        lineaAparecida.gameObject.SetActive(true);
        Debug.Log("Linea Aparece");

    }
}
