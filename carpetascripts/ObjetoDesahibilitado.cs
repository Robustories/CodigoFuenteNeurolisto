using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoDesahibilitado : MonoBehaviour
{
    public GameObject CosaDeshabilitada;
    // Start is called before the first frame update
    void Start()
    {
        CosaDeshabilitada.gameObject.SetActive(false);
    }

}
