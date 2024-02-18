using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReiniciarLinea : MonoBehaviour
{
    public GameObject Controlalineas;
    public GameObject ObjetoAcomodable;
    Collider2D m_Collider;
    // Start is called before the first frame update
    void Start()
    {
        //m_Collider = ObjetoAcomodable.GetComponent<Collider2D>();
        Controlalineas.gameObject.SetActive(false);
        ObjetoAcomodable.GetComponent<Collider2D>().enabled = false;
        Invoke ("Reestablecer", .1f);
        
    }
    
    void Reestablecer()
    {
        //ObjetoAcomodable.GetComponent<Collider2D>().enabled = false;
        ObjetoAcomodable.transform.position = new Vector3(0,0,0);

        Controlalineas.gameObject.SetActive(true);

    }


}
