using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unir3 : MonoBehaviour
{
    public GameObject A001, A002, A003, B001, B002, B003;
    Vector2 A001InitialPos, A002InitialPos, A003InitialPos;
    public GameObject pantallaContinuar00;

    public AudioSource source;
    public AudioClip correct;
    public AudioClip incorrect;

    bool A001correct, A002correct, A003correct = false;
    // Start is called before the first frame update
    void Start()
    {
        A001InitialPos = A001.transform.position;
        A002InitialPos = A002.transform.position;
        A003InitialPos = A003.transform.position;
        pantallaContinuar00.gameObject.SetActive(false);
        
    }

    public void DragA001()
    {
        A001.transform.position = Input.mousePosition;
    }

    public void DragA002()
    {
        A002.transform.position = Input.mousePosition;
    }

    public void DragA003()
    {
        A003.transform.position = Input.mousePosition;
    }

    public void DropA001()
    {
        float Distance = Vector3.Distance(A001.transform.position, B001.transform.position);
        if (Distance < 50)
        {
            A001.transform.position = B001.transform.position;
            source.clip = correct;
            source.Play();
            A001correct = true;
            
        }
        else
        {
            A001.transform.position = A001InitialPos;
            source.clip = incorrect;
            source.Play();
        }
    }

    public void DropA002()
    {
        float Distance = Vector3.Distance(A002.transform.position, B002.transform.position);
        if (Distance < 50)
        {
            A002.transform.position = B002.transform.position;
            source.clip = correct;
            source.Play();
            A002correct = true;
            
        }
        else
        {
            A002.transform.position = A002InitialPos;
            source.clip = incorrect;
            source.Play();
        }
    }

    public void DropA003()
    {
        float Distance = Vector3.Distance(A003.transform.position, B003.transform.position);
        if (Distance < 50)
        {
            A003.transform.position = B003.transform.position;
            source.clip = correct;
            source.Play();
            A003correct = true;
            
        }
        else
        {
            A003.transform.position = A003InitialPos;
            source.clip = incorrect;
            source.Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(A001correct && A002correct && A003correct)
        {
            Debug.Log("You win");
            {Invoke ("Unir3Superado", 0.5f);}
        }
        
    }

    void Unir3Superado()
    { 
        pantallaContinuar00.SetActive(true);
    }
}
