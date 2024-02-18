using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PonerseVerde : MonoBehaviour
{
    public Button btn {get {return GetComponent<Button> ();}}
    public Color verde = new Color(0.2F, 0.3F, 0.4F, 0.5F);

    // Start is called before the first frame update
    void Start()
    {
        btn.onClick.AddListener (Verdearse);
        
        
    }

    public void Verdearse()
    {
        //image.material.color = verde;
    }
}
