using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiempoDeVidaTopo : MonoBehaviour
{
    public int tiempoVida;
    private MoleSpawner ms;
    
    // Start is called before the first frame update
    void Start()
    {
        
        Invoke("EsconderTopo", tiempoVida);
        
        ms = GetComponent<MoleSpawner>();
    }

    void EsconderTopo()
    {
        Destroy(gameObject, .5f);
        
    }

    
}
