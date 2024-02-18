using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teclacontroler : MonoBehaviour
{
    private SpriteRenderer theSprite;
    public int numeroBoton;
    private Piano thePiano;
    private AudioSource theSound;
    

    // Start is called before the first frame update
    void Start()
    {
        theSprite = GetComponent<SpriteRenderer>();
        thePiano = FindObjectOfType<Piano>();
        theSound = GetComponent<AudioSource>();
    }
    
    void OnMouseDown()
    {
        theSprite.color = new Color(theSprite.color.r, theSprite.color.g, theSprite.color.b, 1f);
        theSound.Play();
    }

    void OnMouseUp()
    {
        theSprite.color = new Color(theSprite.color.r, theSprite.color.g, theSprite.color.b, 0.1f);
        thePiano.ColorPresionado(numeroBoton);
        theSound.Stop();
    }
}
