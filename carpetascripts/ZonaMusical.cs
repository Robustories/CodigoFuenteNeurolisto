using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZonaMusical : MonoBehaviour
{
    public GameObject A1, A2, A3, A4, A5, B1, B2, B3, B4 , B5 ;

    Vector2 A1InitialPos, A2InitialPos, A3InitialPos, A4InitialPos, A5InitialPos;
    public GameObject pantallaContinuarz;
    

    public AudioSource source;
    public AudioClip correct;
    public AudioClip incorrect;

    bool A1correct, A2correct, A3correct, A4correct, A5correct = false;

    void Start()
    {
        A1InitialPos = A1.transform.position;
        A2InitialPos = A2.transform.position;
        A3InitialPos = A3.transform.position;
        A4InitialPos = A4.transform.position;
        A5InitialPos = A5.transform.position;
        
        pantallaContinuarz.gameObject.SetActive(false);

    }

    public void DragA1()
    {
        A1.transform.position = Input.mousePosition;
    }

    public void DragA2()
    {
        A2.transform.position = Input.mousePosition;
    }

    public void DragA3()
    {
        A3.transform.position = Input.mousePosition;
    }

    public void DragA4()
    {
        A4.transform.position = Input.mousePosition;
    }

    public void DragA5()
    {
        A5.transform.position = Input.mousePosition;
    }

 

    public void DropA1()
    {
        float Distance = Vector3.Distance(A1.transform.position, B1.transform.position);
        if (Distance < 50)
        {
            A1.transform.position = B1.transform.position;
            source.clip = correct;
            source.Play();
            A1correct = true;
        }
        else
        {
            A1.transform.position = A1InitialPos;
            source.clip = incorrect;
            source.Play();
        }
    }

    public void DropA2()
    {
        float Distance = Vector3.Distance(A2.transform.position, B2.transform.position);
        if (Distance < 50)
        {
            A2.transform.position = B2.transform.position;
            source.clip = correct;
            source.Play();
            A2correct = true;
        }
        else
        {
            A2.transform.position = A2InitialPos;
            source.clip = incorrect;
            source.Play();
        }
    }

    public void DropA3()
    {
        float Distance = Vector3.Distance(A3.transform.position, B3.transform.position);
        if (Distance < 50)
        {
            A3.transform.position = B3.transform.position;
            source.clip = correct;
            source.Play();
            A3correct = true;
        }
        else
        {
            A3.transform.position = A3InitialPos;
            source.clip = incorrect;
            source.Play();
        }
    }

    public void DropA4()
    {
        float Distance = Vector3.Distance(A4.transform.position, B4.transform.position);
        if (Distance < 50)
        {
            A4.transform.position = B4.transform.position;
            source.clip = correct;
            source.Play();
            A4correct = true;
        }
        else
        {
            A4.transform.position = A4InitialPos;
            source.clip = incorrect;
            source.Play();
        }
    }

    public void DropA5()
    {
        float Distance = Vector3.Distance(A5.transform.position, B5.transform.position);
        if (Distance < 50)
        {
            A5.transform.position = B5.transform.position;
            source.clip = correct;
            source.Play();
            A5correct = true;
        }
        else
        {
            A5.transform.position = A5InitialPos;
            source.clip = incorrect;
            source.Play();
        }
    }

 



    void Update()
    {
        if(A1correct && A2correct && A3correct && A4correct && A5correct)
        {
            Invoke ("Armado", 0.3f);
        }

    }

    void Armado()
    {
        Debug.Log("You win");
        {pantallaContinuarz.gameObject.SetActive(true); }

    }



}
