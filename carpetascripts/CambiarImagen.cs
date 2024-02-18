using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CambiarImagen : MonoBehaviour
{
    private SpriteRenderer rend;
    public Sprite portada, revelado;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<SpriteRenderer>();

        
    }

    // Update is called once per frame
    private void Update()
    {
         //void OnTriggerEnter2D (Collider2D other) {
        // if (other.gameObject.tag == ("Contenedor1")) {
            //rend.sprite = revelado;
            
         //}
    

    if(Input.GetMouseButtonUp(0)){rend.sprite = revelado;}
        
    }
}
