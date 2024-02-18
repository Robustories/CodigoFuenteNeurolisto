using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unir2 : MonoBehaviour
{
    public GameObject A01, A02, B01, B02;
    Vector2 A01InitialPos, A02InitialPos;
    public GameObject pantallaContinuar0;

    public AudioSource source;
    public AudioClip correct;
    public AudioClip incorrect;

    bool A01correct, A02correct = false;
    // Start is called before the first frame update
    void Start()
    {
        A01InitialPos = A01.transform.position;
        A02InitialPos = A02.transform.position;
        pantallaContinuar0.gameObject.SetActive(false);
        
    }

    public void DragA01()
    {
        A01.transform.position = Input.mousePosition;
    }

    public void DragA02()
    {
        A02.transform.position = Input.mousePosition;
    }

    public void DropA01()
    {
        float Distance = Vector3.Distance(A01.transform.position, B01.transform.position);
        if (Distance < 50)
        {
            A01.transform.position = B01.transform.position;
            source.clip = correct;
            source.Play();
            A01correct = true;
            
        }
        else
        {
            A01.transform.position = A01InitialPos;
            source.clip = incorrect;
            source.Play();
        }
    }

    public void DropA2()
    {
        float Distance = Vector3.Distance(A02.transform.position, B02.transform.position);
        if (Distance < 50)
        {
            A02.transform.position = B02.transform.position;
            source.clip = correct;
            source.Play();
            A02correct = true;
            
        }
        else
        {
            A02.transform.position = A02InitialPos;
            source.clip = incorrect;
            source.Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(A01correct && A02correct)
        {
            Debug.Log("You win");
            {Invoke ("Unir2Superado", 0.5f);}
        }
        
    }

    void Unir2Superado()
    { 
        pantallaContinuar0.SetActive(true);
    }
}
