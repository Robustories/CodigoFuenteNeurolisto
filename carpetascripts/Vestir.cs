using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vestir : MonoBehaviour
{
    public Sprite[] BodySprite;
    public int SpritePosition = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G)) {
            SpritePosition++;
            if (SpritePosition <= BodySprite.Length)
            {
                this.gameObject.GetComponent<SpriteRenderer> ().sprite = BodySprite[SpritePosition];
            }
        }
        
    }
}
