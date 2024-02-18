using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopoScript : MonoBehaviour
{
    public Sprite mareado;
    int puntoGolpe;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnMouseUp()
    {
        {
        Marearse();
        Invoke ("F", 0.7f);
        }
    }

    void Marearse()
    {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = mareado;
    }

    void F()
    {
        Destroy(gameObject);
    }
}
