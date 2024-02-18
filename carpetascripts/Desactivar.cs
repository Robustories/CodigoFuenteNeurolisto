using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Desactivar : MonoBehaviour
{
    public GameObject objetoDesactivable;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void DesactivarObjeto()
    {
        objetoDesactivable.gameObject.SetActive(false);
    }
}
