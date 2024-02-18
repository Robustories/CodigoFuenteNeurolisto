using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstrumentoMusical : MonoBehaviour
{
    public AudioClip sonidoInstrumentoMusical;
    public AudioSource source;
    // Start is called before the first frame update

    void Awake()
    {
         AudioSource audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetMouseButtonDown(0)) {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
            
            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            if (hit.collider != null) {
                Debug.Log(hit.collider.gameObject.name);
                hit.collider.attachedRigidbody.AddForce(Vector2.up);
            }
        }
    }



    void OnMouseDown()
    {
        if(Input.GetMouseButtonDown(0))
        {
        GetComponent<AudioSource>().clip = sonidoInstrumentoMusical;
        GetComponent<AudioSource>().Play();
        print ("Sirve");
        }
    }
}
