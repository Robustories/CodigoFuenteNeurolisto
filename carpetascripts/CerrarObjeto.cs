using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CerrarObjeto : MonoBehaviour
{
    public GameObject Objetocerrable;
    // Start is called before the first frame update
    void Start()
    {
         Objetocerrable.SetActive(false);
        
    }


    public void CerrarObjetoCerrable()
    {
        Objetocerrable.SetActive(false);
    }

    public void MostrarObjetoCerrable()
    {
        Objetocerrable.SetActive(true);
    }
}
