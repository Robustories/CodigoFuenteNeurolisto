using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonControler : MonoBehaviour
{
    private SpriteRenderer theSprite;
    public int numeroBoton;
    private SimonManager theSM;
    private AudioSource theSound;
    

    // Start is called before the first frame update
    void Start()
    {
        theSprite = GetComponent<SpriteRenderer>();
        theSM = FindObjectOfType<SimonManager>();
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
        theSM.ColorPresionado(numeroBoton);
        theSound.Stop();
    }
}
