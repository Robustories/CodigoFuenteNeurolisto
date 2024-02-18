using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlalineas : MonoBehaviour
{
    public GameObject Control1;
    public bool Control1activo;
    // Start is called before the first frame update
    void Start()
    {
        Control1.gameObject.SetActive(true);
        
    }

}
