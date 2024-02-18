using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FichasAjustables : MonoBehaviour
{
    private bool isDragging;
    private bool Seguiraqui = true;
    public CentroCollider centroCollider;

    void Start()
    {
        CentroCollider variable1 = GetComponent<CentroCollider>();

    }

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
        Seguiraqui = centroCollider.Suelto;
        
        
        if (isDragging && Seguiraqui)
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            transform.Translate(mousePosition);
            
        }
    }

    
}
