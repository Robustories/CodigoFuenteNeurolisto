using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MostrarPrefab : MonoBehaviour
{
    public GameObject prefabPantalla;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void MostrarPrefabPantalla()
    {
        prefabPantalla.SetActive(true);
    }
}
