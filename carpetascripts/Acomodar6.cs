using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acomodar6 : MonoBehaviour
{
    public GameObject A61, A62, A63, A64, A65, A66, B61, B62, B63, B64, B65, B66;
    Vector2 A61InitialPos, A62InitialPos, A63InitialPos, A64InitialPos, A65InitialPos, A66InitialPos;
    public GameObject pantallaContinuar6;

    public AudioSource source;
    public AudioClip correct;
    public AudioClip incorrect;

    bool A61correct, A62correct, A63correct, A64correct, A65correct, A66correct  = false;
    // Start is called before the first frame update
    void Start()
    {
        A61InitialPos = A61.transform.position;
        A62InitialPos = A62.transform.position;
        A63InitialPos = A63.transform.position;
        A64InitialPos = A64.transform.position;
        A65InitialPos = A65.transform.position;
        A66InitialPos = A66.transform.position;

        pantallaContinuar6.gameObject.SetActive(false);
        
    }

    public void DragA61()
    {
        A61.transform.position = Input.mousePosition;
    }

    public void DragA62()
    {
        A62.transform.position = Input.mousePosition;
    }

    public void DragA63()
    {
        A63.transform.position = Input.mousePosition;
    }

    public void DragA64()
    {
        A64.transform.position = Input.mousePosition;
    }

    public void DragA65()
    {
        A65.transform.position = Input.mousePosition;
    }

    public void DragA66()
    {
        A66.transform.position = Input.mousePosition;
    }

    public void DropA61()
    {
        float Distance = Vector3.Distance(A61.transform.position, B61.transform.position);
        if (Distance < 50)
        {
            A61.transform.position = B61.transform.position;
            source.clip = correct;
            source.Play();
            A61correct = true;
        }
        else
        {
            A61.transform.position = A61InitialPos;
            source.clip = incorrect;
            source.Play();
        }
    }

    public void DropA62()
    {
        float Distance = Vector3.Distance(A62.transform.position, B62.transform.position);
        if (Distance < 50)
        {
            A62.transform.position = B62.transform.position;
            source.clip = correct;
            source.Play();
            A62correct = true;
        }
        else
        {
            A62.transform.position = A62InitialPos;
            source.clip = incorrect;
            source.Play();
        }
    }

    public void DropA63()
    {
        float Distance = Vector3.Distance(A63.transform.position, B63.transform.position);
        if (Distance < 50)
        {
            A63.transform.position = B63.transform.position;
            source.clip = correct;
            source.Play();
            A63correct = true;
        }
        else
        {
            A63.transform.position = A63InitialPos;
            source.clip = incorrect;
            source.Play();
        }
    }

    public void DropA64()
    {
        float Distance = Vector3.Distance(A64.transform.position, B64.transform.position);
        if (Distance < 50)
        {
            A64.transform.position = B64.transform.position;
            source.clip = correct;
            source.Play();
            A64correct = true;
        }
        else
        {
            A64.transform.position = A64InitialPos;
            source.clip = incorrect;
            source.Play();
        }
    }

    
    public void DropA65()
    {
        float Distance = Vector3.Distance(A65.transform.position, B65.transform.position);
        if (Distance < 50)
        {
            A65.transform.position = B65.transform.position;
            source.clip = correct;
            source.Play();
            A65correct = true;
        }
        else
        {
            A65.transform.position = A65InitialPos;
            source.clip = incorrect;
            source.Play();
        }
    }

    public void Drop66()
    {
        float Distance = Vector3.Distance(A66.transform.position, B66.transform.position);
        if (Distance < 50)
        {
            A66.transform.position = B66.transform.position;
            source.clip = correct;
            source.Play();
            A66correct = true;
        }
        else
        {
            A66.transform.position = A66InitialPos;
            source.clip = incorrect;
            source.Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(A61correct && A62correct && A63correct && A64correct && A65correct && A66correct)
        {
            Debug.Log("You win");
            {Invoke ("Continuar6", 1.0f); }
        }
        
    }

    void Continuar6()
    { 
        pantallaContinuar6.gameObject.SetActive(true); 
    }

    
}
