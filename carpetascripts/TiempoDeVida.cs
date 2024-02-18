using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiempoDeVida : MonoBehaviour
{
    public int tiempoVida;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestruirObjeto", tiempoVida);
    }


    void DestruirObjeto()
    {
        Destroy(gameObject,.5f);

    }

    
}
