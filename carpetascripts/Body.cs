using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Body : MonoBehaviour
{
    
    public Sprite[] BodySprite;
    public int SpritePosition = 0;
    
    

    
    // Start is called before the first frame update
    

    public void CambiarImagen()
    {
        SpritePosition++;
        if(SpritePosition <= BodySprite.Length - 1)
        {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = BodySprite [SpritePosition];
        }
        else if(SpritePosition > BodySprite.Length)
        {
            SpritePosition = 0;

        }
    }

    

    
}
