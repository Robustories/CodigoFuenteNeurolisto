using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverObjetosConRaycast : MonoBehaviour
{
    float distanciaRayo;
    GameObject pieza;
    bool estaPulsado;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
		SeleccionarPieza ();
        }

        if (Input.GetMouseButtonUp (0)) {
		SoltarPieza ();
	}

        if(estaPulsado){
		MoverPieza ();
        }	

	
    }

    void SeleccionarPieza(){
	//Si estamos trabajando con Colliders 2D
	RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
    Collider2D[] col = Physics2D.OverlapPointAll(Camera.main.ScreenToWorldPoint(Input.mousePosition));
	if (hit)
    //hit = GetComponent<BoxCollider2D>();
    Debug.Log (col);

    foreach (Collider2D c in col)
    {
    
//
	//Si estamos trabajando con Colliders 3D
	//Ray rayo = Camera.main.ScreenPointToRay (Input.mousePosition);
	//RaycastHit hit;
	//if (Physics.Raycast (rayo, out hit)) {
		if (c.tag == "Objeto1") {
            estaPulsado=true;
			distanciaRayo = hit.distance; //distanciaRayo será un valor que utilizaremos más adelante
			//col = GetComponent<BoxCollider2D>();
            pieza = c.gameObject;
			Debug.Log (pieza);
		}

        if (c.tag == "Objeto2") {
            estaPulsado=true;
			distanciaRayo = hit.distance; //distanciaRayo será un valor que utilizaremos más adelante
			//col = GetComponent<BoxCollider2D>();
            pieza = c.gameObject;
			Debug.Log (pieza);
		}

        if (c.tag == "Objeto3") {
            estaPulsado=true;
			distanciaRayo = hit.distance; //distanciaRayo será un valor que utilizaremos más adelante
			//col = GetComponent<BoxCollider2D>();
            pieza = c.gameObject;
			Debug.Log (pieza);
		}

        if (c.tag == "Objeto4") {
            estaPulsado=true;
			distanciaRayo = hit.distance; //distanciaRayo será un valor que utilizaremos más adelante
			//col = GetComponent<BoxCollider2D>();
            pieza = c.gameObject;
			Debug.Log (pieza);
		}

        if (c.tag == "Objeto5") {
            estaPulsado=true;
			distanciaRayo = hit.distance; //distanciaRayo será un valor que utilizaremos más adelante
			//col = GetComponent<BoxCollider2D>();
            pieza = c.gameObject;
			Debug.Log (pieza);
		}

        if (c.tag == "Animal1") {
            estaPulsado=true;
			distanciaRayo = hit.distance; //distanciaRayo será un valor que utilizaremos más adelante
			//col = GetComponent<BoxCollider2D>();
            pieza = c.gameObject;
			Debug.Log (pieza);
		}

        if (c.tag == "Animal2") {
            estaPulsado=true;
			distanciaRayo = hit.distance; //distanciaRayo será un valor que utilizaremos más adelante
			//col = GetComponent<BoxCollider2D>();
            pieza = c.gameObject;
			Debug.Log (pieza);
		}

        if (c.tag == "Animal3") {
            estaPulsado=true;
			distanciaRayo = hit.distance; //distanciaRayo será un valor que utilizaremos más adelante
			//col = GetComponent<BoxCollider2D>();
            pieza = c.gameObject;
			Debug.Log (pieza);
		}

        if (c.tag == "Animal4") {
            estaPulsado=true;
			distanciaRayo = hit.distance; //distanciaRayo será un valor que utilizaremos más adelante
			//col = GetComponent<BoxCollider2D>();
            pieza = c.gameObject;
			Debug.Log (pieza);
		}

        if (c.tag == "Animal5") {
            estaPulsado=true;
			distanciaRayo = hit.distance; //distanciaRayo será un valor que utilizaremos más adelante
			//col = GetComponent<BoxCollider2D>();
            pieza = c.gameObject;
			Debug.Log (pieza);
		}

        if (c.tag == "1") {
            estaPulsado=true;
			distanciaRayo = hit.distance; //distanciaRayo será un valor que utilizaremos más adelante
			//col = GetComponent<BoxCollider2D>();
            pieza = c.gameObject;
			Debug.Log (pieza);
		}

        if (c.tag == "2") {
            estaPulsado=true;
			distanciaRayo = hit.distance; //distanciaRayo será un valor que utilizaremos más adelante
			//col = GetComponent<BoxCollider2D>();
            pieza = c.gameObject;
			Debug.Log (pieza);
		}

        if (c.tag == "3") {
            estaPulsado=true;
			distanciaRayo = hit.distance; //distanciaRayo será un valor que utilizaremos más adelante
			//col = GetComponent<BoxCollider2D>();
            pieza = c.gameObject;
			Debug.Log (pieza);
		}

        if (c.tag == "4") {
            estaPulsado=true;
			distanciaRayo = hit.distance; //distanciaRayo será un valor que utilizaremos más adelante
			//col = GetComponent<BoxCollider2D>();
            pieza = c.gameObject;
			Debug.Log (pieza);
		}

        if (c.tag == "5") {
            estaPulsado=true;
			distanciaRayo = hit.distance; //distanciaRayo será un valor que utilizaremos más adelante
			//col = GetComponent<BoxCollider2D>();
            pieza = c.gameObject;
			Debug.Log (pieza);
		}

        


    }    
	}

    void MoverPieza(){
	Ray rayo = Camera.main.ScreenPointToRay (Input.mousePosition);
	Vector3 limiteRayo = rayo.GetPoint (distanciaRayo);
	limiteRayo = new Vector3 (limiteRayo.x, limiteRayo.y, 0);
	pieza.transform.position = limiteRayo;
}

void SoltarPieza(){
	if (estaPulsado) {
		estaPulsado = false;
		pieza = null;
	}
}
	
}

