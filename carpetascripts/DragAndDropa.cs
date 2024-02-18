using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class DragAndDropa : MonoBehaviour
{
    float distanciaRayo;
    GameObject pieza;
    private bool isDragging;

    public void OnMouseDown()
    {
        isDragging = true;
    }

    public void OnMouseUp()
    {
        isDragging = false;
    }

    void Update()
    {
        if (isDragging){ MoverObjeto();}
        // if(Input.GetMouseButtonDown(0)){
		//MoverObjeto ();
	}
            
            


void MoverObjeto()
{
    Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            //RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            transform.Translate(mousePosition);

            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
	if (hit)

	//Si estamos trabajando con Colliders 3D
	//Ray rayo = Camera.main.ScreenPointToRay (Input.mousePosition);
	//RaycastHit hit;
	//if (Physics.Raycast (rayo, out hit)) {
        {
			distanciaRayo = hit.distance; //distanciaRayo será un valor que utilizaremos más adelante
			pieza = hit.collider.gameObject;
			Debug.Log (pieza);
		}
}
    
}
