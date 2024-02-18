using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acomodar4 : MonoBehaviour
{
    public GameObject A41, A42, A43, A44, B41, B42, B43, B44;
    Vector2 A41InitialPos, A42InitialPos, A43InitialPos, A44InitialPos;
    public GameObject pantallaContinuar4;

    public AudioSource source;
    public AudioClip correct;
    public AudioClip incorrect;

    bool A41correct, A42correct, A43correct, A44correct   = false;

    void Start()
    {
        A41InitialPos = A41.transform.position;
        A42InitialPos = A42.transform.position;
        A43InitialPos = A43.transform.position;
        A44InitialPos = A44.transform.position;

        pantallaContinuar4.gameObject.SetActive(false);
        
    }

    public void DragA61()
    {
        A41.transform.position = Input.mousePosition;
    }

    public void DragA62()
    {
        A42.transform.position = Input.mousePosition;
    }

    public void DragA63()
    {
        A43.transform.position = Input.mousePosition;
    }

    public void DragA64()
    {
        A44.transform.position = Input.mousePosition;
    }

    public void DropA41()
    {
        float Distance = Vector3.Distance(A41.transform.position, B41.transform.position);
        if (Distance < 50)
        {
            A41.transform.position = B41.transform.position;
            source.clip = correct;
            source.Play();
            A41correct = true;
        }
        else
        {
            A41.transform.position = A41InitialPos;
            source.clip = incorrect;
            source.Play();
        }
    }

    public void DropA62()
    {
        float Distance = Vector3.Distance(A42.transform.position, B42.transform.position);
        if (Distance < 50)
        {
            A42.transform.position = B42.transform.position;
            source.clip = correct;
            source.Play();
            A42correct = true;
        }
        else
        {
            A42.transform.position = A42InitialPos;
            source.clip = incorrect;
            source.Play();
        }
    }

    public void DropA63()
    {
        float Distance = Vector3.Distance(A43.transform.position, B43.transform.position);
        if (Distance < 50)
        {
            A43.transform.position = B43.transform.position;
            source.clip = correct;
            source.Play();
            A43correct = true;
        }
        else
        {
            A43.transform.position = A43InitialPos;
            source.clip = incorrect;
            source.Play();
        }
    }

    public void DropA44()
    {
        float Distance = Vector3.Distance(A44.transform.position, B44.transform.position);
        if (Distance < 50)
        {
            A44.transform.position = B44.transform.position;
            source.clip = correct;
            source.Play();
            A44correct = true;
        }
        else
        {
            A44.transform.position = A44InitialPos;
            source.clip = incorrect;
            source.Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(A41correct && A42correct && A43correct && A44correct)
        {
            Debug.Log("You win");
            {Invoke ("Continuar4", 0.8f); }
        }
        
    }

    void Continuar4()
    { 
        pantallaContinuar4.gameObject.SetActive(true); 
    }
}
